using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGame : MonoBehaviour
{
    #region Variables
    [SerializeField] QuestionsAndAnswers[] Datas;
    [SerializeField] QuestionsAndAnswers ActualQuestion, Question1, Question2, Question3, Question4, Question5;
    [SerializeField] TMP_Text Question;
    [SerializeField] TMP_Text A,B,C,D;
    [SerializeField] string CorrectAnswer;
    [SerializeField] Image ButtonA, ButtonB, ButtonC, ButtonD;
    [SerializeField] GameObject NextButton;
    [SerializeField] AudioSource Source;
    [SerializeField] AudioClip Correct, Incorrect;
    [SerializeField] TMP_Text CountTime;
    [SerializeField] float Timer;
    private bool EnableTimer;

    private string SelectedAnswer;
    private int _score;
    [SerializeField] TMP_Text ScoreText;

    [SerializeField] GameObject Trivia, MainMenu;

    #endregion

    void Update()
    {
        CountTime.text = $"Tiempo Restante\n {Timer}";
        ScoreText.text = $"PUNTAJE\n {_score}";

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetQuestions();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            SelectedQuestions();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextQuestion();
        }

        switch (EnableTimer)
        {
            case true:

                Enable_Timer(true);

                break;

            case false:

                Enable_Timer(false);

                break;
        }
    }

    #region NextQuestion

    public void NextQuestion()
    {
        Timer = 60f;
        if(ActualQuestion == Question1)
        {
            SelectedQuestion2();
        }
        else if (ActualQuestion == Question2)
        {
            SelectedQuestion3();
        }
        else if (ActualQuestion == Question3)
        {
            SelectedQuestion4();
        }
        else if (ActualQuestion == Question4)
        {
            SelectedQuestion5();
        }
        else if (ActualQuestion == Question5)
        {
            Trivia.SetActive(false);
            MainMenu.SetActive(true);
            ResetQuestions();
        }
    }

    #endregion

    #region SelectedQuestion
    public void SelectedQuestion1()
    {
        ButtonA.gameObject.SetActive(true);
        ButtonB.gameObject.SetActive(true);
        ButtonC.gameObject.SetActive(true);
        ButtonD.gameObject.SetActive(true);

        EnableTimer = true;
        ButtonA.color = Color.white;
        ButtonB.color = Color.white;
        ButtonC.color = Color.white;
        ButtonD.color = Color.white;

        ActualQuestion = Question1;
        Question.text = Question1.QuestionName;
        A.text = Question1.A;
        B.text = Question1.B;
        C.text = Question1.C;
        D.text = Question1.D;
        CorrectAnswer = Question1.CorrectAnswer;

        Debug.Log("Q1");
    }
    public void SelectedQuestion2()
    {
        ButtonA.gameObject.SetActive(true);
        ButtonB.gameObject.SetActive(true);
        ButtonC.gameObject.SetActive(true);
        ButtonD.gameObject.SetActive(true);

        EnableTimer = true;
        ButtonA.color = Color.white;
        ButtonB.color = Color.white;
        ButtonC.color = Color.white;
        ButtonD.color = Color.white;

        ActualQuestion = Question2;
        Question.text = Question2.QuestionName;
        A.text = Question2.A;
        B.text = Question2.B;
        C.text = Question2.C;
        D.text = Question2.D;
        CorrectAnswer = Question2.CorrectAnswer;

        Debug.Log("Q2");
    }
    public void SelectedQuestion3()
    {
        ButtonA.gameObject.SetActive(true);
        ButtonB.gameObject.SetActive(true);
        ButtonC.gameObject.SetActive(true);
        ButtonD.gameObject.SetActive(true);

        EnableTimer = true;
        ButtonA.color = Color.white;
        ButtonB.color = Color.white;
        ButtonC.color = Color.white;
        ButtonD.color = Color.white;

        ActualQuestion = Question3;
        Question.text = Question3.QuestionName;
        A.text = Question3.A;
        B.text = Question3.B;
        C.text = Question3.C;
        D.text = Question3.D;
        CorrectAnswer = Question3.CorrectAnswer;

        Debug.Log("Q3");
    }
    public void SelectedQuestion4()
    {
        ButtonA.gameObject.SetActive(true);
        ButtonB.gameObject.SetActive(true);
        ButtonC.gameObject.SetActive(true);
        ButtonD.gameObject.SetActive(true);

        EnableTimer = true;
        ButtonA.color = Color.white;
        ButtonB.color = Color.white;
        ButtonC.color = Color.white;
        ButtonD.color = Color.white;

        ActualQuestion = Question4;
        Question.text = Question4.QuestionName;
        A.text = Question4.A;
        B.text = Question4.B;
        C.text = Question4.C;
        D.text = Question4.D;
        CorrectAnswer = Question4.CorrectAnswer;

        Debug.Log("Q4");
    }
    public void SelectedQuestion5()
    {
        ButtonA.gameObject.SetActive(true);
        ButtonB.gameObject.SetActive(true);
        ButtonC.gameObject.SetActive(true);
        ButtonD.gameObject.SetActive(true);

        EnableTimer = true;
        ButtonA.color = Color.white;
        ButtonB.color = Color.white;
        ButtonC.color = Color.white;
        ButtonD.color = Color.white;

        ActualQuestion = Question5;
        Question.text = Question5.QuestionName;
        A.text = Question5.A;
        B.text = Question5.B;
        C.text = Question5.C;
        D.text = Question5.D;
        CorrectAnswer = Question5.CorrectAnswer;

        Debug.Log("Q5");
    }

    public void SelectedQuestions()
    {
        ButtonA.color = Color.white;
        ButtonB.color = Color.white;
        ButtonC.color = Color.white;
        ButtonD.color = Color.white;

        if (Question1 == null)
        {
            int i = Random.Range(0, Datas.Length);
            Question1 = Datas[i];
        }
        if (Question1 != null && Question2 == null)
        {
            int i = Random.Range(0, Datas.Length);
            Question2 = Datas[i];
            if (Question2 == Question1)
            {
                i = Random.Range(0, Datas.Length);
                Question2 = Datas[i];
            }
        }
        if (Question2 != null && Question3 == null)
        {
            int i = Random.Range(0, Datas.Length);
            Question3 = Datas[i];
            if (Question3 == Question1 || Question3 == Question2)
            {
                i = Random.Range(0, Datas.Length);
                Question3 = Datas[i];
            }
        }
        if (Question3 != null && Question4 == null)
        {
            int i = Random.Range(0, Datas.Length);
            Question4 = Datas[i];
            if (Question4 == Question1 || Question4 == Question2 || Question4 == Question3)
            {
                i = Random.Range(0, Datas.Length);
                Question4 = Datas[i];
            }
        }
        if (Question4 != null && Question5 == null)
        {
            int i = Random.Range(0, Datas.Length);
            Question5 = Datas[i];
            if (Question5 == Question1 || Question5 == Question2 || Question5 == Question3 || Question5 == Question4)
            {
                i = Random.Range(0, Datas.Length);
                Question5 = Datas[i];
            }
        }
    }

    public void ResetQuestions()
    {
        Debug.Log("Reset");
        Question1 = null;
        Question2 = null;
        Question3 = null;
        Question4 = null;
        Question5 = null;
    }
    #endregion

    #region SelectedAnswer

    public void SelectA()
    {
        ButtonA.gameObject.SetActive(true);
        ButtonB.gameObject.SetActive(false);
        ButtonC.gameObject.SetActive(false);
        ButtonD.gameObject.SetActive(false);

        NextButton.SetActive(true);
        //Q1
        EnableTimer = false;
        if (ActualQuestion == Question1)
        {
            SelectedAnswer = Question1.A;

            if(SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonA.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonA.color = Color.red;

            }
        }
        //Q2
        EnableTimer = false;
        if (ActualQuestion == Question2)
        {
            SelectedAnswer = Question2.A;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonA.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonA.color = Color.red;

            }
        }
        //Q3
        EnableTimer = false;
        if (ActualQuestion == Question3)
        {
            SelectedAnswer = Question3.A;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonA.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonA.color = Color.red;
            }
        }
        //Q4
        EnableTimer = false;
        if (ActualQuestion == Question4)
        {
            SelectedAnswer = Question4.A;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonA.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonA.color = Color.red;

            }
        }
        //Q5
        EnableTimer = false;
        if (ActualQuestion == Question5)
        {
            SelectedAnswer = Question5.A;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonA.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonA.color = Color.red;

            }
        }
    }
    public void SelectB()
    {
        ButtonA.gameObject.SetActive(false);
        ButtonB.gameObject.SetActive(true);
        ButtonC.gameObject.SetActive(false);
        ButtonD.gameObject.SetActive(false);

        NextButton.SetActive(true);
        //Q1
        EnableTimer = false;
        if (ActualQuestion == Question1)
        {
            SelectedAnswer = Question1.B;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonB.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonB.color = Color.red;

            }
        }
        //Q2
        EnableTimer = false;
        if (ActualQuestion == Question2)
        {
            SelectedAnswer = Question2.B;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonB.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonB.color = Color.red;

            }
        }
        //Q3
        EnableTimer = false;
        if (ActualQuestion == Question3)
        {
            SelectedAnswer = Question3.B;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonB.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonB.color = Color.red;

            }
        }
        //Q4
        EnableTimer = false;
        if (ActualQuestion == Question4)
        {
            SelectedAnswer = Question4.B;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonB.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonB.color = Color.red;

            }
        }
        //Q5
        EnableTimer = false;
        if (ActualQuestion == Question5)
        {
            SelectedAnswer = Question5.B;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonB.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonB.color = Color.red;

            }
        }
    }
    public void SelectC()
    {
        ButtonA.gameObject.SetActive(false);
        ButtonB.gameObject.SetActive(false);
        ButtonC.gameObject.SetActive(true);
        ButtonD.gameObject.SetActive(false);

        NextButton.SetActive(true);
        //Q1
        EnableTimer = false;
        if (ActualQuestion == Question1)
        {
            SelectedAnswer = Question1.C;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonC.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonC.color = Color.red;

            }
        }
        //Q2
        EnableTimer = false;
        if (ActualQuestion == Question2)
        {
            SelectedAnswer = Question2.C;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonC.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonC.color = Color.red;

            }
        }
        //Q3
        EnableTimer = false;
        if (ActualQuestion == Question3)
        {
            SelectedAnswer = Question3.C;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonC.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonC.color = Color.red;

            }
        }
        //Q4
        EnableTimer = false;
        if (ActualQuestion == Question4)
        {
            SelectedAnswer = Question4.C;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonC.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonC.color = Color.red;

            }
        }
        //Q5
        EnableTimer = false;
        if (ActualQuestion == Question5)
        {
            SelectedAnswer = Question5.C;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonC.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonC.color = Color.red;

            }
        }
    }
    public void SelectD()
    {
        ButtonA.gameObject.SetActive(false);
        ButtonB.gameObject.SetActive(false);
        ButtonC.gameObject.SetActive(false);
        ButtonD.gameObject.SetActive(true);

        NextButton.SetActive(true);
        //Q1
        EnableTimer = false;
        if (ActualQuestion == Question1)
        {
            SelectedAnswer = Question1.D;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonD.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonD.color = Color.red;

            }
        }
        //Q2
        EnableTimer = false;
        if (ActualQuestion == Question2)
        {
            SelectedAnswer = Question2.D;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonD.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonD.color = Color.red;

                if (CorrectAnswer == Question2.A)
                {
                    ButtonD.gameObject.SetActive(true);
                }
                else if (CorrectAnswer == Question2.B)
                {
                    ButtonD.gameObject.SetActive(true);
                }
                else if (CorrectAnswer == Question3.C)
                {
                    ButtonD.gameObject.SetActive(true);
                }
            }
        }
        //Q3
        EnableTimer = false;
        if (ActualQuestion == Question3)
        {
            SelectedAnswer = Question3.D;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonD.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonD.color = Color.red;

                if (CorrectAnswer == Question3.A)
                {
                    ButtonD.gameObject.SetActive(true);
                }
                else if (CorrectAnswer == Question3.B)
                {
                    ButtonD.gameObject.SetActive(true);
                }
                else if (CorrectAnswer == Question3.C)
                {
                    ButtonD.gameObject.SetActive(true);
                }
            }
        }
        //Q4
        EnableTimer = false;
        if (ActualQuestion == Question4)
        {
            SelectedAnswer = Question4.D;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonD.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonD.color = Color.red;

                if (CorrectAnswer == Question4.A)
                {
                    ButtonD.gameObject.SetActive(true);
                }
                else if (CorrectAnswer == Question4.B)
                {
                    ButtonD.gameObject.SetActive(true);
                }
                else if (CorrectAnswer == Question4.C)
                {
                    ButtonD.gameObject.SetActive(true);
                }
            }
        }
        //Q5
        EnableTimer = false;
        if (ActualQuestion == Question5)
        {
            SelectedAnswer = Question5.D;

            if (SelectedAnswer == CorrectAnswer)
            {
                Source.PlayOneShot(Correct);
                ButtonD.color = Color.green;
                Score();
            }
            else if (SelectedAnswer != CorrectAnswer)
            {
                Source.PlayOneShot(Incorrect);
                ButtonD.color = Color.red;

                if (CorrectAnswer == Question5.A)
                {
                    ButtonD.gameObject.SetActive(true);
                }
                else if (CorrectAnswer == Question5.B)
                {
                    ButtonD.gameObject.SetActive(true);
                }
                else if (CorrectAnswer == Question5.C)
                {
                    ButtonD.gameObject.SetActive(true);
                }
            }
        }
    }

    #endregion

    #region Timer

    public void Enable_Timer(bool enable)
    {
        switch (enable)
        {
            case true:

                Timer -= Time.deltaTime * 1f;

                break;

            case false:

                //Timer = 60f;

                break;
        }
    }

    #endregion

    #region Score

    public void Score()
    {
        _score += 10 * (int)Timer;

        Debug.Log("Puntua");
    }
    public void ScoreReset()
    {
        _score = 0;
    }

    #endregion
}
