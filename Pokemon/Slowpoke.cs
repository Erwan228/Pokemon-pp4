namespace Pokemon
{
    internal class Slowpoke : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        private Random _random;

        public Slowpoke()
        {
            Name = "Slowpoke";
            Health = 150;
            _random = new Random();

        }
        public static void waterGun(IPokemon pokemon)
        {
            Console.WriteLine("Slowpoke used Water Gun!");
            pokemon.LooseHealth(20);
        }
        public static void zenHeadbutt(IPokemon pokemon)
        {
            Console.WriteLine("Slowpoke used Zen Headbutt!");
            pokemon.LooseHealth(40);
        }
        public static void psychic(IPokemon pokemon)
        {
            Console.WriteLine("Slowpoke used Psychic!");
            pokemon.LooseHealth(45);
        }
        public static void surf(IPokemon pokemon)
        {
            Console.WriteLine("Slowpoke used Surf!");
            pokemon.LooseHealth(45);
        }
        public void Attack(IPokemon pokemon)
        {
            var move = _random.Next(4);

            switch (move)
            {
                case 0:
                    waterGun(pokemon);
                    break;
                case 1:
                    zenHeadbutt(pokemon);
                    break;
                case 2:
                    psychic(pokemon);
                    break;
                case 3:
                    surf(pokemon);
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
