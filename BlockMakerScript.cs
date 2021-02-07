using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMakerScript : MonoBehaviour
{
    public GameObject puyo;
    int i, j;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (BlockScript.b>0)
        {
           Instantiate(puyo, new Vector3(-1.5f, 8.0f, 10.0f), Quaternion.identity);
            puyo.GetComponent<ColorScript>().X= Random.Range(0,6);
            puyo.GetComponent<ColorScript>().Y = Random.Range(0, 6);
            BlockScript.b -= 1;
        }
        if (BlockScript.c > 0)
        {
            Instantiate(puyo, new Vector3(-1.0f, 8.0f, 10.0f), Quaternion.identity);
            puyo.GetComponent<ColorScript>().X = Random.Range(0, 6);
            puyo.GetComponent<ColorScript>().Y = Random.Range(0, 6);
            BlockScript.c -= 1;

        }
        if (BlockScript.d > 0)
        {
            Instantiate(puyo, new Vector3(-0.5f, 8.0f, 10.0f), Quaternion.identity);
            puyo.GetComponent<ColorScript>().X = Random.Range(0, 6);
            puyo.GetComponent<ColorScript>().Y = Random.Range(0, 6);
            BlockScript.d -= 1;

        }
        if (BlockScript.e > 0)
        {
            Instantiate(puyo, new Vector3(0.0f, 8.0f, 10.0f), Quaternion.identity);
            puyo.GetComponent<ColorScript>().X = Random.Range(0, 6);
            puyo.GetComponent<ColorScript>().Y = Random.Range(0, 6);
            BlockScript.e -= 1;

        }
        if (BlockScript.f > 0)
        {
            Instantiate(puyo, new Vector3(0.5f, 8.0f, 10.0f), Quaternion.identity);
            puyo.GetComponent<ColorScript>().X = Random.Range(0, 6);
            puyo.GetComponent<ColorScript>().Y = Random.Range(0, 6);
            BlockScript.f -= 1;

        }
        if (BlockScript.g > 0)
        {
            Instantiate(puyo, new Vector3(1.0f, 8.0f, 10.0f), Quaternion.identity);
            puyo.GetComponent<ColorScript>().X = Random.Range(0, 6);
            puyo.GetComponent<ColorScript>().Y = Random.Range(0, 6);
            BlockScript.g -= 1;

        }
        if (BlockScript.h > 0)
        {
            Instantiate(puyo, new Vector3(1.5f, 8.0f, 10.0f), Quaternion.identity);
            puyo.GetComponent<ColorScript>().X = Random.Range(0, 6);
            puyo.GetComponent<ColorScript>().Y = Random.Range(0, 6);
            BlockScript.h -= 1;

        }


    }
}
