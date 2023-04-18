namespace Pokemon
{
    internal class Pikachu : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        private Random _random;

        public Pikachu()
        {
            Name = "Pikachu";
            Health = 150;
            _random = new Random();

        }
        public static void thunderbolt(IPokemon pokemon)
        {
            Console.WriteLine("Pikachu used Thunderbolt!");
            pokemon.LooseHealth(25);
        }
        public static void ironTail(IPokemon pokemon)
        {
            Console.WriteLine("Pikachu used Iron Tail!");
            pokemon.LooseHealth(20);
        }
        public static void electroWeb(IPokemon pokemon)
        {
            Console.WriteLine("Pikachu used Electro Web!");
            pokemon.LooseHealth(15);
        }
        public static void quickAttack(IPokemon pokemon)
        {
            Console.WriteLine("Pikachu used Quick Attack!");
            pokemon.LooseHealth(25);
        }
        public void Attack(IPokemon pokemon)
        {
            var move = _random.Next(4);

            switch (move)
            {
                case 0:
                    thunderbolt(pokemon);
                    break;
                case 1:
                    ironTail(pokemon);
                    break;
                case 2:
                    electroWeb(pokemon);
                    break;
                case 3:
                    quickAttack(pokemon);
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
