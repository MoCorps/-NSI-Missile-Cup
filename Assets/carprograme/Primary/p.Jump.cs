using UnityEngine;
using System.Collections;

public class pJump : MonoBehaviour
{
    Rigidbody rigidBody;
    
    public bool grounded = false;
    
    public float grounddistance = 0.5f;
    
    public int jumpForce = 4500;

    public float yangle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        yangle = transform.eulerAngles.y;

        //check ground distance
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, grounddistance))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
            transform.eulerAngles = new Vector3(0, yangle, 0); 
            GetComponent<Rigidbody>().AddForce(transform.up * jumpForce, ForceMode.Impulse);
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
