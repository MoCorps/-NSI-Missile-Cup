using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public GameObject menu;
    public static bool GameIsPaused = false;
    
    void Start()
    {
        Resume();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused==true)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;    
    }
    public void Pause()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
