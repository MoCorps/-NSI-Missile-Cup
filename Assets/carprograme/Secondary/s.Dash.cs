using UnityEngine;
using System.Collections;

public class sDash : MonoBehaviour
{
    public sJump jscript;
    
    public bool hasDashed = false;

    public int dashForce = 4500;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       //dash
        if (Input.GetKeyDown(KeyCode.Comma) == true && Input.GetKey(KeyCode.I) == true && jscript.grounded == false && hasDashed == false)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * dashForce, ForceMode.Impulse);
            GetComponent<Rigidbody>().useGravity = true;
            hasDashed = true;
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.Comma) == true && Input.GetKey(KeyCode.L) == true && jscript.grounded == false && hasDashed == false)
        {
            GetComponent<Rigidbody>().AddForce(transform.right * dashForce, ForceMode.Impulse);
            GetComponent<Rigidbody>().useGravity = true;
            hasDashed = true;
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.Comma) == true && Input.GetKey(KeyCode.J) == true && jscript.grounded == false && hasDashed == false)
        {
            GetComponent<Rigidbody>().AddForce(-transform.right * dashForce, ForceMode.Impulse);
            GetComponent<Rigidbody>().useGravity = true;
            hasDashed = true;
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.Comma) == true && Input.GetKey(KeyCode.K) == true && jscript.grounded == false && hasDashed == false)
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * dashForce, ForceMode.Impulse);
            GetComponent<Rigidbody>().useGravity = true;
            hasDashed = true;
        }

        //set dashing permit
        if (hasDashed == true && jscript.grounded == true)
            hasDashed = false;
    }
}
