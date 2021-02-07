using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    [SerializeField]
    public static float minute;
    [SerializeField]
    public static float seconds;
    //　前のUpdateの時の秒数
    private float oldSeconds;
    //　タイマー表示用テキスト
    public static Text timerText;
    public static float t;

    void Start()
    {
        minute = 1;
        seconds = 30f;
        oldSeconds =0f;
        timerText = GetComponentInChildren<Text>();
        t = 1.0f;
    }

    void Update()
    {
        if (seconds <= 0f)
        {
            minute--;
            seconds += 60;
        }
        if (seconds >= 60f)
        {
            minute++;
            seconds -= 60;
        }
        if (GameManagerScript.isPlaying == true)
        {
            seconds -= Time.deltaTime * t;
        }
        if (Input.GetMouseButtonUp(0) && BoostScript.last == false)
        {
            if (GameManagerScript.s == 3)
            {
                seconds += 5.0f;
            }
            if (GameManagerScript.s == 4)
            {
                seconds += 6.0f;
            }
            if (GameManagerScript.s == 5)
            {
                seconds += 7.0f;
            }
            if (GameManagerScript.s >= 6)
            {
                seconds += 10.0f;
            }

        }
        if (BoostScript.boost == true)
        {
            Invoke("BoostEndMethod", 5.0f);
        }
        //　値が変わった時だけテキストUIを更新
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
        if(minute==0 && seconds <= 6)
        {
            this.GetComponent<Text>().color = new Color(255, 0, 0, 255);
        }
    }

    void BoostEndMethod()
    {
        BoostScript.boost = false;
        seconds -= Time.deltaTime * 11;
    }
}