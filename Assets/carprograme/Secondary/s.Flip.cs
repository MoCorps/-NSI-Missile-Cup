using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class sFlip : MonoBehaviour
{
    public float y_rotation;

    // Update is called once per frame
    void Update()
    {
        y_rotation = transform.eulerAngles.y;

        if (Input.GetKey(KeyCode.Semicolon))
            transform.eulerAngles = new Vector3(0, y_rotation, 0);
    }
}