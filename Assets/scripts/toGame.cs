using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGame : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Map");
        Debug.Log("Game scene");
    }
}
