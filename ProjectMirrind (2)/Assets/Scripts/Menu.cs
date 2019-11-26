using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public void StartGame()
    {
        print("Loading scene...");
        SceneManager.LoadScene("Level1");
    }

    public void Quitgame()
    {
        print("Quit game");
        Application.Quit();
    }


    public void Reload()
    {
        SceneManager.LoadScene("Level1");
    }

    public void MenuLoad()
    {
        SceneManager.LoadScene("Menu");
    }
}
