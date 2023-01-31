using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    GameObject ball;
    GameObject leftScoreboard;
    GameObject rightScoreboard;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        leftScoreboard = GameObject.FindWithTag("left scoreboard");
        rightScoreboard = GameObject.FindWithTag("right scoreboard");
        ball = GameObject.FindGameObjectWithTag("ball");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void endGame(int winner)
    {
        gameOverScreen.SetActive(true);
    }

    public void countPoint(int player)
    {

        if (player == 1) 
        {
            int actualScore = rightScoreboard.GetComponent<RightScoreboard>().addScore();
            if (actualScore == 10)
            {
                endGame(1);
            }
        }
        else if (player == 2)
        {
            int actualScore = leftScoreboard.GetComponent<LeftScoreboard>().addScore();
            if (actualScore == 10)
            {
                endGame(2);
            }
        }

        ball.GetComponent<Ball>().Reset();
    }
}
