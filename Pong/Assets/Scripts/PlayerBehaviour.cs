using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    KeyCode buttonUp, buttonDown;

    [SerializeField]
    float speedPlayer=20f;


    void Start()
    {
        


    }

 
    void Update()
    {
        if(Input.GetKey(buttonDown)) 
        {
            transform.position += Vector3.down * Time.deltaTime * speedPlayer;

            
        
        }

        else if (Input.GetKey(buttonUp))
        {
            transform.position += Vector3.up * Time.deltaTime * speedPlayer;

            

        }



    }
}
