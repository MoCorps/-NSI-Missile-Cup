using UnityEngine;
using System.Collections;

public class pBoost : MonoBehaviour
{
    public pJump jscript;

    public int boostForce = 7000;

    public float boostLevel = 20;

    public int boostPlus = 3;
    
    public int boostMinus = 20;

    public float boostMax = 60.0f;


    // Update is called once per frame
    void Update()
    {        
        if (boostLevel < boostMax)
        {
            boostLevel += boostPlus * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) == true && jscript.grounded == true && boostLevel > boostMinus)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * boostForce, ForceMode.Impulse);
            boostLevel -= boostMinus;
        }
    }
}
