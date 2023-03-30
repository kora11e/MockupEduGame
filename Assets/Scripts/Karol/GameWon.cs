using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour
{
    private int DoneTasksCounter;
    private string input;

    void Update()
    {
        if (DoneTasksCounter == 3)
        {
            Debug.Log("Won");
            DoneTasksPlus();
            SceneManager.LoadScene("DivisionLockGame");
        }
    }
    private void DoneTasksPlus()
    {
        DoneTasksCounter++;
    }

    public void ReadStringInput(string number)
    {
        input = number;

        switch (input)
        {
            case "250":
                Debug.Log(input);
                DoneTasksPlus();
                break;
            case "400":
                Debug.Log(input);
                DoneTasksPlus();
                break;
            case "100":
                Debug.Log(input);
                DoneTasksPlus();
                break;
        }
    }
}
