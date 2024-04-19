namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }
        private int health;
        public override int Health 
        {
            get => health;
            set => health = value + XP;
        }
        public override float Cost
        {
            get => AttackPower+XP;
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }
    }
}
