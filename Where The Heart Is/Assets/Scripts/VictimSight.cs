using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictimSight : MonoBehaviour
{
    public Text status;

    void OnTriggerStay2D(Collider2D col)
    {
            if (col.gameObject.CompareTag("Player"))
            {
            //increase detection meter
            status.text = "You've been seen";
                Debug.Log("Found Player!");

            StartCoroutine(WaitEndGame());
                
            }
    }

    void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    IEnumerator WaitEndGame()
    {
        Debug.Log("Ending Game");
        yield return new WaitForSeconds(5);
        EndGame();
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
