namespace GameLogicLibrary
{
    public class Potion : IItem
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public Potion(string name, int level, int value)
        {
            this.Name = name;
            this.Level = level;
            this.Value = value;
        }

        public void Use(Player player)
        {

        }

        public int Use(Player player, int currentStat, int maxStatValue)
        {
            return this.Heal(currentStat, maxStatValue);
        }

        private int Heal(int currentStat, int maxStatValue)
        {
            currentStat += this.Value;
            return currentStat < maxStatValue ? currentStat : maxStatValue;
        }
    }
}
