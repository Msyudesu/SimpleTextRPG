namespace GameLogicLibrary
{
    public class Stats
    {
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Haste { get; set; }
        public int Piety { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }

        public Stats(int str, int con, int dex, int haste, int piety, int hp, int mana)
        {
            Strength        = str;
            Constitution    = con;
            Dexterity       = dex;
            Haste           = haste;
            Piety           = piety;
            Health          = hp;
            MaxHealth       = hp;
            Mana            = mana;
            MaxMana         = mana;
        }
    }
}
