using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static float Score;

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        Score = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
