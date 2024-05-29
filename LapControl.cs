using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapControl : MonoBehaviour
{
    //public Text rank;
    int PosNow = 2;
    int LapMy;
    int count;
    bool finish = false;
    int[] RivalPos = new int[3];
    public GUIStyle style;
    // Start is called before the first frame update
    void Start()
    {
        style = new GUIStyle();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj = GameObject.Find("CarWaypointBased");
        GameObject obj1 = GameObject.Find("CarWaypointBased (1)");
        GameObject obj2 = GameObject.Find("CarWaypointBased (2)");
        //GameObject myobj = GameObject.Find("Player");
        GameObject myobj = GameObject.Find("Free Racing Car Blue Variant");

        rivalPos myRival;
        myRival = obj.GetComponent<rivalPos>();
        RivalPos[0] = myRival.rivalLap;

        rivalPos1 myRival1;
        myRival1 = obj1.GetComponent<rivalPos1>();
        RivalPos[1] = myRival1.rivalLap;

        rivalPos2 myRival2;
        myRival2 = obj2.GetComponent<rivalPos2>();
        RivalPos[2] = myRival2.rivalLap;

        myPos my;
        my = myobj.GetComponent<myPos>();
        LapMy = my.mylap;
    }

    void OnGUI()
    {
        style.fontSize = 30;

        if (finish == false)
        {
            if (LapMy == 0 || LapMy ==5)
            {
                GUI.Box(new Rect(0, 20, 100, 50), "Lap: 0/5", style);
              
            }

            else if (LapMy == 5 || LapMy == 10)
            {
                GUI.Box(new Rect(0, 20, 100, 50), "Lap: 1/5", style);
            }

            else if (LapMy == 15 || LapMy == 20)
            {
                GUI.Box(new Rect(0, 20, 100, 50), "Lap: 2/5", style);
               
            }

            else if (LapMy == 25 || LapMy == 30)
            {
                GUI.Box(new Rect(0, 20, 100, 50), "Lap: 3/5", style);
              
            }

            else if (LapMy == 35 || LapMy == 40)
            {
                GUI.Box(new Rect(0, 20, 100, 50), "Lap: 4/5", style);
            }

            else if (LapMy >= 45 || LapMy == 50)
            {
                GUI.Box(new Rect(0, 20, 100, 50), "FINAL LAP", style);
                
            }
        }

        else //LapMy（mylap）の値が50以上（ゴールしている）の場合
        {
            GUI.Box(new Rect(0, 20, 100, 50), "FINISH", style);
        }
        GUI.Box(new Rect(0, 80, 200, 50), "順位: " + PosNow.ToString(), style);
    }

    public void OnTriggerEnter(Collider col)
    {
        //プレイヤーの車がBoxColliderを通過した場合
        if (col.gameObject.name == "Free Racing Car Blue Variant")
        {
            Debug.Log("checkpoint!!!!!");
            int[] RivalPosNow = new int[11];
            RivalPosNow = RivalPos; //RivalPosの値を代入
            countPos(RivalPosNow); //順位を数えるメソッドを実行
        }

    }

    void countPos(int[] RivalPosNow)
    {
        if(LapMy == 0)
        {
            count = 1;
            for(int i = 0; i<RivalPosNow.Length; i++)
            {
                if(0 < RivalPosNow[i]){
                    count +=1;
                }
            }
            PosNow = count;
        }
       //その後も同じ作業
        else if (LapMy == 10)
        {
            count = 1;
            for (int i = 0; i < RivalPosNow.Length; i++)
            {
                if (10 < RivalPosNow[i])
                {
                    count += 1;
                }
            }
            PosNow = count;
        }

        else if (LapMy == 20)
        {
            count = 1;
            for (int i = 0; i < RivalPosNow.Length; i++)
            {
                if (20 < RivalPosNow[i])
                {
                    count += 1;
                }
            }
            PosNow = count;
        }

        else if (LapMy == 30)
        {
            count = 1;
            for (int i = 0; i < RivalPosNow.Length; i++)
            {
                if (30 < RivalPosNow[i])
                {
                    count += 1;
                }
            }
            PosNow = count;
        }

        else if (LapMy == 40)
        {
            count = 1;
            for (int i = 0; i < RivalPosNow.Length; i++)
            {
                if (40 < RivalPosNow[i])
                {
                    count += 1;
                }
            }
            PosNow = count;
        }

        else if (LapMy == 50)
        {
            count = 1;
            for (int i = 0; i < RivalPosNow.Length; i++)
            {
                if (50 < RivalPosNow[i])
                {
                    count += 1;
                }
            }
            PosNow = count;
            finish = true;
        }
        Debug.Log("LapMy: " + LapMy);
        Debug.Log("RivalPosNow: " + string.Join(", ", RivalPosNow));
        Debug.Log("PosNow(順位): " + PosNow);
    }
}
