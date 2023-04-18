namespace Pokemon
{
    internal interface IPokemon
    {
        int Health { get; set; }
        string Name { get; set; }

        void Attack(IPokemon pokemon);
        void LooseHealth(int strength);
    }
}
