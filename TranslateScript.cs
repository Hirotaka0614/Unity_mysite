using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateScript : MonoBehaviour
{
    GameObject[] puyos;

    public static int num;  //num=0で落下し、終了時にfallcheckへ、num=1なら休止
    float[] puyox = new float[1000];
    float[] puyoy = new float[1000];
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        num = 0;
        //Debug.Log(num);
        int i = 0;
        //丸め誤差解消（自分の今の位置）
        float nowx = Mathf.RoundToInt(this.gameObject.transform.position.x * 10.0f) / 10.0f;
        float nowy = Mathf.RoundToInt(this.gameObject.transform.position.y * 10.0f) / 10.0f;

        //Debug.Log(nowx);
        //Debug.Log(nowy);


        if (num == 1) return;  //落下完了済なので以下の処理不要

        //コンビ解散後の挙動を記述
        if (nowy == -1.5)
        {
            num = 1;   //落下完了をお知らせ

            return;
        }


        if (num == 0)
        {

            puyos = GameObject.FindGameObjectsWithTag("puyo");

            foreach (GameObject puyo in puyos)
            {
                //丸め誤差解消（フィールト中の全ぷよの位置）
                puyox[i] = Mathf.RoundToInt(puyo.transform.position.x * 10.0f) / 10.0f;
                puyoy[i] = Mathf.RoundToInt(puyo.transform.position.y * 10.0f) / 10.0f;
                i++;
            }
            i = 0;
            foreach (GameObject puyo in this.puyos)
            {
                //丸め誤差解消（フィールト中の全ぷよの位置）【以下２行を追加】
                puyox[i] = Mathf.RoundToInt(puyo.transform.position.x * 10.0f) / 10.0f;
                puyoy[i] = Mathf.RoundToInt(puyo.transform.position.y * 10.0f) / 10.0f;

                if (nowx ==puyox[i] && nowy ==puyoy[i] + 0.5f)
                {
                    num = 1;   //落下完了をお知らせ
                    return;
                }
                i++;
            }

            //落下完了していないので引き続き落下
            transform.Translate(0, -0.5f, 0, Space.World);

        }


    }
}