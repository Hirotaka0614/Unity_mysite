using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text lastScoreText;
    public Text maxScoreText;
    int maxScore;
    int lastScore;

    private void Start()
    {   lastScore = PlayerPrefs.GetInt("score");
        lastScoreText.text = lastScore.ToString();

        if (PlayerPrefs.HasKey("maxscore") == true)
        {
            maxScore = PlayerPrefs.GetInt("maxscore");
            if (maxScore < lastScore)
            {
                maxScore = lastScore;
                PlayerPrefs.SetInt("maxscore", maxScore);
            }
        }
        else
        {
            maxScore = lastScore;
            PlayerPrefs.SetInt("maxscore", maxScore);
        }
        maxScoreText.text = maxScore.ToString();
        
    }
    public void RetryButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
