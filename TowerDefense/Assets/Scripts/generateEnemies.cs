using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class generateEnemies : MonoBehaviour
{
    
   // public List<GameObject> pooledObjects;
    public GameObject objectToPool;
   // public int amountToPool;
   // [SerializeField] public float startSpawnPoint;
    public float Timer;
    [SerializeField] public float TimerMax = 10; //time in between enemy spawns 
    [SerializeField] public float enemyAmount = 5;
   

    // Update is called once per frame
    void Update()
    {
      
        Timer -= Time.deltaTime;


        if (Timer <= 0f)
        {
            Timer = TimerMax;
            if (enemyAmount > 0) // if there are enemys to spawn it will subtract an enemy untill enemy amount 0 
            {
                GameObject obj = (GameObject)Instantiate(objectToPool);
                enemyAmount -= 1; 
            }
            

        }
    }

   
    
}
