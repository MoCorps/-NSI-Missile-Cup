using UnityEngine;
using System.Collections;

public class sBoost : MonoBehaviour
{
    public sJump jscript;

    public int boostForce = 7000;

    public float boostLevel = 20;

    public int boostPlus = 3;
    
    public int boostMinus = 20;

    public float boostMax = 60.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (boostLevel < boostMax)
        {
            boostLevel += boostPlus * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.RightShift) == true && jscript.grounded == true && boostLevel > boostMinus)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * boostForce, ForceMode.Impulse);
            boostLevel -= boostMinus;
        }
    }
}
