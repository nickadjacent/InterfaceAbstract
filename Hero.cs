namespace InterfaceAbstractDemo
{
    public class Hero : IDamagable
    {
        public int Health { get; set; }
        public string Name;
        public Hero(string name)
        {
            Name = name;
            Health = 100;
        }


        public int TakeDamage(int amnt)
        {
            if (Health - amnt < 0)
            {
                Health = 0;
            }
            else
            {
                Health -= amnt;
            }

            return Health;
        }
        public void Attack(IDamagable target)
        {
            // 10 is the amount fo damage done by attacking
            target.TakeDamage(10);

            // another way of writing the logic - change void to int

            // int targetsNewHealth = target.TakeDamage(10);
            // return targetsNewHealth;
        }
    }
}