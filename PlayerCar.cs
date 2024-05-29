using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
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

    // Update is called once per frame
/*     void Update()
    {
        
    } */
}
