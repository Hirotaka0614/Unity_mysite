using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour
{ public static bool boost=false;
    public static int n = 0;
    public static  bool last = false;
    public GameObject booster1, booster2, booster3, booster4, booster5, booster6;
    GameObject[] boosters;
    // Start is called before the first frame update
    private void Update()
    {
        if (boost == false || GameManagerScript.isPlaying==false)
        {
            boosters = GameObject.FindGameObjectsWithTag("booster");
            foreach (GameObject booster in boosters)
            {
                Destroy(booster);
            }
            n = 0;
        }
        if(TimerScript.seconds<=6 && TimerScript.minute == 0)
        {
            last = true;
            BoostButton();
        }
        if (TimerScript.seconds > 6 && TimerScript.minute >= 0)
        {
            last = false;
        }
    }
    public void BoostButton()
    {
        if( (boost == false && TimerScript.minute >= 2) || (boost == false && last == true && boost == false)){

            if (n == 0)
            {
                GameManagerScript.s = 0;
                boost = true;
                n = 1;
            }
        }
        if (n == 1)
        {
            Instantiate(booster1, new Vector3(-2.0f, -5.0f, 10.0f), Quaternion.identity);
            Instantiate(booster2, new Vector3(-1.0f, -5.0f, 10.0f), Quaternion.identity);
            Instantiate(booster3, new Vector3(0, -5.0f, 10.0f), Quaternion.identity);
            Instantiate(booster4, new Vector3(1.0f, -5.0f, 10.0f), Quaternion.identity);
            Instantiate(booster5, new Vector3(2.0f, -5.0f, 10.0f), Quaternion.identity);
            n = 2;
            TimerScript.t *= 1.1f;
        }


    }
}
