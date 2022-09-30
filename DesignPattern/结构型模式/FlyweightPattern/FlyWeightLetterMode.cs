namespace DesignPattern.FlyweightPattern
{
    public abstract class Letter
    {
        public abstract string Print();
    }

    public class LetterA : Letter
    {
        public override string Print() { return "A"; }
    }
    public class LetterB : Letter
    {
        public override string Print() { return "B"; }
    }
    public class LetterC : Letter
    {
        public override string Print() { return "C"; }
    }
    public class LetterD : Letter
    {
        public override string Print() { return "D"; }
    }
    public class LetterE : Letter
    {
        public override string Print() { return "E"; }
    }
    public class LetterF : Letter
    {
        public override string Print() { return "F"; }
    }
}
