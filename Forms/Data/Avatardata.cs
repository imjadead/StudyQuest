using System;
using System.IO;
using System.Text.Json;

namespace StudyQuest
{
    public class AvatarData
    {
        public string EquippedAvatar { get; set; } = "Egg";
        public bool GirlUnlocked { get; set; } = false;
        public bool BoyUnlocked { get; set; } = false;
        public bool BananaUnlocked { get; set; } = false;
    }

    public static class AvatarDatabase
    {
        private static readonly string FilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "avatar.json"
        );

        public static AvatarData Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new AvatarData();

                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<AvatarData>(json) ?? new AvatarData();
            }
            catch
            {
                return new AvatarData();
            }
        }

        public static void Save(AvatarData data)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(data, options);
                File.WriteAllText(FilePath, json);
            }
            catch { }
        }

        public static void Reset()
        {
            try
            {
                if (File.Exists(FilePath))
                    File.Delete(FilePath);
            }
            catch { }
        }
    }
}