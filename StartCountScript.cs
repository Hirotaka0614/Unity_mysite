using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountScript : MonoBehaviour
{
    [SerializeField]
    public Text count;
    // Start is called before the first frame update
    void Start()
    {
        count = GetComponentInChildren<Text>();
        StartCoroutine(CountdownCoroutine());


    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator CountdownCoroutine()
    {

        count.text = 3.ToString();
        yield return new WaitForSeconds(1.0f);

        count.text = 2.ToString();
        yield return new WaitForSeconds(1.0f);

        count.text = 1.ToString();
        yield return new WaitForSeconds(1.0f);

        count.text = "GO!";
        yield return new WaitForSeconds(1.0f);

        count.text = 3.ToString();
        Destroy(this.gameObject);
        GameManagerScript.isPlaying=true;

    }
}
