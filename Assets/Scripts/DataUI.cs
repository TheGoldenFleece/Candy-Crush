using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataUI : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName("Menu").buildIndex);
    }
}
