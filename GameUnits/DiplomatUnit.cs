namespace GameUnits
{
    public class DiplomatUnit : XPUnit
    {
        public override float Cost {get;} = 7.1f;

        public DiplomatUnit() : base(6, 1){}

        public void MakeAgreement(Unit u)
        {
            if (u is DiplomatUnit) XP += 3;
            else if (u is SettlerUnit) XP += 2;
            else XP++;
        }
    }
}