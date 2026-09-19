using UnityEngine;

public class twoPersonGame : MonoBehaviour
{
    public float rotX = 0;
    public float rotY;
    public float rotZ = 0;
    public float posX;
    public float posY = 2f;
    public float posZ = -21.33f;
    
    Rigidbody rigidBody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            rigidBody.constraints = RigidbodyConstraints.FreezePosition;
            rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
            transform.eulerAngles = new Vector3(rotX, rotY, rotZ);
            transform.position = new Vector3(posX, posY, posZ);
            rigidBody.constraints = RigidbodyConstraints.None;
        }
    }
}
