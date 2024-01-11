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

    [SerializeField]
    float  AnimationTime;
    [SerializeField]
    LeanTweenType AnimationCurve;

    [SerializeField]
    float textPosition = 1263.9f;

    [SerializeField]
    GameObject textLabelGoal;

    float endAnimationPosition;
   


    public void ResetScore()
    {
        goalsPlayerOne = 0;
        goalsPlayerTwo = 0;
        UpdateScoreText();
    }



    void UpdateScoreText()
    {

        LeanTween.scale(scoreText.gameObject, Vector3.zero, 0.0f);
        LeanTween.scale(scoreText.gameObject, Vector3.one, AnimationTime).setEase(AnimationCurve);
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;


    }


    public void GoalScorePlayerOne()
    {
        goalsPlayerOne++;
        UpdateScoreText ();
        AnimatedGoalText(1,AnimationTime);
        
    }

    public void GoalScorePlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScoreText () ;

        AnimatedGoalText(2, AnimationTime);
    }

    public void AnimatedGoalText(int player, float initialposition)
    {


        gameObject.SetActive(true);
        float textInitialPosition = 0f;
        

        if(player == 1) 
        
        {
            textInitialPosition = textPosition;
        }
        else
        {
            textInitialPosition = -textPosition;
        }

        endAnimationPosition -= textInitialPosition;

        LeanTween.moveLocalX(textLabelGoal, textInitialPosition, 0.0f);

        LeanTween.moveLocalX(textLabelGoal, 0.0f, 0.5f).setOnComplete(EndAnimation);

      
    }


    void EndAnimation()
    {


        LeanTween.scale(textLabelGoal, Vector3.one, 0.3f).setOnComplete(() =>
        {
            LeanTween.scale(textLabelGoal, Vector3.one * 1.5f, 0.75f).setEaseInBounce().setOnComplete(() =>
            {

                LeanTween.moveLocalX(textLabelGoal, endAnimationPosition, 0.5f).setEaseInCirc();
                LeanTween.scale(textLabelGoal, Vector3.one, 0f);


            });

        });   
        

    }


    }
