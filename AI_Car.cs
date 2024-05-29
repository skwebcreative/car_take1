using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Car : MonoBehaviour
{
    CheckPoint nowCheckPoint;
    //クリアしたチェックポイント数
    int _checkCount;
    public int checkCount => _checkCount;

    AICarController m_carController; // 車制御用コントローラ
    [SerializeField]
    public Transform[] targets;
    private int targetNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_carController = GetComponent<AICarController>();
    }

    // Update is called once per frame
    void Update()
    {
        //AI車の位置と目標位置の差ベクトルを求める
        //Vector3 targetDir = Target.transform.position - transform.position;
        //外積
        
        Vector3 targetDir = targets[targetNum].position - transform.position;

        Vector3 axis = Vector3.Cross(transform.forward, targetDir);

        float angle = Vector3.Angle(transform.forward, targetDir);

        /* if (angle > 3) { 
            if (axis.y < 0) { 
                m_carController.Left = true; 
            } 
            else if (axis.y > 0) { 
                m_carController.Right = true; 
            } 

        } */
    }
}
