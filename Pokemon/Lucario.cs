namespace Pokemon
{
    internal class Lucario : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        private Random _random;

        public Lucario()
        {
            Name = "Lucario";
            Health = 250;
            _random = new Random();
        }
        public static void auraSphere(IPokemon pokemon)
        {
            Console.WriteLine("Lucario used Aura Sphere!");
            pokemon.LooseHealth(30);
        }
        public static void boneRush(IPokemon pokemon)
        {
            Console.WriteLine("Lucario used Bone Rush!");
            pokemon.LooseHealth(35);
        }
        public static void forcePalm(IPokemon pokemon)
        {
            Console.WriteLine("Lucario used Force Palm!");
            pokemon.LooseHealth(45);
        }
        public static void extremeSpeed(IPokemon pokemon)
        {
            Console.WriteLine("Lucario used Extreme Speed!");
            pokemon.LooseHealth(50);
        }

        public void Attack(IPokemon pokemon)
        {
            var move = _random.Next(4);

            switch (move)
            {
                case 0:
                    auraSphere(pokemon);
                    break;
                case 1:
                    boneRush(pokemon);
                    break;
                case 2:
                    forcePalm(pokemon);
                    break;
                case 3:
                    extremeSpeed(pokemon);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{pokemon.Name}'s health is now {pokemon.Health}");
        }
        public void LooseHealth(int strength)
        {
            Health -= strength;
        }
    }
}
