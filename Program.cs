/******************
Program: Tower Defense Classes
Purpose: Create parent and child classes for game actors
Author: Jared Morrison
Date: 3/15/2022
******************/

/* ************************************ README ***************************************
 * 
 * NOTE: The below code is not part of the required classes for the project. It is
 *       simply an example of the instantiation and implementation of the classes.
 * 
 * PARENT CLASS: Actor
 * CHILD CLASSES: Tower, Enemy
 * 
 ************************************************************************************/

using System;

namespace TowerDefenseClasses
{
    class Program
    {
        static void Main(String[] args)
        {
            Tower t1 = new Tower(); // Instantiating new towers
            Tower t2 = new Tower();

            t1.setName("Library");
            t1.setSpeed(5);
            t2.setName("Study Guide");
            t2.setSpeed(10);
            t1.printAttributes("Tower"); // IMPORTANT: When calling printAttributes, you must pass it a string declaring the type of actor it is.
            Console.WriteLine();
            t2.printAttributes("Tower");

            Enemy e1 = new Enemy(); // Instantiating new enemies
            Enemy e2 = new Enemy();
            
            Console.WriteLine();
            e1.setName("5-Page Essay");
            e1.setSpeed(5);
            e2.setName("Homework Assignment");
            e2.setSpeed(10);
            e1.printAttributes("Enemy");
            Console.WriteLine();
            e2.printAttributes("Enemy");
        }
    }
}
