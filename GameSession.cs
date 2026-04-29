using System.Collections.Generic;
using System.Linq;

namespace StudyQuest
{
    public static class GameSession
    {
        public static string Username { get; set; } = "admin";
        public static int Level { get; set; } = 1;
        public static int TotalXP { get; set; } = 0;

        public static List<(string Username, int Level, int XP)> OtherPlayers = new()
        {
            ("Alice",  52, 5200),
            ("Bob",    25, 2500),
            ("Carol",  19, 1900),
            ("Dave",    14, 1400),
            ("Eve",     6, 600),
            ("Frank",   4, 400),
        };

        public static int GetCurrentRank()
        {
            var fullBoard = new List<(string Username, int Level, int XP)>(OtherPlayers)
            {
                (Username, Level, TotalXP)
            };

            return fullBoard
                .OrderByDescending(p => p.XP)
                .ToList()
                .FindIndex(p => p.Username == Username) + 1;
        }

        public static string GetOrdinal(int position)
        {
            if (position % 100 >= 11 && position % 100 <= 13)
                return $"{position}th";

            return (position % 10) switch
            {
                1 => $"{position}st",
                2 => $"{position}nd",
                3 => $"{position}rd",
                _ => $"{position}th"
            };
        }
    }
}