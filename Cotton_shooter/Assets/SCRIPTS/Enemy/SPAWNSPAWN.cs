using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNSPAWN : MonoBehaviour
{
    public PullManager poolManager;
    public List<GameObject> spawnPoints;

    private void Start()
    {
        poolManager.Initialize();

        for (int i = 0; i < poolManager.GetPoolLength(); i++)
        {
            poolManager.ActiveNextObject(spawnPoints[i].transform.position.x,spawnPoints[i].transform.position.z);
        }
    }
}
