using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour
{
    public List<Racer>Racers{get;private set;}
    // Start is called before the first frame update
    void Start()
    {
        Racers = new List <Racer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
