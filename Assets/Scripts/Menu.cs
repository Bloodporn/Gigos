using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PressGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void PressExitApp()
    {
        Application.Quit();
        Debug.Log("EXIT");      
    }
}
