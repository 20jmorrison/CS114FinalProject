using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   public Vector3 moveDir;
   [SerializeField] float moveSpeed = 6f; // speed of projectile
   public GameObject Target;

    private void Update()
    {
     
        transform.parent.position += moveDir * moveSpeed * Time.deltaTime; //increasing parents position by moveDir(slope) by moveSpeed by time passed between frames
    }

    private void OnTriggerExit2D(Collider2D other) //projectile colider
    {
        if (other.tag == "Enemy") //check gameobhject for enemy tag
        {

           Destroy(other.gameObject); // replace line with a call to function that will dammage an enemy
            Destroy(gameObject); //destroys the projectile
        }

    }









}
