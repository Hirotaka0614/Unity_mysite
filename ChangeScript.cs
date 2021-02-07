using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScript : MonoBehaviour
{
    GameObject [] puyos;
    public static bool n = false;
    private void Update()
    {
        if (n == true)
        {
            puyos = GameObject.FindGameObjectsWithTag("puyo");
            foreach (GameObject puyo in puyos)
            {
                Destroy(puyo);
            }
            n = false;

        }
    }
    public void Change()
    {
            n = true;
            GameManagerScript.s = 0;
            BlockScript.b += 8;
            BlockScript.c += 8;
            BlockScript.d += 8;
            BlockScript.e += 8;
            BlockScript.f += 8;
            BlockScript.g += 8;
            BlockScript.h += 8;
    }
}
