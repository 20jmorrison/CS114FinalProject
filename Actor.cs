/* ************************************ README ***************************************
 * 
 * NOTE: This is the parent class. It is made with the keyword "Abstract" because it
 *       is not meant to be used to instantiate its own objects. It is only to be used 
 *       as a parent for Tower and Enemy to inherit attributes and methods.
 *       
 *************************************************************************************/

using System;

namespace TowerDefenseClasses
{
    public abstract class Actor
    {
        public string Name = "Default";
        public int Speed = 0;

        public void setName(string p_Name) 
        {
            Name = p_Name;
        }

        public string getName()
        {
            return Name;
        }

        public void setSpeed(int p_Speed)
        {
            Speed = p_Speed;
        }

        public int getSpeed()
        {
            return Speed;
        }

        public void printAttributes(string p_Type)
        {
            Console.WriteLine("Actor Type: " + p_Type);
            Console.WriteLine("Actor Name: " + Name);
            Console.WriteLine("Actor Speed: " + Speed);
        }

    }
}
