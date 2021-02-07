using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostTextScript : MonoBehaviour
{
    Text text;
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerScript.minute >= 2)
        {
            text= this.GetComponent<Text>();
            text.color = new Color(255, 255, 255, 255);
            n = 1;
        }
        if(n==1 && TimerScript.minute< 2)
        {
            text.color = new Color(0, 0, 0, 255);
            n = 0;
        }
    }
}
