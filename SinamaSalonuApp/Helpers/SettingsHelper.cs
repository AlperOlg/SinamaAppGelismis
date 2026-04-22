using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace SinamaSalonuApp.Helpers
{
    public static class SettingsHelper
    {
        private static readonly string SettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

        public static void SaveRememberMe(int userId)
        {
            var settings = LoadSettings();
            
            if (settings == null) settings = new Dictionary<string, object>();

            var encryptedId = SecurityHelper.Encrypt(userId.ToString());
            
            var rememberMeData = new Dictionary<string, object>
            {
                { "IsActive", true },
                { "UserId", encryptedId }
            };

            settings["RememberMe"] = rememberMeData;

            SaveSettings(settings);
        }

        public static void ClearRememberMe()
        {
            var settings = LoadSettings();
            if (settings != null && settings.ContainsKey("RememberMe"))
            {
                var rememberMeData = new Dictionary<string, object>
                {
                    { "IsActive", false }
                };
                settings["RememberMe"] = rememberMeData;
                SaveSettings(settings);
            }
        }

        public static int? GetRememberMeUserId()
        {
            var settings = LoadSettings();
            if (settings != null && settings.TryGetValue("RememberMe", out var rememberMeObj))
            {
                var rememberMeData = JsonSerializer.Deserialize<Dictionary<string, object>>(rememberMeObj.ToString());
                if (rememberMeData != null && rememberMeData.TryGetValue("IsActive", out var isActive) && isActive.ToString().ToLower() == "true")
                {
                    if (rememberMeData.TryGetValue("UserId", out var encryptedId))
                    {
                        var decryptedId = SecurityHelper.Decrypt(encryptedId.ToString());
                        if (int.TryParse(decryptedId, out int userId))
                        {
                            return userId;
                        }
                    }
                }
            }
            return null;
        }

        private static Dictionary<string, object> LoadSettings()
        {
            if (!File.Exists(SettingsPath)) return new Dictionary<string, object>();

            try
            {
                string json = File.ReadAllText(SettingsPath);
                return JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            }
            catch
            {
                return new Dictionary<string, object>();
            }
        }

        private static void SaveSettings(Dictionary<string, object> settings)
        {
            try
            {
                string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(SettingsPath, json);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ayarlar kaydedilirken hata oluştu: " + ex.Message);
            }
        }
    }
}
