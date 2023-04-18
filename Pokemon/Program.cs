namespace Pokemon
{
    internal class Program
    {
        /*
            Create an interface called IPokemon that has a property Health, a method Attack()
            and a method LoseHealth()

            Create a class Magikarp that has a property IsUseless and a method called Splash.

            Create another Class with your favorite pokemon, and methods named the same as the
            attack types of the pokemon you have chosen. In the attack methods, you must enter
            an IPokemon as a parameter and call it its LooseHealth method. 

            Magikarp and your favorite pokemon class must both inherit from IPokemon and both
            must have their own constructor that sets health. 

            Create a few more more different Pokemen and put them all in a list List<IPokemon>
            wildPokemon in program.cs

            Create a method that returns an IPokemon called GetWildPokemon() that selects and
            returns a random pokemon from the wildPokemon list.

            Define a while loop that retrieves a wild pokemon and lets it battle Magikarp
            until Magikarp has 0 health
        */
        static void Main(string[] args)
        {
            // Makikarp should always go last
            var ourPokemon = new Magikarp();
            var favPokemon = new Lucario();
            var wildPokemon1 = new Geodude();
            var wildPokemon2 = new Pikachu();
            List<IPokemon> pokemons = new List<IPokemon>();
            pokemons.Add(favPokemon);
            pokemons.Add(wildPokemon1);
            pokemons.Add(wildPokemon2);
            var opponent1 = ourPokemon;
            var opponent2 = GetWildPokemon(pokemons);
            Console.WriteLine($"{opponent1.Name} is going to be slaughtered by {opponent2.Name}");
            while (opponent1.Health > 0)
            {
                opponent1.Attack(opponent2);
                Console.ReadKey();
                opponent2.Attack(opponent1);
                Console.ReadKey();
            }
            Console.WriteLine("Magikarp is now sushi!");

        }
        static IPokemon GetWildPokemon(List<IPokemon> _pokemons)
        {
            int random = new Random().Next(_pokemons.Count);
            return _pokemons[random];

        }
    }
}