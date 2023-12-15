using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] 
    private Vector3 direction;

    [SerializeField]
    float ballSpeedInitial = 1.5f;
    float ballSpeed = 1.5f;

    [SerializeField]
    GameScoreScript score;


    // Start is called before the first frame update
    void Start()
    {
        ballSpeed = ballSpeedInitial;

        if (Random.Range(0.0f, 1.0f) < 0.5) 
        {
            
            direction += Vector3.right;

        }
        else
        {
            
            direction += Vector3.left;
        }

        if (Random.Range(0.0f, 1.0f) < 0.5)
        {
            
           direction += Vector3.up;

        }

        else
        {
            
           direction += Vector3.down;
        }

        }
    // Update is called once per frame
    void Update()
    {
        transform.position += direction * 3 *Time.deltaTime * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
     if(collision.gameObject.CompareTag("Player"))
        {

            direction.x = -direction.x;

            direction.y = Random.Range(-1, 1f);

            ballSpeed += 0.5f; 
           
        }

        if (collision.gameObject.CompareTag("Border"))
        {
            

            direction.y = -direction.y;

                       
        }

        

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GoalZoneOne"))
        {

            ResetBall();
            score.GoalScorePlayerTwo();

        }

        if (collision.gameObject.CompareTag("GoalZoneTwo"))
        {

            ResetBall();
            score.GoalScorePlayerOne();
        }

        void ResetBall ()
        {
            transform.position = Vector3.zero;
            ballSpeed = ballSpeedInitial;
            direction.x = -direction.x;
            direction.y = Random.Range(-1f,1f);
        }

    }

}
