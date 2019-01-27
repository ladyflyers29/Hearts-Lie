using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVictimDead : MonoBehaviour
{
    private Animator animator;
    private AudioSource death;
    public bool dead = false;
    //Rigidbody2D rb;


    private VictimAI waypoint;
    // Start is called before the first frame update
    void Start()
    {
 
//        thisobject = GetComponent<GameObject>();
        animator = GetComponent<Animator>();
        waypoint = GetComponent<VictimAI>();
        AudioSource[] sounds = GetComponents<AudioSource>();

        Debug.Log("2");
        death = sounds[1];
        Debug.Log("3");

       // rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hey i touched you");
        if (collision.gameObject.tag == "knife")
        {
            Debug.Log("hey i got you");
            animator.SetBool("isDead", true);
            //rb.constraints = RigidbodyConstraints2D.FreezeAll;
            waypoint.enabled = false;
            death.Play();


            //dead = true;


        }
    }
}
