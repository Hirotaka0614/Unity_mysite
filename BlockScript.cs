using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlockScript : MonoBehaviour
{
    int i, j, r;
    public static int x, y;
    public int num;
    public static int b, c, d, e, f, g, h, n=0;
    public static int[,] a = new int[7, 7];
    public static bool moving = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        x = GetColorNum(1);
        y = GetColorNum(2);
        // Debug.Log(x);
        if (Input.GetMouseButtonUp(0))
        {

            if (GameManagerScript.Erase[x, y] == 1 && GameManagerScript.s > 2)
            {
                //Debug.Log(i);
                // Debug.Log(j);
                if (y == 0)
                {
                    b += 1;
                }
                if (y == 1)
                {
                    c += 1;
                }
                if (y == 2)
                {
                    d += 1;
                }
                if (y == 3)
                {
                    e += 1;
                }
                if (y == 4)
                {
                    f += 1;
                }
                if (y == 5)
                {
                    g += 1;
                }
                if (y == 6)
                {
                    h += 1;
                }
                Destroy(this.gameObject);

                //  Debug.Log(GameManagerScript.s);
            }
        }
       
    }

    int GetColorNum(int r)
    {
        i = this.GetComponent<ColorScript>().X;
        j = this.GetComponent<ColorScript>().Y;
        num = GameManagerScript.Block[i, j];
        if (this.gameObject.transform.position == new Vector3(0, 0, 10))
        {
            a[3, 3] = num;
            x = 3; y = 3;
        }
        if (this.gameObject.transform.position == new Vector3(0.5f, 0, 10))
        {
            a[3, 4] = num;
            x = 3; y = 4;
        }
        if (this.gameObject.transform.position == new Vector3(1.0f, 0, 10))
        {
            a[3, 5] = num;
            x = 3; y = 5;
        }
        if (this.gameObject.transform.position == new Vector3(1.5f, 0, 10))
        {
            a[3, 6] = num;
            x = 3; y = 6;
        }
        if (this.gameObject.transform.position == new Vector3(-0.5f, 0, 10))
        {
            a[3, 2] = num;
            x = 3; y = 2;
        }
        if (this.gameObject.transform.position == new Vector3(-1.0f, 0, 10))
        {
            a[3, 1] = num;
            x = 3; y = 1;
        }
        if (this.gameObject.transform.position == new Vector3(-1.5f, 0, 10))
        {
            a[3, 0] = num;
            x = 3; y = 0;
        }
        //3行目
        if (this.gameObject.transform.position == new Vector3(0, 0.5f, 10))
        {
            a[2, 3] = num;
            x = 2; y = 3;
        }
        if (this.gameObject.transform.position == new Vector3(0.5f, 0.5f, 10))
        {
            a[2, 4] = num;
            x = 2; y = 4;
        }
        if (this.gameObject.transform.position == new Vector3(1.0f, 0.5f, 10))
        {
            a[2, 5] = num;
            x = 2; y = 5;
        }
        if (this.gameObject.transform.position == new Vector3(1.5f, 0.5f, 10))
        {
            a[2, 6] = num;
            x = 2; y = 6;
        }
        if (this.gameObject.transform.position == new Vector3(-0.5f, 0.5f, 10))
        {
            a[2, 2] = num;
            x = 2; y = 2;
        }
        if (this.gameObject.transform.position == new Vector3(-1.0f, 0.5f, 10))
        {
            a[2, 1] = num;
            x = 2; y = 1;
        }
        if (this.gameObject.transform.position == new Vector3(-1.5f, 0.5f, 10))
        {
            a[2, 0] = num;
            x = 2; y = 0;
        }
        //2行目
        if (this.gameObject.transform.position == new Vector3(0, 1, 10))
        {
            a[1, 3] = num;
            x = 1; y = 3;
        }
        if (this.gameObject.transform.position == new Vector3(0.5f, 1, 10))
        {
            a[1, 4] = num;
            x = 1; y = 4;
        }
        if (this.gameObject.transform.position == new Vector3(1.0f, 1, 10))
        {
            a[1, 5] = num;
            x = 1; y = 5;
        }
        if (this.gameObject.transform.position == new Vector3(1.5f, 1, 10))
        {
            a[1, 6] = num;
            x = 1; y = 6;
        }
        if (this.gameObject.transform.position == new Vector3(-0.5f, 1, 10))
        {
            a[1, 2] = num;
            x = 1; y = 2;
        }
        if (this.gameObject.transform.position == new Vector3(-1.0f, 1, 10))
        {
            a[1, 1] = num;
            x = 1; y = 1;
        }
        if (this.gameObject.transform.position == new Vector3(-1.5f, 1, 10))
        {
            a[1, 0] = num;
            x = 1; y = 0;
        }
        //1行目
        if (this.gameObject.transform.position == new Vector3(0, 1.5f, 10))
        {
            a[0, 3] = num;
            x = 0; y = 3;
        }
        if (this.gameObject.transform.position == new Vector3(0.5f, 1.5f, 10))
        {
            a[0, 4] = num;
            x = 0; y = 4;
        }
        if (this.gameObject.transform.position == new Vector3(1.0f, 1.5f, 10))
        {
            a[0, 5] = num;
            x = 0; y = 5;
        }
        if (this.gameObject.transform.position == new Vector3(1.5f, 1.5f, 10))
        {
            a[0, 6] = num;
            x = 0; y = 6;
        }
        if (this.gameObject.transform.position == new Vector3(-0.5f, 1.5f, 10))
        {
            a[0, 2] = num;
            x = 0; y = 2;
        }
        if (this.gameObject.transform.position == new Vector3(-1.0f, 1.5f, 10))
        {
            a[0, 1] = num;
            x = 0; y = 1;
        }
        if (this.gameObject.transform.position == new Vector3(-1.5f, 1.5f, 10))
        {
            a[0, 0] = num;
            x = 0; y = 0;
        }
        //5行目
        if (this.gameObject.transform.position == new Vector3(0, -0.5f, 10))
        {
            a[4, 3] = num;
            x = 4; y = 3;
        }
        if (this.gameObject.transform.position == new Vector3(0.5f, -0.5f, 10))
        {
            a[4, 4] = num;
            x = 4; y = 4;
        }
        if (this.gameObject.transform.position == new Vector3(1.0f, -0.5f, 10))
        {
            a[4, 5] = num;
            x = 4; y = 5;
        }
        if (this.gameObject.transform.position == new Vector3(1.5f, -0.5f, 10))
        {
            a[4, 6] = num;
            x = 4; y = 6;
        }
        if (this.gameObject.transform.position == new Vector3(-0.5f, -0.5f, 10))
        {
            a[4, 2] = num;
            x = 4; y = 2;
        }
        if (this.gameObject.transform.position == new Vector3(-1.0f, -0.5f, 10))
        {
            a[4, 1] = num;
            x = 4; y = 1;
        }
        if (this.gameObject.transform.position == new Vector3(-1.5f, -0.5f, 10))
        {
            a[4, 0] = num;
            x = 4; y = 0;
        }
        //6行目
        if (this.gameObject.transform.position == new Vector3(0, -1, 10))
        {
            a[5, 3] = num;
            x = 5; y = 3;
        }
        if (this.gameObject.transform.position == new Vector3(0.5f, -1, 10))
        {
            a[5, 4] = num;
            x = 5; y = 4;
        }
        if (this.gameObject.transform.position == new Vector3(1.0f, -1, 10))
        {
            a[5, 5] = num;
            x = 5; y = 5;
        }
        if (this.gameObject.transform.position == new Vector3(1.5f, -1, 10))
        {
            a[5, 6] = num;
            x = 5; y = 6;
        }
        if (this.gameObject.transform.position == new Vector3(-0.5f, -1, 10))
        {
            a[5, 2] = num;
            x = 5; y = 2;
        }
        if (this.gameObject.transform.position == new Vector3(-1.0f, -1, 10))
        {
            a[5, 1] = num;
            x = 5; y = 1;
        }
        if (this.gameObject.transform.position == new Vector3(-1.5f, -1, 10))
        {
            a[5, 0] = num;
            x = 5; y = 0;
        }
        //7行目
        if (this.gameObject.transform.position == new Vector3(0, -1.5f, 10))
        {
            a[6, 3] = num;
            x = 6; y = 3;
        }
        if (this.gameObject.transform.position == new Vector3(0.5f, -1.5f, 10))
        {
            a[6, 4] = num;
            x = 6; y = 4;
        }
        if (this.gameObject.transform.position == new Vector3(1.0f, -1.5f, 10))
        {
            a[6, 5] = num;
            x = 6; y = 5;
        }
        if (this.gameObject.transform.position == new Vector3(1.5f, -1.5f, 10))
        {
            a[6, 6] = num;
            x = 6; y = 6;
        }
        if (this.gameObject.transform.position == new Vector3(-0.5f, -1.5f, 10))
        {
            a[6, 2] = num;
            x = 6; y = 2;
        }
        if (this.gameObject.transform.position == new Vector3(-1.0f, -1.5f, 10))
        {
            a[6, 1] = num;
            x = 6; y = 1;
        }
        if (this.gameObject.transform.position == new Vector3(-1.5f, -1.5f, 10))
        {
            a[6, 0] = num;
            x = 6; y = 0;
        }
        if (r == 1)
        {
            return x;
        }
        if (r == 2)
        {
            return y;
        }
        else
        {
            return 10;
        }
    }
}
