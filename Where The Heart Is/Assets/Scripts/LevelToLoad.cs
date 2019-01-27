using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToLoad : MonoBehaviour
{

    public int levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void LoadLevel()
    {
        if (levelToLoad != 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
