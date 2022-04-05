/***************************************
 * Program: destroyEnemy.cs
 * Author: Matthew Majchrzak
 * Purpose: To destroy enemy game objects
 * when they reach the end of the path
 * and subtract from the player's health
 ***************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks if an anemy has entered the collision zone, destroys them, and takes away from the player health
        Destroy(this.gameObject);
    }
}
