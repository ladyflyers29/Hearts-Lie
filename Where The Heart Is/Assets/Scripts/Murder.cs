using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Murder : MonoBehaviour
{
    public GameObject player;
    public Text statusText;
    private bool gotheart = false;
    private Transform light;

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
    IEnumerator WaitforEnd()
        {
        Debug.Log("Endiing Game");
            yield return new WaitForSeconds(5);
            Endgame();
        }
    void Endgame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log("Please work");
        foreach (GameObject target in ps.activeTargets) //Iterate through all active targets
        {

            if (other.gameObject == target) //Checks if the active target is the collision
            {
                Debug.Log(other.gameObject.name + " was killed."); //Temporary Kill System
                //other.gameObject.SetActive(false);
                if (other.gameObject.GetComponent<SetVictimDead>().dead == false)
                {
                    ps.hearts++;
                    other.gameObject.GetComponent<SetVictimDead>().dead = true;
                    other.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                    return;
                }
            }
        }

                
                //other.gameObject.GetComponent<VictimState>.kill()
        if (other.gameObject.CompareTag("Victim"))
        {

            statusText.text = "That was not it";
            //What happens if you kill the wrong target
            other.gameObject.GetComponent<SetVictimDead>().dead = true;
            other.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            StartCoroutine(WaitforEnd());

        }
    }

}
