namespace GameUnits
{
    public class SettlerUnit : Unit // Heranca!!
    {
        public override float Cost {get;} = 5;
        
        public SettlerUnit() : base(1, 3){}

    }
}