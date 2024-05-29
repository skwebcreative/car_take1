using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CheckpointManager : MonoBehaviour
{
    public Transform playerTransform;
    public List<Enemy>enemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            UpdateEnemyRanks();
        }
    }
    private void UpdateEnemyRanks()
    {
        Dictionary<Enemy, float>distances = new Dictionary<Enemy, float>();
        
        foreach (Enemy enemy in enemies)
        {
            float distance = Vector3.Distance(playerTransform.position, enemy.transform.position);
            distances.Add(enemy, distance);
        }

        var sortedDistances = distances.OrderBy(x => x.Value);

        int rank = 1;
        foreach (var pair in sortedDistances)
        {
            Debug.Log("Rank " + rank + ": " + pair.Key.enemyName);
            rank++;
        }
    }
}