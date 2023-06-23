using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullManager : MonoBehaviour
{
    private List<GameObject> pool;
    public GameObject pooledObject;
    public int amount;


    public void Initialize()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < amount; i++)
        {
            GameObject obj = Instantiate(pooledObject, transform.position, Quaternion.identity, transform);

            obj.SetActive(false);
            pool.Add(obj);

        }
    }

    public void ActiveNextObject(float xPosition, float zPosition)
    {
        foreach (var objPool in pool)
        {
            if (!objPool.activeInHierarchy)
            {
                objPool.transform.position = new Vector3 (xPosition, 0f, zPosition);    
                objPool.SetActive(true);
                break;
            }
        }
    }

    public int GetPoolLength()
    {
        return pool.Count;
    }

    //public void DestroyObject(GameObject obj)
    //{
        //foreach (var objPool in pool)
        //{
            //if (objPool == obj)
            //{
                //objPool.SetActive(false);
            //}
        //}
    //}
}
