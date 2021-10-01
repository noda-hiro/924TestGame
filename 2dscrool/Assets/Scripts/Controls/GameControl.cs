using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    static public GameControl instance;
    public bool gameOverFlag = false;
    public bool gameClearFlag = false;
    [SerializeField] private float gameTimer = 120f;
    [SerializeField] Text text;
    [SerializeField] private Life life;
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameoverText;
    [SerializeField] GameObject gameclearText;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        gameOver();
        GameClear();
        Debug.Log(life.hpFInished);
    }
    private void Timer()
    {
        gameTimer -= Time.deltaTime;
        text.text = ("Žc‚èŽžŠÔ:0") + gameTimer.ToString("f1");
    }
    private void gameOver()
    {
        var gameover = gameTimer < 0 || life.hpFInished == true;
        if (gameover)
        {
            gameTimer = 0;
            gameOverFlag = true;
            gameoverText.SetActive(true);
        }
    }

    private void GameClear()
    {
        if (gameClearFlag) { 
            gameclearText.SetActive(true);
            Debug.Log("owari");
        }
    }
}
