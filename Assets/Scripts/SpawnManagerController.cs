using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerController : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, -2.44f);
    private float delayTime = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), delayTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
