using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer : MonoBehaviour
{
    public string Name{get;set;}
    public float Time{get; set;}
    public int Score{get;set;}

    public Racer(string name, float time, int score)
    {
        Name = name;
        Time = time;
        Score = score;
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
