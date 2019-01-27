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
        ps = player.GetComponent<PlayerState>();

        Night();

        




    }
    void Night()
    {
            statusText.text = "";
            ps.selectTargets(1);
            foreach (GameObject victim in ps.activeTargets)
            {
            victim.GetComponent<AudioSource>().mute = false;
            }
            victimCount = 1;
            nightdone = false;

            nightText.text = "Night " + ps.night.ToString();

        //activate audio in the victim

    }
    public void nextNight()
    {
        ps.night++;
        ps.activeTargets.Clear();
        ps.hearts = 0;

        Night();
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
