using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon4 : MonoBehaviour
{
    private int DoneTasksCounter4;
    private string input4;

    void Update()
    {
        if (DoneTasksCounter4 == 3)
        {
            Debug.Log("Won");
            DoneTasksPlus4();
            //Application.LoadLevel("next");
        }
    }
    private void DoneTasksPlus4()
    {
        DoneTasksCounter4++;
    }

    public void ReadStringInput(string number)
    {
        input4 = number;

        switch (input4)
        {
            case "28":
                Debug.Log(input4);
                DoneTasksPlus4();
                break;
            case "13":
                Debug.Log(input4);
                DoneTasksPlus4();
                break;
            case "88":
                Debug.Log(input4);
                DoneTasksPlus4();
                break;
        }
    }
}
