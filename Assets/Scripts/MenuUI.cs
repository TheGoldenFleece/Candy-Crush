using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName("Game").buildIndex);
    }

    public void Data()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName("Data").buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
