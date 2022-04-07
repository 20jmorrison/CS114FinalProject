using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Tower : MonoBehaviour
{

    //[SerializeField] GameObject Projectile;
    public GameObject projectile;
    private Vector3 projectileSpawnPoint;
    private float shootTimer; //timer clock for the shooting
   [SerializeField] float shootTimerMax = 5; //time between shots

    public List<GameObject> targetList = new List<GameObject>();
   
    
    
    private void Start()
    {
        projectileSpawnPoint = gameObject.transform.position; //set spawnposition of the projectile to the position of the tower
        
    }

      private void Update()
    {
        shootTimer -= Time.deltaTime;
        
        if (targetList.Count > 0) // if the enemy list is not empty check if targetlist contains entries then spawn projectile.
        {

          
            transform.parent.LookAt(targetList[0].transform);

                if (shootTimer <= 0f)
                {
                    shootTimer = shootTimerMax;
                spawnProjectile();
                }      
        }
    }

   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy") //check for tag on enemy
        {
            targetList.Add(other.gameObject); //adding gameobject to list when enter range
        }                              
      
    }

   private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy") //check for tag on enemy
        {
            targetList.Remove(other.gameObject); //removing gameobject from list when it enters the range of tower
        }

    }


    private Vector3 getClosestEnemy()
    {
        
       GameObject Target = targetList[0]; //setting target variable to the first target in the list
       Vector3 position = Target.transform.position; // setting the position of the target 

       return position;
    }


    public void spawnProjectile()
    {

        Vector3 targetPosition = getClosestEnemy(); //setting target position to getClostestEnemy
        Vector3 moveDir = (targetPosition - (Vector3)(gameObject.transform.position)).normalized; //subtracting the position of the target by the position of the tower which is casted as a vector 2 and then were .normalizing the diference between the two

        GameObject proj = Instantiate(projectile, projectileSpawnPoint, Quaternion.identity); //hold reference to projectile instantiate

        proj.GetComponentInChildren<Projectile>().moveDir = moveDir; 
        proj.GetComponentInChildren<Projectile>().Target = targetList[0];
        proj.transform.LookAt(targetList[0].transform);

       // Debug.Log("spawn");

    }
}
