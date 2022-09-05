namespace IntroOOP
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Hello! I'm {Name} and I'm a {Color} parrot.");
        }
    }
}

