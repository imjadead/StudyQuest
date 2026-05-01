using System;
using System.IO;
using System.Text.Json;

namespace StudyQuest
{
    public class StreakData
    {
        public int StreakDays { get; set; } = 0;
        public string LastLoginDate { get; set; } = "2000-01-01";
    }

    public static class StreakDatabase
    {
        private static readonly string FilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "streak.json"
        );

        public static StreakData Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new StreakData();

                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<StreakData>(json) ?? new StreakData();
            }
            catch
            {
                return new StreakData();
            }
        }

        public static void Save(StreakData data)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(data, options);
                File.WriteAllText(FilePath, json);
            }
            catch { }
        }

        public static StreakData UpdateStreak()
        {
            StreakData streak = Load();

            DateTime today = DateTime.Today;
            DateTime lastLogin = DateTime.Parse(streak.LastLoginDate).Date;
            int daysSince = (today - lastLogin).Days;

            if (daysSince == 1) streak.StreakDays++;   // continued
            else if (daysSince > 1) streak.StreakDays = 1; // reset
            // daysSince == 0 → already logged in today, no change

            streak.LastLoginDate = today.ToString("yyyy-MM-dd");
            Save(streak);

            return streak;
        }
    }
}