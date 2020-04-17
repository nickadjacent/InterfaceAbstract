using System;

namespace InterfaceAbstractDemo
{
    public abstract class Building
    {
        public int Health { get; set; }
        public abstract double SquareFootage { get; }
        public abstract string Name { get; set; }
        private bool _isShielded = true;
        public Building()
        {
            Health = 300;
        }

        // public abstract int TakeDamage(int amnt);
        // {
        //     if (_isShielded)
        //     {
        //         _isShielded = false;
        //     }
        //     else
        //     {
        //         Health -= amnt;

        //         if (Health <= 100)
        //         {
        //             _isShielded = true;
        //         }
        //         if (Health < 0)
        //         {
        //             Health = 0;
        //         }
        //     }
        //     Console.WriteLine(Health);
        //     return Health;
        // }
    }
}