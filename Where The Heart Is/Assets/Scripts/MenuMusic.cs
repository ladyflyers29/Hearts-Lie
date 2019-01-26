using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioClip MusicClip;

    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
