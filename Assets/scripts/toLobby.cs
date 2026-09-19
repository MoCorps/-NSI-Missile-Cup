using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLobby : MonoBehaviour
{
    public void Join()
    {
        SceneManager.LoadScene("Lobby");
        Debug.Log("Lobby");
    }
}
