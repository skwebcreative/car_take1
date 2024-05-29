using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    List<AI_Car>carList = new List<AI_Car>();
    int phase = 0;
    [SerializeField]
    int count = 10;

    [SerializeField]
    GameObject carPrefab;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(phase == 0)
        {
            CheckPoint.SetForward();

        }
    }
}
