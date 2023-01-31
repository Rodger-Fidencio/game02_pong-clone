using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{

    TextMeshProUGUI winner;

    // Start is called before the first frame update
    void Start()
    {
        winner = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void declareWinner(int win)
    {
        if (win == 1)
        {
            winner.text = "Player 1 win";
        }
        else if (win == 2)
        {
            winner.text = "Player 2 win";
        }
    }
}
