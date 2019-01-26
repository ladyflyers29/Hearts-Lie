using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed = 20;
    public Transform prefab;
    private Animator animator;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");




        if(Input.GetKey(KeyCode.T))
        {
            if (animator.GetBool("HasHeart") == false)
            {
                animator.SetBool("HasHeart", true);
            }
            else
            {
                animator.SetBool("HasHeart", false);
            }
        }

        if(Input.GetKey(KeyCode.Space))
        {
            Vector2 playerPos = new Vector2(transform.position.x, transform.position.y - .2f);
            Instantiate(prefab, playerPos, Quaternion.identity);
        }

        //Check to see if player has a heart or not




    }

    void FixedUpdate()
    {
        if(horizontal == -1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if(horizontal == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        if(vertical == -1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (vertical == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        



        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
            body.velocity = new Vector2((horizontal * runSpeed) * moveLimiter, (vertical * runSpeed) * moveLimiter); // move at less speed 
        else // if not moving diagonally
            body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed); // move at normal speed

        //Set animations based on states
        if (animator.GetBool("HasHeart"))
        {
            if (horizontal != 0 || vertical != 0)
            {
                animator.SetBool("Walking_H", true);
                animator.SetBool("Idle_H", false);

                Debug.Log("Walking_H");
            }
            else
            {
                animator.SetBool("Walking_H", false);
                animator.SetBool("Idle_H", true);

                Debug.Log("Idle");
            }
        }
        else
        {
            if (horizontal != 0 || vertical != 0)
            {
                animator.SetBool("Walking", true);
                animator.SetBool("Idle", false);

                Debug.Log("Walking");
            }
            else
            {
                animator.SetBool("Walking", false);
                animator.SetBool("Idle", true);

                Debug.Log("Idle");
            }
        }

    }
}
