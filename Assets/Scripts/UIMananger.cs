using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIMananger : MonoBehaviour
{

    public GameObject TapToStart;

    public GameObject[] OverGame;

    public GameObject HighestScore;
    public GameObject panelScore;
    public GameObject Startpanel;


    public static UIMananger Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void highScore () {
        if (ScoreManager.instance.newRecord)
        {
            HighestScore.SetActive(true);
            HighestScore.GetComponentInChildren<Animator>().Play("BlinkScore");
        }
    }

    public void GameOverasse () {
        Invoke("highScore", 1f);

        panelScore.SetActive(false);
        
        foreach (GameObject game in OverGame)
        {
            game.SetActive(true);
            game.GetComponent<Animator>().Play(game.tag);
        }

    }

    public void ToStart()
    {
        panelScore.SetActive(true);
        Startpanel.SetActive(false);
        TapToStart.GetComponent<Animator>().Play("DropStarter");
    }
}
