using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;
using UnityEngine.UI;


public class generateEnemies : MonoBehaviour
{
    
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    [SerializeField] public float startSpawnPoint;
    public Sprite lvl1, lvl2, lvl3, lvl4, lvl5, lvl6, lvl7, lvl8;
    int enemyIncrement;
    private int currentLevel = 1;
    
    void Start()
    {
        enemyIncrement = amountToPool / 8;
        pooledObjects = new List<GameObject>();
        
        for (int i = 0; i < amountToPool; i++) 
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            if (i == 0)
            {
                obj.SetActive(true);
                obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl1;
            }
            else
            {
                obj.SetActive(false);
            }
            switch (currentLevel)
            {
                case 1:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl1;
                    break;
                case 2:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl2;
                    break;
                case 3:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl3;
                    break;
                case 4:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl4;
                    break;
                case 5:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl5;
                    break;
                case 6:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl6;
                    break;
                case 7:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl7;
                    break;
                case 8:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl8;
                    break;
                default:
                    obj.gameObject.GetComponent<SpriteRenderer>().sprite = lvl1;
                    break;
            }
            if (i % enemyIncrement == 0)
            {
                currentLevel++;
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
