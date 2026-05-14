using System.Collections.Generic;
using System.Linq;

namespace StudyQuest
{
    public static class GameSession
    {
        public static string Username { get; set; } = "Nash";
        public static int Level { get; set; } = 1;
        public static int TotalXP { get; set; } = 0;
        public static int StreakDays { get; set; } = 0;

        public static List<(string Username, int Level, int XP)> OtherPlayers = new()
        {
            ("Alice",  6, 600),
            ("Bob",    5, 500),
            ("Carol",  4, 400),
            ("Dave",   3, 300),
            ("Eve",     2,  250),
            ("Frank",   1,  150),
        };

        public static int GetCurrentRank()
        {
            var fullBoard = new List<(string Username, int Level, int XP)>(OtherPlayers)
    {
        (Username, Level, sidebar_task.TotalEarnedEXP)
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