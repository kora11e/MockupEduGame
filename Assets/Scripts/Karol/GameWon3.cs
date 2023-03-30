using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon3 : MonoBehaviour
{
    private int DoneTasksCounter3;
    private string input3;

    void Update()
    {
        if (DoneTasksCounter3 == 3)
        {
            Debug.Log("Won");
            DoneTasksPlus3();
            SceneManager.LoadScene("SumLockGame");
        }
    }
    private void DoneTasksPlus3()
    {
        DoneTasksCounter3++;
    }

    public void ReadStringInput(string number)
    {
        input3 = number;

        switch (input3)
        {
            case "135":
                Debug.Log(input3);
                DoneTasksPlus3();
                break;
            case "55":
                Debug.Log(input3);
                DoneTasksPlus3();
                break;
            case "70":
                Debug.Log(input3);
                DoneTasksPlus3();
                break;
        }
    }
}
