using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    bool slash = false;
    private float slashTime = 0.33f;
    private float atSlash;
    public float runSpeed = 20;
    public GameObject Slash;
    private PlayerState ps;
    private Animator animator;
    float rotation;

    float GetRotation(float x, float y)
    {
        float tan;
        float angle = (x / -y);

        if (x == 0)
        {
            if (y >= 0)
            {
                return 0f;
            }
            else
            {
                return 180f;
            }
        }
        if (y == 0)
        {
            if (x >= 0)
            {
                return -90f;
            }
            else
            {
                return 90f;
            }
        }
        if (angle < 0)
        {
            if (x < 0) //bottom left
            {
                //angle = angle * -1;
                tan = (Mathf.Rad2Deg * Mathf.Atan(angle) - 180f);
            }
            else //top right
            {
                tan = (Mathf.Rad2Deg * Mathf.Atan(angle));
            }
        }
        else
        {
            if (x < 0) //top left
            {
                tan = 360f + (Mathf.Rad2Deg * Mathf.Atan(angle));
            }
            else // bottom right
            {
                tan = (Mathf.Rad2Deg * Mathf.Atan(angle) - 180f);
            }
        }
        return tan;
    }
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        ps = GetComponent<PlayerState>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");



        //Check to see if player has a heart or not
        if (ps.hearts > 0)
        {
            Debug.Log(ps.hearts);
            animator.SetBool("HasHeart", true);
        }
        else
        {
            animator.SetBool("HasHeart", false);
        }
        

        if(Input.GetKeyDown(KeyCode.Space) && slash == false)
        {
            Slash.SetActive(true);
            slash = true;
            atSlash = Time.time + slashTime;
        }
        if(slash == true && Time.time > atSlash)
        {
            Slash.SetActive(false);
            slash = false;
        }


       




    }

    void FixedUpdate()
    {
        if (horizontal != 0 || vertical != 0)
        {
            rotation = GetRotation(horizontal, vertical);
            transform.rotation = Quaternion.Euler(0, 0, rotation);
        }
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            body.velocity = new Vector2((horizontal * runSpeed) * moveLimiter, (vertical * runSpeed) * moveLimiter); // move at less speed 
        }
        else
        {
            body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed); // move at normal speed
        }

        //Set animations based on states
        if (animator.GetBool("HasHeart"))
        {
            if (horizontal != 0 || vertical != 0)
            {
                animator.SetBool("Walking_H", true);
                animator.SetBool("Idle_H", false);

                animator.SetBool("Walking", false);
                animator.SetBool("Idle", false);

                Debug.Log("Walking_H");
            }
            else
            {
                animator.SetBool("Walking_H", false);
                animator.SetBool("Idle_H", true);

                animator.SetBool("Walking", false);
                animator.SetBool("Idle", false);

                Debug.Log("Idle");
            }
        }
        else
        {
            if (horizontal != 0 || vertical != 0)
            {
                animator.SetBool("Walking_H", false);
                animator.SetBool("Idle_H", false);
                animator.SetBool("Walking", true);
                animator.SetBool("Idle", false);

                Debug.Log("Walking");
            }
            else
            {
                animator.SetBool("Walking_H", false);
                animator.SetBool("Idle_H", false);
                animator.SetBool("Walking", false);
                animator.SetBool("Idle", true);

                Debug.Log("Idle");
            }
        }

    }
}
