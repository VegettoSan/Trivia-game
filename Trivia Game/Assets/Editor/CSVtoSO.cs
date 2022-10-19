using UnityEngine;
using UnityEditor;
using System.IO;

public class CSVtoSO
{
    private static string CSVPath = Application.streamingAssetsPath + "/" + "Datos" + ".csv";

    [MenuItem("Utilities/Generate Question")]

    public static void GenerateQuestion()
    {
        string[] allLines = File.ReadAllLines(/*Application.dataPath + */CSVPath);

        foreach(string s in allLines)
        {
            string[] splitData = s.Split(',');

            QuestionsAndAnswers _questionsAndAnswers = ScriptableObject.CreateInstance<QuestionsAndAnswers>();
            _questionsAndAnswers.QuestionNumber = splitData[0];
            _questionsAndAnswers.QuestionName = splitData[1];
            _questionsAndAnswers.A = splitData[2];
            _questionsAndAnswers.B = splitData[3];
            _questionsAndAnswers.C = splitData[4];
            _questionsAndAnswers.D = splitData[5];
            _questionsAndAnswers.CorrectAnswer = splitData[6];

            AssetDatabase.CreateAsset(_questionsAndAnswers, $"Assets/Questions/{_questionsAndAnswers.QuestionNumber}.asset");
        }

        AssetDatabase.SaveAssets();
    }
}
