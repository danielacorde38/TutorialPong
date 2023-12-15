using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScoreScript : MonoBehaviour
{

    public TextMeshProUGUI scoreText;

    //goles de jugador 1
    int goalsPlayerOne;

    //goles de jugador 2
    int goalsPlayerTwo;


    public void ResetScore()
    {
        goalsPlayerOne = 0;
        goalsPlayerTwo = 0;
        UpdateScoreText();
    }



    void UpdateScoreText()
    {

        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;

    }


    public void GoalScorePlayerOne()
    {
        goalsPlayerOne++;
        UpdateScoreText ();

    }

    public void GoalScorePlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScoreText () ;
    }

}
