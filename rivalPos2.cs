using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rivalPos2 : MonoBehaviour
{
    public int rivalLap = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider col)
    {

        if (col.gameObject.name == "Point")
        {
            if (rivalLap == 0) //0 = スタート
            {
                rivalLap = 5; //Point2を目指す
            }

            else if (rivalLap == 10) //1周目
            {
                rivalLap = 15; //Point2を目指す
            }

            else if (rivalLap == 20) //2周目
            {
                rivalLap = 25; //Point2を目指す
            }

            else if (rivalLap == 30) //3周目
            {
                rivalLap = 35; //Point2を目指す
            }

            else if (rivalLap == 40) //4周目
            {
                rivalLap = 45; //Point2を目指す
            }

            else if (rivalLap == 50) //5周目
            {
                rivalLap = 55; //フィニッシュ
            }
        }
        else if (col.gameObject.name == "Point2")
        {
            if (rivalLap == 5) //5 = 半周
            {
                rivalLap = 10; //Pointを目指す
            }

            else if (rivalLap == 15) //1周半
            {
                rivalLap = 20; //Pointを目指す
            }

            else if (rivalLap == 25) //2周半
            {
                rivalLap = 30; //Pointを目指す
            }

            else if (rivalLap == 35) //3周半
            {
                rivalLap = 40; //Pointを目指す
            }

            else if (rivalLap == 45) //4周半
            {
                rivalLap = 50; //Point（ゴール）を目指す
            }
        }
    }
}
