using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    public int playerPosition = 1;
    public float moveDistance = 3.25f;
    public float jumpVelocity = 5;
        public float fallMultiplier = 6.5f;


    private void FixedUpdate(){
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        //Vector3 horitontalMove = transform.right * horitontalInput * speed * Time.fixedDeltaTime;
        
        rb.MovePosition(rb.position + forwardMove);
    }

    void Update()
    {
        //Right Move
        if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if(playerPosition < 2)
                {
                    transform.Translate(moveDistance,0,0);
                    playerPosition++;
                }
            }
        //Left Move
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if(playerPosition > 0)
                {
                    transform.Translate(-moveDistance,0,0);
                    playerPosition--;
                }
            }
        //Jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpVelocity;
        }
        
        
    }
}
