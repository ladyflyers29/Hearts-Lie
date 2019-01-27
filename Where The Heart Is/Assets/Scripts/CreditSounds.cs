using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditSounds : MonoBehaviour
{

    public GameObject FastSound;
    public GameObject NormalMusic;

    void start()
    {
        FastSound = GameObject.Find("Fast Music");
        NormalMusic = GameObject.Find("Actual Music");
    }
    public void StartFastSound()
    {
        NormalMusic.GetComponent<AudioSource>().mute = true;
        FastSound.GetComponent<AudioSource>().mute = false;
    }

    public void ChangeSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }
}
