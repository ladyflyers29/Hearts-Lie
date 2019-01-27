using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeCompleteLV0 : MonoBehaviour
{

    public Animator animation;

    private int loadLevel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel(3);
        }
    }

    public void FadeToLevel (int levelIndex)
    {
        loadLevel = levelIndex;
        animation.SetTrigger("FadeOut0");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(loadLevel);
    }
}
