using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField]
    int index;

    public Vector3 forward;
    public CheckPoint nextCheckPoint;

    static List<CheckPoint> list = new List<CheckPoint>();

    public CheckPoint StartPoint => list[0];
    // Start is called before the first frame update
    void Start()
    {
        
    }
     //自分自身をlistにつなげていきます
    void Awake()
    {
        list.Add(this);
    }
    //走行処理
    static public void SetForward()
    {
        CheckPoint prev = null;
        list.Sort((a, b) => a.index - b.index);

        foreach(var cp in list)
        {
            if(prev != null)
            {
                prev.nextCheckPoint = cp;
                prev.forward = (cp.transform.position - prev.transform.position).normalized;
                
            }
            prev = cp;
        }
        //最後の一個をスタート地点に向かせる
        list[list.Count - 1].forward = (list[0].transform.position - list[list.Count - 1].transform.position).normalized;

        //スタート地点につなぐ
        list[list.Count - 1].nextCheckPoint = list[0];
    }

    public bool CheckIfPassed(Vector3 p0, Vector3 p1)
    {
        return Vector3.Dot(nextCheckPoint.forward, p0 - nextCheckPoint.transform.position) * Vector3.Dot(nextCheckPoint.forward, p1 - nextCheckPoint.transform.position) < 0 ? true : false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
