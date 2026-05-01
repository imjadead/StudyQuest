using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace StudyQuest
{
    // Represents a single saved task
    public class TaskData
    {
        public string Title { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Deadline { get; set; } = DateTime.Today.ToString("yyyy-MM-dd");
        public string Difficulty { get; set; } = "Easy";
        public bool IsCompleted { get; set; } = false;
        public bool IsMissed { get; set; } = false;
        public int ExpReward { get; set; } = 0;
    }

    // Represents the full saved state
    public class TaskSaveData
    {
        public int CurrentEXP { get; set; } = 0;
        public int CurrentLevel { get; set; } = 1;
        public int CompletedCount { get; set; } = 0;
        public int MissedCount { get; set; } = 0;
        public List<TaskData> Tasks { get; set; } = new();
    }

    public static class TaskDatabase
    {
        private static readonly string FilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "tasks.json"
        );

        // ── Load all task data from JSON ─────────────────────────────────────
        public static TaskSaveData Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new TaskSaveData();

                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<TaskSaveData>(json) ?? new TaskSaveData();
            }
            catch
            {
                return new TaskSaveData();
            }
        }

        // ── Save all task data to JSON ────────────────────────────────────────
        public static void Save(TaskSaveData data)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(data, options);
                File.WriteAllText(FilePath, json);
            }
            catch { }
        }
    }
}