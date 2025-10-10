using NUnit.Framework;
using System.Collections;
using UnityEngine;

public class BubbleManager : MonoBehaviour
{


    public List bubblesInPlay;
    public List bubblesInChamber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bubblesInPlay = new List();
        bubblesInChamber = new List();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
