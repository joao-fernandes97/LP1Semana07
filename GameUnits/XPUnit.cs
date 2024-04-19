namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        public int XP { get; private set; }

        public XPUnit(int mov, int health) : base(mov, health)
        {
            XP = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()} XP={XP}";
        }
    }
}