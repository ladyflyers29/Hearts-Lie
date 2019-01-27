using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeDisclaim : MonoBehaviour
{
    public Animator animation;

    private int loadLevel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel(4);
        }
    }

    public void FadeToLevel(int levelIndex)
    {
        loadLevel = levelIndex;
        animation.SetTrigger("FadeOutD");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(loadLevel);
    }
}

