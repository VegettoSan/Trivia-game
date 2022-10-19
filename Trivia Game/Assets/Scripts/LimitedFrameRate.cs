using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedFrameRate : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        Application.targetFrameRate = 60;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
