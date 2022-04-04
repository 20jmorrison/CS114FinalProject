using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class generateEnemies : MonoBehaviour
{
    
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    [SerializeField] public float startSpawnPoint;
    
    void Start()
    {
        
        pooledObjects = new List<GameObject>();
        
        for (int i = 0; i < amountToPool; i++) 
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            if (i == 0)
            {
                obj.SetActive(true);
            }
            else
            {
                obj.SetActive(false);
            }
            pooledObjects.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkState(startSpawnPoint);
    }

    public void checkState(float startSpawnPoint)
    {
       for (int i = amountToPool - 1; i > 0 ; i--)
       {
            if (pooledObjects[i - 1].transform.position.x > startSpawnPoint)
            {
                pooledObjects[i].SetActive(true);
            }
       }

    }

}
