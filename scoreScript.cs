using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreScript : MonoBehaviour
{
    private Text scoreText;
    public static int score,oldscore;
    public int n=1,a,b,c,d,e,f,g,h,i,j,k,l,m,o,p,q,r,s,t,u,v,w,x,y;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        oldscore=0;
        scoreText = GetComponentInChildren<Text>();
        a = 0;
        b = 0;
        c = 0;
        d= 0;
        e= 0;
        f = 0;
        g = 0;
        h = 0;
        i = 0;
        j = 0;
        k = 0;
        l = 0;
        m= 0;
        o = 0;
        p= 0;
        q = 0;
        r= 0;
        s = 0;
        t = 0;
        u= 0;
        v = 0;
        w = 0;
        x = 0;
        y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (BoostScript.boost == true)
        {
            n = Random.Range(10, 21);
        }
        if (BoostScript.boost == false)
        {
            n = 1;
        }

        if (Input.GetMouseButtonUp(0) && ChangeScript.n == false)
        {
            if (GameManagerScript.s == 3)
            {
                score+=100*n;
            }
            if (GameManagerScript.s == 4)
            {
                score+= 200*n;
            }
            if (GameManagerScript.s == 5)
            {
                score+= 500*n;
            }
            if (GameManagerScript.s == 6)
            {
                score+=1000*n;
            }
            if (GameManagerScript.s == 7)
            {
                score += 2000*n;
            }
            if (GameManagerScript.s > 7)
            {
                score += 5000*n;
            }
            if (score > 100000 && a==0)
            {
                TimerScript.t *= 1.1f;
                TimerScript.seconds += 30.0f;
                a = 1;
            }
            if (score > 150000 && b == 0)
            {
                TimerScript.seconds += 45.0f;
                b = 1;
            }
            if (score > 160000 && c == 0)
            {
                TimerScript.minute+=1.0f;
                c=1;
            }
            if (score > 170000 && d == 0)
            {
                TimerScript.minute += 1.0f;
                TimerScript.seconds += 30.0f;
                d = 1;
            }
            if (score > 180000 && e == 0)
            {
                TimerScript.minute += 1.0f;
                TimerScript.seconds += 45.0f;
                e= 1;
            }
            if (score > 190000 && f == 0)
            {
                TimerScript.minute += 2.0f;
                f=1;
            }
            if (score > 200000 && g == 0)
            {
                TimerScript.minute += 2.0f;
                TimerScript.t *= 1.1f;
                g = 1;
            }
            if (score > 210000 && h == 0)
            {
                TimerScript.minute += 3.0f;
                h = 1;
            }
            if (score > 220000 && i == 0)
            {
                TimerScript.minute += 3.0f;
                i = 1;
            }
            if (score > 230000 && j == 0)
            {
                TimerScript.minute += 3.0f;
                TimerScript.seconds += 30.0f;

                j = 1;
            }
            if (score > 240000 && k == 0)
            {
                TimerScript.minute += 3.0f;
                TimerScript.seconds += 45.0f;

                k = 1;
            }
            if (score > 250000 && l == 0)
            {
                TimerScript.minute += 4.0f;
                l = 1;
            }
            if (score > 300000 &&  m== 0)
            {
                TimerScript.minute += 5.0f;

                m = 1;
            }
            if (score > 400000 && o == 0)
            {
                TimerScript.minute += 10.0f;
                o = 1;
            }
            if (score > 500000 && p == 0)
            {
                TimerScript.minute += 10.0f;
                p = 1;
            }
            if (score > 600000 && q == 0)
            {
                TimerScript.minute += 10.0f;
                q = 1;
            }
            if (score > 650000 && r == 0)
            {
                TimerScript.minute += 15.0f;
                r = 1;
            }
            if (score > 700000 && s == 0)
            {
                TimerScript.minute += 15.0f;
                s = 1;
            }
            if (score > 750000 && t == 0)
            {
                TimerScript.minute += 15.0f;
                t = 1;
            }
            if (score > 800000 && u == 0)
            {
                TimerScript.minute += 20.0f;
                u = 1;
            }
            if (score > 850000 && v == 0)
            {
                TimerScript.minute += 20.0f;
                v = 1;
            }
            if (score > 900000 && w == 0)
            {
                TimerScript.minute += 30.0f;
                w= 1;
            }
            if (score > 950000 && x == 0)
            {
                TimerScript.minute += 30.0f;
                x = 1;
            }
            if (score > 1000000 && y == 0)
            {
                TimerScript.minute += 40.0f;
                y = 1;
            }


        }
        if ((int)score != (int)oldscore)
        {
            scoreText.text = score.ToString() ;
        }
        oldscore = score;
        PlayerPrefs.SetInt("score", score);
    }
}
