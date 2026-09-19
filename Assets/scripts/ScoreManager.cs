using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine.SceneManagement;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI ScoreRed;
    public TextMeshProUGUI ScoreBlue;
    public GameObject Red_Won;
    public GameObject Blue_Won;
    public float timer = 0f;
    public int Score_Red = 0;
    public int Score_Blue = 0;

    private void Awake()
    {
       instance = this; 
    }
    void Start()
    {
        ScoreRed.text = Score_Red.ToString();
        ScoreBlue.text = Score_Blue.ToString();
    }

    public void AddRedPoint()
    {
        Score_Red += 1;
        ScoreRed.text = Score_Red.ToString();
    }
    public void AddBluePoint()
    {
        Score_Blue += 1;
        ScoreBlue.text = Score_Blue.ToString();
    }
    public void RedWon()
    {
        Red_Won.SetActive(true);
        timer +=Time.deltaTime;
        if (timer>=3)
        {
            Red_Won.SetActive(false);
        //leave the game
        SceneManager.LoadScene("Lobby");
        }  
    }
    public void BlueWon()
    {
        Blue_Won.SetActive(true);
        timer += Time.deltaTime;
        if (timer>= 3)
        {
            Blue_Won.SetActive(false);
            //leave the game
            SceneManager.LoadScene("Lobby");
        }
    }
}
