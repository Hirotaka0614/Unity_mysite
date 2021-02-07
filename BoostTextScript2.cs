using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostTextScript2 : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BoostScript.boost==true)
        {
            text = this.GetComponent<Text>();
            text.color = new Color(255, 255, 255, 255);
        }
        if (BoostScript.boost == false)
        {
            text = this.GetComponent<Text>();
            text.color = new Color(0, 0, 0, 255);
        }
        if(TimerScript.minute == 0 && TimerScript.seconds < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
