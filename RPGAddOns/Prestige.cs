﻿namespace RPGAddOns
{
    public class PrestigeData
    {
        public int Level { get; set; }
        public int Points { get; set; }
        public List<string> Buffs { get; set; } = new List<string>();

        public PrestigeData(int level, int points, List<string> buffs)
        {
            Level = level;
            Points = points;
            Buffs = buffs;
        }
    }
    internal class Prestige
    {
        // WIP
    }
}
