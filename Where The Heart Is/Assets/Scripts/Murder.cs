using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Murder : MonoBehaviour
{
    public GameObject player;

    PlayerState ps;

    private void Awake()
    { 
        ps = player.GetComponent<PlayerState>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log("Please work");
        foreach (GameObject target in ps.activeTargets) //Iterate through all active targets
        {
            
            if (other.gameObject == target) //Checks if the active target is the collision
            {
                Debug.Log(other.gameObject.name + " was killed."); //Temporary Kill System
                other.gameObject.SetActive(false);
                ps.hearts++;
                //other.gameObject.GetComponent<VictimState>.kill()
            }
        }
    }

}
