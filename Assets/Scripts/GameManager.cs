using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool started = false;


    public static GameManager instance;
    private void Awake()
    {
        if(instance == null) 
        { instance = this; }
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadScene(0); 
    }

    public void gameOverCheck ()
    {
        UIMananger.Instance.GameOverasse();
        ScoreManager.instance.compareScore();
    }
}
