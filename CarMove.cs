using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    CheckPoint nowCheckPoint;

    //クリアした数
    int _checkeCount;
    public int checkeCount => _checkeCount;

    Quaternion turnRot;

    public float MaxSpeed;
    public float AccelPerSecond;
    public float TurnPerSecond;

    private float Speed;
    private Rigidbody rb;

    private int checkpointCount = 0;
    private int totalCheckpoints = 2;
    private int lapCount = 0;

    /* void Awake()
    {
        nowCheckPoint = CheckPoint.StartPoint;
        transform.position = nowCheckPoint.transform.position;
    } */
    void Start()
    {
        Speed = 0;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        
        if (Input.GetButton("Jump"))
        {
            Debug.Log("Space!!");
            Speed += AccelPerSecond * Time.deltaTime;
            if (Speed > MaxSpeed) Speed = MaxSpeed;
        }
        else
        {
            Speed -= AccelPerSecond * Time.deltaTime / 2;
            if (Speed < 0) Speed = 0;
        }

        rb.velocity = transform.forward * Speed;


        //旋回する角度の計算
        float Handle = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up,TurnPerSecond * Handle * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CheckPoint"))
        {
            checkpointCount++;
            
            if(checkpointCount == totalCheckpoints)
            {
                checkpointCount = 0;
                lapCount++;
                Debug.Log("ラップ数"+lapCount);
            }
        }
    }
}

