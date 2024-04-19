namespace GameUnits
{
    public class MilitaryUnit : XPUnit // Heranca!!
    {
        public int AttackPower { get; }
        private int health;
        public override int Health 
        {
            get => health + XP;
            set => health = value;
        }
        public override float Cost
        {
            get => AttackPower+XP;
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower}";
        }
    }
}
