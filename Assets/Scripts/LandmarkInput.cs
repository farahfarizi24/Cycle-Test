using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LandmarkInput : MonoBehaviour
{

    public UnityEngine.UI.Toggle[] correct_toggles;
    public UnityEngine.UI.Toggle[] incorrect_toggles;
    public static int correct_score;
    public static int incorrect_score;
    private StreamWriter sw;

 
    public void ScoreCount()
    {
        correct_score = 0; incorrect_score = 0;

        for (int i = 0; i < correct_toggles.Length; i++)
        {
            correct_score += Convert.ToInt32(correct_toggles[i].isOn);
        }

        for (int i = 0; i < incorrect_toggles.Length; i++)
        {
            incorrect_score += Convert.ToInt32(incorrect_toggles[i].isOn);
        }

    }

    public void ToggleData()
    {
        sw = File.AppendText(DataCollection.path);
        for (int i = 0; i < correct_toggles.Length; i++)
        {
            sw.Write("," + Convert.ToInt32(correct_toggles[i].isOn));
            
        }
        for (int i = 0;i < 19; i++)
        {
            sw.Write("," + Convert.ToInt32(incorrect_toggles[i].isOn));
            
        }
        sw.Close();

    }
    
}
