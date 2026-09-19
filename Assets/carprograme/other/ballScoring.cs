using UnityEditor.Rendering;
using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class ballScoring : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public Rigidbody ball;
    [SerializeField] CinemachineVirtualCameraBase SeconCam;
    int Score_Red = 0;
    int Score_Blue = 0;
    public float ballXPosition;
    public float ballYPosition;
    public float ballZPosition;
    public float rotX,redrotX, bluerotX;
    public float rotY, redrotY, bluerotY;
    public float rotZ, redrotZ, bluerotZ;
    public float posX, redposX, blueposX;
    public float posY,redposY, blueposY;
    public float posZ, redposZ, blueposZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ballXPosition = transform.position.x;
        ballYPosition = transform.position.y;
        ballZPosition = transform.position.z;

        //1 + 144 or more X + Y 4.5-20 + Z -45 to 1
        if ((ballXPosition >= 144) && (ballYPosition >= 4.5) && (ballYPosition <= 20) && (ballZPosition >= -45) && (ballZPosition < 1))
        {
            ScoreManager.instance.AddRedPoint();Score_Red+= 1;//add one to red score
            car1.SetActive(false);
            car2.SetActive(false);
            ball.constraints = RigidbodyConstraints.FreezePosition;
            ball.constraints = RigidbodyConstraints.FreezeRotation;
            transform.eulerAngles = new Vector3(rotX, rotY, rotZ);
            transform.position = new Vector3(posX, posY, posZ);
            car1.transform.eulerAngles = new Vector3(redrotX, redrotY, redrotZ);
            car1.transform.position = new Vector3(redposX, redposY, redposZ);
            car2.transform.eulerAngles = new Vector3(bluerotX, bluerotY, bluerotZ);
            car2.transform.position = new Vector3(blueposX, blueposY, blueposZ);
            car1.SetActive(true);
            car2.SetActive(true);
            CameraSwitcher.SwitchCamera(SeconCam);
            ball.constraints = RigidbodyConstraints.None;
        }

        //1 + -141 or more X + Y 4.5-20 + Z -45 to 1
        if ((ballXPosition <= -141) && (ballYPosition >= 4.5) && (ballYPosition <= 20) && (ballZPosition >= -45) && (ballZPosition < 1))
        {
            
            ScoreManager.instance.AddBluePoint();Score_Blue += 1;//add one to blue score
            car1.SetActive(false);
            car2.SetActive(false);
            ball.constraints = RigidbodyConstraints.FreezePosition;
            ball.constraints = RigidbodyConstraints.FreezeRotation;
            transform.eulerAngles = new Vector3(rotX, rotY, rotZ);
            transform.position = new Vector3(posX, posY, posZ);
            car1.transform.eulerAngles = new Vector3(redrotX, redrotY, redrotZ);
            car1.transform.position = new Vector3(redposX, redposY, redposZ);
            car2.transform.eulerAngles = new Vector3(bluerotX, bluerotY, bluerotZ);
            car2.transform.position = new Vector3(blueposX, blueposY, blueposZ);
            car1.SetActive(true);
            car2.SetActive(true);
            CameraSwitcher.SwitchCamera(SeconCam);
            ball.constraints = RigidbodyConstraints.None;
        }
        if (Score_Red == 5)
        {
            ScoreManager.instance.RedWon();
        }
        if (Score_Blue == 5)
        {
            ScoreManager.instance.BlueWon();
        }
    }
}
