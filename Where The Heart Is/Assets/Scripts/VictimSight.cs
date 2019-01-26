using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictimSight : MonoBehaviour
{

    void OnTriggerStay2D(Collider2D col)
    {
            if (col.gameObject.CompareTag("Player"))
            {
                //increase detection meter
                Debug.Log("Found Player!");
            }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
