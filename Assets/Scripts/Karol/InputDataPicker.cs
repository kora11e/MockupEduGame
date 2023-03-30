using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputDataPicker : MonoBehaviour
{
    public bool answer;
    private InputField input;


    private void SubmitName(string arg0)
    {
        Debug.Log(arg0);
    }
    private void SubmitAnswer(string arg0)
    {
        answer = true;
    }
}
