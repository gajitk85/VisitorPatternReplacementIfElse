namespace ReplacementofIfElseByVisitorPattern
{
    public interface IPersonVisitor
    {
        void HandleMan(Men visitee);
        void HandleWoman(Women visitee);
        void HandleBoy(Boy visitee);
        void HandleGirl(Girl visitee);
    }
}