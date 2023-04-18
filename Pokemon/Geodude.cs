namespace Pokemon
{
    internal class Geodude : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        private Random _random;

        public Geodude()
        {
            Name = "Geodude";
            Health = 200;
            _random = new Random();
        }
        public static void Tackle(IPokemon pokemon)
        {
            Console.WriteLine("Geodude used Tackle!");
            pokemon.LooseHealth(15);
        }
        public static void rockThrow(IPokemon pokemon)
        {
            Console.WriteLine("Geodude used Rock Throw!");
            pokemon.LooseHealth(15);
        }
        public static void rockTomb(IPokemon pokemon)
        {
            Console.WriteLine("Geodude used Rock Tomb!");
            pokemon.LooseHealth(30);
        }
        public static void rockSlide(IPokemon pokemon)
        {
            Console.WriteLine("Geodude used Rock Slide!");
            pokemon.LooseHealth(35);
        }

        public void Attack(IPokemon pokemon)
        {
            var move = _random.Next(4);

            switch (move)
            {
                case 0:
                    Tackle(pokemon);
                    break;
                case 1:
                    rockThrow(pokemon);
                    break;
                case 2:
                    rockTomb(pokemon);
                    break;
                case 3:
                    rockSlide(pokemon);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{pokemon.Name}'s health is now {pokemon.Health}");
        }
        public void LooseHealth(int strength)
        {
            if (Health - strength <= 0) Health = 0;
            else Health -= strength;
        }
    }
}
