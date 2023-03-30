using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon2 : MonoBehaviour
{
    private int DoneTasksCounter2;
    private string input2;

    void Update()
    {
        if (DoneTasksCounter2 == 3)
        {
            Debug.Log("Won");
            DoneTasksPlus2();
            SceneManager.LoadScene("SubtractionLockGame");
        }
    }
    private void DoneTasksPlus2()
    {
        DoneTasksCounter2++;
    }

    public void ReadStringInput(string number)
    {
        input2 = number;

        switch (input2)
        {
            case "5":
                Debug.Log(input2);
                DoneTasksPlus2();
                break;
            case "3":
                Debug.Log(input2);
                DoneTasksPlus2();
                break;
            case "1":
                Debug.Log(input2);
                DoneTasksPlus2();
                break;
        }
    }
}
