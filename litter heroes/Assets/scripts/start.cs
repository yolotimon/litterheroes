using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("GameClosed");
    }

    public void Startgame()
    {
        SceneManager.LoadScene("Level1");
    }
}
