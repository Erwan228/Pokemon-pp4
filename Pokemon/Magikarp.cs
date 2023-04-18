namespace Pokemon
{
    internal class Magikarp : IPokemon
    {
        public string Name { get; set; }
        public bool IsUseLess { get; private set; }
        public int Health { get; set; }

        public Magikarp()
        {
            Name = "Magikarp";
            IsUseLess = true;
            Health = 100;
        }
        public static void splash()
        {
            Console.WriteLine("Magikarp used splash!");
            Console.WriteLine("Nothing happened.");
        }

        public void Attack(IPokemon pokemon)
        {
            splash();
        }

        public void LooseHealth(int strength)
        {
            if (Health - strength <= 0) Health = 0;
            else Health -= strength;
        }
    }
}
