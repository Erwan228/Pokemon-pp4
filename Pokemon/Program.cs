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
            chooseFight();
        }
        static IPokemon GetWildPokemon()
        {
            List<IPokemon> pokemons = new List<IPokemon>()
            {
                new Lucario(),
                new Geodude(),
                new Pikachu(),
                new Slowpoke()
            };
            int random = new Random().Next(pokemons.Count);

            return pokemons[random];
        }

        static void chooseFight()
        {
            Console.WriteLine("Choose whether you want to make sushi, or witness a fair fight! (s/f)");
            string answer = Console.ReadLine();
            if (answer == "s")
            {
                var magikarp = new Magikarp();
                SushiFight(magikarp, GetWildPokemon());
            }
            else { RealFight(); }
        }

        static void RealFight()
        {
            var opponent1 = GetWildPokemon();
            var opponent2 = GetWildPokemon();
            Console.WriteLine($"{opponent1.Name} is going to fight {opponent2.Name}!");
            Console.ReadKey();
            while (opponent2.Health > 0 && opponent1.Health > 0)
            {
                opponent1.Attack(opponent2);
                Console.ReadKey();
                opponent2.Attack(opponent1);
                Console.ReadKey();
            }
            if (opponent1.Health <= 0)
            {
                Console.WriteLine($"{opponent1.Name} has fainted! {opponent2.Name} is the winner!");
            }
            else
            {
                Console.WriteLine($"{opponent2.Name} has fainted! {opponent1.Name} is the winner!");
            }
        }

        static void SushiFight(IPokemon opponent1, IPokemon opponent2)
        {
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
    }
}