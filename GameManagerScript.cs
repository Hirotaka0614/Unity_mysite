using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public static int[,] Block = new int[7, 7];
    public static int[,] Erase = new int[7, 7];
    int currentColor;
    int i, j;
    int pointcolor, x, y, x1, y1, x2, y2, z;
    public static int s;
    public static bool touching = false, isPlaying = false,go=false;
    RaycastHit hit;
    public static int Num;
    public Text timeText;
    GameObject[] puyos;
    // Start is called before the first frame update
    void Start()
    {
        
            for (i = 0; i < 7; i++)
        {
            for (j = 0; j < 7; j++)
            {
                Block[i, j] = Random.Range(0, 6);
                ColorScript.list[i, j] = Block[i, j];
                Erase[i, j] = 0;
            }
        }
        
        
    }    
    void Update()
    {
        if (TimerScript.minute==0 && TimerScript.seconds<1)
        {
            isPlaying = false;
            TimerScript.minute = 0;
            TimerScript.seconds = 0;
            TimerScript.timerText.text = TimerScript.minute.ToString("00") + ":" + ((int)TimerScript.seconds).ToString("00");
            puyos = GameObject.FindGameObjectsWithTag("puyo");
            foreach (GameObject puyo in puyos)
            {
                puyo.transform.Translate(Random.Range(-1.0f,1.0f), Random.Range(-2.0f, 4.0f), Random.Range(-2.0f,2.0f), Space.World);
            }
            Invoke("EndMethod", 1.5f); 
        }
        if (isPlaying == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //最初の色を取得
            if (Input.GetMouseButtonDown(0))
            {
                for (i = 0; i < 7; i++)
                {
                    for (j = 0; j < 7; j++)
                    {
                        Erase[i, j] = 0;
                    }
                }
                s = 0;
                if (Physics.Raycast(ray, out hit, 100))
                {
                    currentColor = Ray(0);
                    //Debug.Log(currentColor);
                    s = 1;
                    x1 = Ray(1);
                    y1 = Ray(2);
                    Erase[x1, y1] = 1;
                    //Debug.Log(x1);
                    touching = true;
                }
            }
            if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit, 100) && touching == true && (x1 != Ray(1) || y1 != Ray(2)))
            {
                pointcolor = Ray(0);
                x2 = Ray(1);
                y2 = Ray(2);
                //Debug.Log(x2);
                if ((System.Math.Abs(x1 - x2) == 1 || System.Math.Abs(y1 - y2) == 1) && currentColor == pointcolor)
                {
                    Erase[x2, y2] = 1;
                    s += 1;
                    // Debug.Log(Erase[x2, y2]);
                    x1 = x2;
                    y1 = y2;
                }
            }
        }
    }
    void EndMethod()
    {
        SceneManager.LoadScene("EndScene");
    }
    public int Ray(int i)
    {
        if (hit.collider.gameObject.transform.position == new Vector3(0, 0, 10))
        {
            z = BlockScript.a[3, 3];
            x = 3; y = 3;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(0.5f, 0, 10))
        {
            z = BlockScript.a[3, 4];
            x = 3; y = 4;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.0f, 0, 10))
        {
            z = BlockScript.a[3, 5];
            x = 3; y = 5;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.5f, 0, 10))
        {
            z = BlockScript.a[3, 6];
            x = 3; y = 6;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-0.5f, 0, 10))
        {
            z = BlockScript.a[3, 2];
            x = 3; y = 2;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.0f, 0, 10))
        {
            z = BlockScript.a[3, 1];
            x = 3; y = 1;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.5f, 0, 10))
        {
            z = BlockScript.a[3, 0];
            x = 3; y = 0;
        }
        //3行目
        if (hit.collider.gameObject.transform.position == new Vector3(0, 0.5f, 10))
        {
            z = BlockScript.a[2, 3];
            x = 2; y = 3;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(0.5f, 0.5f, 10))
        {
            z = BlockScript.a[2, 4];
            x = 2; y = 4;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.0f, 0.5f, 10))
        {
            z = BlockScript.a[2, 5];
            x = 2; y = 5;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.5f, 0.5f, 10))
        {
            z = BlockScript.a[2, 6];
            x = 2; y = 6;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-0.5f, 0.5f, 10))
        {
            z = BlockScript.a[2, 2];
            x = 2; y = 2;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.0f, 0.5f, 10))
        {
            z = BlockScript.a[2, 1];
            x = 2; y = 1;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.5f, 0.5f, 10))
        {
            z = BlockScript.a[2, 0];
            x = 2; y = 0;
        }
        //2行目
        if (hit.collider.gameObject.transform.position == new Vector3(0, 1, 10))
        {
            z = BlockScript.a[1, 3];
            x = 1; y = 3;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(0.5f, 1, 10))
        {
            z = BlockScript.a[1, 4];
            x = 1; y = 4;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.0f, 1, 10))
        {
            z = BlockScript.a[1, 5];
            x = 1; y = 5;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.5f, 1, 10))
        {
            z = BlockScript.a[1, 6];
            x = 1; y = 6;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-0.5f, 1, 10))
        {
            z = BlockScript.a[1, 2];
            x = 1; y = 2;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.0f, 1, 10))
        {
            z = BlockScript.a[1, 1];
            x = 1; y = 1;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.5f, 1, 10))
        {
            z = BlockScript.a[1, 0];
            x = 1; y = 0;
        }
        //1行目
        if (hit.collider.gameObject.transform.position == new Vector3(0, 1.5f, 10))
        {
            z = BlockScript.a[0, 3];
            x = 0; y = 3;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(0.5f, 1.5f, 10))
        {
            z = BlockScript.a[0, 4];
            x = 0; y = 4;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.0f, 1.5f, 10))
        {
            z = BlockScript.a[0, 5];
            x = 0; y = 5;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.5f, 1.5f, 10))
        {
            z = BlockScript.a[0, 6];
            x = 0; y = 6;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-0.5f, 1.5f, 10))
        {
            z = BlockScript.a[0, 2];
            x = 0; y = 2;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.0f, 1.5f, 10))
        {
            z = BlockScript.a[0, 1];
            x = 0; y = 1;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.5f, 1.5f, 10))
        {
            z = BlockScript.a[0, 0];
            x = 0; y = 0;
        }
        //5行目
        if (hit.collider.gameObject.transform.position == new Vector3(0, -0.5f, 10))
        {
            z = BlockScript.a[4, 3];
            x = 4; y = 3;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(0.5f, -0.5f, 10))
        {
            z = BlockScript.a[4, 4];
            x = 4; y = 4;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.0f, -0.5f, 10))
        {
            z = BlockScript.a[4, 5];
            x = 4; y = 5;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.5f, -0.5f, 10))
        {
            z = BlockScript.a[4, 6];
            x = 4; y = 6;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-0.5f, -0.5f, 10))
        {
            z = BlockScript.a[4, 2];
            x = 4; y = 2;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.0f, -0.5f, 10))
        {
            z = BlockScript.a[4, 1];
            x = 4; y = 1;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.5f, -0.5f, 10))
        {
            z = BlockScript.a[4, 0];
            x = 4; y = 0;
        }
        //6行目
        if (hit.collider.gameObject.transform.position == new Vector3(0, -1, 10))
        {
            z = BlockScript.a[5, 3];
            x = 5; y = 3;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(0.5f, -1, 10))
        {
            z = BlockScript.a[5, 4];
            x = 5; y = 4;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.0f, -1, 10))
        {
            z = BlockScript.a[5, 5];
            x = 5; y = 5;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.5f, -1, 10))
        {
            z = BlockScript.a[5, 6];
            x = 5; y = 6;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-0.5f, -1, 10))
        {
            z = BlockScript.a[5, 2];
            x = 5; y = 2;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.0f, -1, 10))
        {
            z = BlockScript.a[5, 1];
            x = 5; y = 1;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.5f, -1, 10))
        {
            z = BlockScript.a[5, 0];
            x = 5; y = 0;
        }
        //7行目
        if (hit.collider.gameObject.transform.position == new Vector3(0, -1.5f, 10))
        {
            z = BlockScript.a[6, 3];
            x = 6; y = 3;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(0.5f, -1.5f, 10))
        {
            z = BlockScript.a[6, 4];
            x = 6; y = 4;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.0f, -1.5f, 10))
        {
            z = BlockScript.a[6, 5];
            x = 6; y = 5;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(1.5f, -1.5f, 10))
        {
            z = BlockScript.a[6, 6];
            x = 6; y = 6;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-0.5f, -1.5f, 10))
        {
            z = BlockScript.a[6, 2];
            x = 6; y = 2;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.0f, -1.5f, 10))
        {
            z = BlockScript.a[6, 1];
            x = 6; y = 1;
        }
        if (hit.collider.gameObject.transform.position == new Vector3(-1.5f, -1.5f, 10))
        {
            z = BlockScript.a[6, 0];
            x = 6; y = 0;
        }
        if (i == 0)
        {
            return z;
        }
        if (i == 1)
        {
            return x;
        }
        if (i == 2)
        {
            return y;
        }
        else { return 10; }
    }

}
