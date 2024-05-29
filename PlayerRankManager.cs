using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRankManager : MonoBehaviour
{
    private Transform playerTransform;
    private List<Transform> enemyTransforms;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = transform; //プレイヤーのTransformを取得
        enemyTransforms = new List<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
