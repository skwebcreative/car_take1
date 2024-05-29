using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPos : MonoBehaviour
{
    CheckPoint nowCheckPoint;
    public int mylap = 0;
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
            if (mylap == 0) //0 = スタート
            {
                mylap = 5; //Point2を目指す
                Debug.Log("Point1当たった0/5：" + mylap);
            }

            else if (mylap == 10) //1周目
            {
                mylap = 15; //Point2を目指す
                 Debug.Log("Point1当たった1/5：" + mylap);
            }

            else if (mylap == 20) //2周目
            {
                mylap = 25; //Point2を目指す
            }

            else if (mylap == 30) //3周目
            {
                mylap = 35; //Point2を目指す
            }

            else if (mylap == 40) //4周目
            {
                mylap = 45; //Point2を目指す
            }

            else if (mylap == 50) //5周目
            {
                mylap = 55; //フィニッシュ
            }
        }

        else if (col.gameObject.name == "Point2")
        {
            if (mylap == 5) //5 = 半周
            {
                mylap = 10; //Pointを目指す
                Debug.Log("Point2に当たった");
            }

            else if (mylap == 15) //1周半
            {
                mylap = 20; //Pointを目指す
            }

            else if (mylap == 25) //2周半
            {
                mylap = 30; //Pointを目指す
            }

            else if (mylap == 35) //3周半
            {
                mylap = 40; //Pointを目指す
            }

            else if (mylap == 45) //4周半
            {
                mylap = 50; //Point（ゴール）を目指す
            }
        }
    }
}
