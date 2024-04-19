using System;

namespace GameUnits
{
    //class has an abstract property therefore it
    //must be abstract as well
    public abstract class Unit
    {
        private int movement;
        //property must be virtual because we intend
        //to override it when implementing a class
        //that extends this one
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine(movement);
        }
    }
}
