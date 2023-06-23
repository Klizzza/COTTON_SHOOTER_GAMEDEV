using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public PullManager poolManager;
    public Vector3 minRandomPosition;
    public Vector3 maxRandomPosition;

    private void Start()
    {
        poolManager.Initialize();

        for (int i = 0; i < poolManager.GetPoolLength(); i++)
        {
            float xPosition = Random.Range(minRandomPosition.x, maxRandomPosition.x);
            float zPosition = Random.Range(minRandomPosition.z, maxRandomPosition.z);
            
            poolManager.ActiveNextObject(xPosition, zPosition);
        }
       
    }
}
