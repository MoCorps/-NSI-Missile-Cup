using UnityEngine;

public class pStraight : MonoBehaviour
{
    public pJump jscript;

    Rigidbody rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jscript.grounded == false)
        {
            rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
            transform.eulerAngles = new Vector3(0, jscript.yangle, 0);
        }
        else
        {
            rigidBody.constraints = RigidbodyConstraints.None;
        }
    }
}
