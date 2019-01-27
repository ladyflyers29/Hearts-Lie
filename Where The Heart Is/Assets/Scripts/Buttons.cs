using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public Animator animator;

    public GameObject Fader;
    LevelToLoad f;
    //void Update ()
    //    {
    //    if (Input.GetMouseButtonDown(0))
    //        {
    //        FadeToLevel(1);
    //        }
    //}

    void Start()
    {
        f = Fader.GetComponent<LevelToLoad>();
    }

    public void FadeToLevel (int levelIndex)
    {
        f.levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
        //OnFadeComplete(levelToLoad);
    }


    public void OnFadeComplete(int levelToLoad)
    {
        if (levelToLoad != 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
