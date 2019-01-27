using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;
    private PlayerState ps;
    public int victimCount;
    public Text nightText;
    public Text statusText;

    public bool nightdone;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("AIYSFCKSVBA");
        ps = player.GetComponent<PlayerState>();
        ps.night++;
        Night();

        




    }
    void Night()
    {
            statusText.text = "";

            
            ps.selectTargets(ps.night);
            //activate audio in the victim
            foreach (GameObject victim in ps.activeTargets)
            {
                victim.GetComponent<AudioSource>().mute = false;
            }
            victimCount = 1;
            nightdone = false;


            Debug.Log("Test");
            nightText.text = "Night " + ps.night.ToString();

        

    }
    public void nextNight()
    {
        ps.night++;
        ps.activeTargets.Clear();
        ps.hearts = 0;

        if (ps.night >= 4)
        {
            //put in end of game function
        }
        else
        {
            Night();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (ps.hearts >= victimCount)
        {
            nightdone = true;
            statusText.text = "Go Home";

        }
    }
}
