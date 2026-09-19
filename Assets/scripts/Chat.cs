using UnityEngine;

public class Chat : MonoBehaviour
{
    public GameObject WAS;
    public GameObject NS;
    public GameObject TMC;
    public float timer1 = 0f;
    int time1 = 0;
    public float timer2 = 0f;
    int time2 = 0;
    public float timer3 = 0f;
    int time3 = 0;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            time1 += 1;
            WAS.SetActive(true);
        }if (time1 >=1)
            {
                timer1+=Time.deltaTime;
                if(timer1>=3)
                {
                    WAS.SetActive(false);
                    timer1 = 0f;
                    time1 = 0;
                }
            }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            time2 += 1;
            NS.SetActive(true);
            
        }if (time2 >=1)
            {
                timer2+=Time.deltaTime;
                if(timer2>=3)
                {
                    NS.SetActive(false);
                    timer2 = 0f;
                    time2 = 0;
                }
            }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            time3 += 1;
            TMC.SetActive(true);
            
        }if (time3 >=1)
            {
                timer3+=Time.deltaTime;
                if(timer3>=3)
                {
                    TMC.SetActive(false);
                    timer3 = 0f;
                    time3 = 0;
                }
            }
    }
}
