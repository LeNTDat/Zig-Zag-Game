using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public bool newRecord;

    public Text textScore;
    public Text panelScore;
    public Text bestScore;
    public Text HighestScore;



    public int score = 0;

    public static ScoreManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        HighestScore.text = PlayerPrefs.GetInt("HighScore").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.gameOver)
        {
            Invoke("compareScore", 1f);
        }
    }


    public void increaseScore()
    {
        score++;
        textScore.text = score.ToString();
        panelScore.text = score.ToString();
    }

    public void compareScore()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            if(PlayerPrefs.GetInt("HighScore") < score)
            {
                PlayerPrefs.SetInt("HighScore", score);
                newRecord = true;
            }
        }
        else{

            PlayerPrefs.SetInt("HighScore", score);
        }

        bestScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        HighestScore.text = PlayerPrefs.GetInt("HighScore").ToString();

    }
}
