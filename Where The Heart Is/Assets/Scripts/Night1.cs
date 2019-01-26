using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Night1 : MonoBehaviour
{
    public GameObject player;
    private PlayerState ps;
    public int victimCount;
    public Text nightText;



    bool nightdone;
    // Start is called before the first frame update
    void Start()
    {
        ps = player.GetComponent<PlayerState>();

        Night();

        




    }
    void Night()
    {
        if (ps.night == 1)
        {
            ps.selectTargets(1);
            victimCount = 1;
            nightdone = false;

            nightText.text = "Night " + ps.night.ToString();

        }



        //activate audio in the victim
       if(ps.hearts == victimCount)
        {
            nightdone = true;

        }
    }
    void nextNight()
    {
        ps.night++;
        ps.activeTargets.Clear();
        ps.hearts = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
