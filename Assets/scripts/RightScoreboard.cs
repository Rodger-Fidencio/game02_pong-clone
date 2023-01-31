using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RightScoreboard : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public int addScore()
    {
        score++;
        return score;
    }
}
