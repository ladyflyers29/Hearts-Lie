using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [Header("Variables")]
    [Tooltip("Level of Insanity")]
    public int insanity = 0;
    [Tooltip("Hearts you are currently holding")]
    public int hearts = 0;
    [Tooltip("All living potential targets")]
    public List<GameObject> targets = new List<GameObject>();
    [Header("Debug")]
    [Tooltip("Current Night")]
    public int night = 0;
    [Tooltip("Currently Active Targets")]
    public List<GameObject> activeTargets = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void selectTargets(int amt)
    {
        int indx;

        for (int i = 0; i < amt; i++)
        {
            indx = Random.Range(0, targets.Count - 1);
            activeTargets.Add(targets[indx]);
            targets.RemoveAt(indx);
        }
    }

    void pickUp()
    {
        hearts++;
    }

    void nextNight()
    {
        night++;
        activeTargets.Clear();
        hearts = 0;
    }
}
