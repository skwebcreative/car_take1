using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    CheckPoint nowCheckPoint;

    int _checkCount;

    public int checkCount =>_checkCount;

    float speed;
    Quaternion turnRot;
    // Start is called before the first frame update
    void Awake()
    {
        nowCheckPoint = nowCheckPoint.StartPoint;
        transform.position = nowCheckPoint.transform.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var p0 = transform.position;
        var v = nowCheckPoint.nextCheckPoint.transform.position - transform.position;
        v.y = 0;
        v = v.normalized * Time.deltaTime * speed;

        //進行方向をすこし揺らす
        v = turnRot * v;
        var p1 = p0 + v;

        transform.position = p1;

        if (nowCheckPoint.CheckIfPassed(p0, p1))
        {
            //チェックポイント通過
            nowCheckPoint = nowCheckPoint.nextCheckPoint;
            _checkCount++;
        }
    }
}
