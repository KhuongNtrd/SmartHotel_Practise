using Plugin.Settings;
using Plugin.Settings.Abstractions;
using SmartHotel.Clients.Core.Extensions;
using SmartHotel.Clients.Core.Models;

namespace SmartHotel.Clients.Core
{
    public static class AppSettings
    {
      
        // Mobile Center
        private const string DefaultMobileCenterAnalyticsAndroid = "YOUR_APPCENTER_ANDROID_ANALYTICS_ID";
        private const string DefaultMobileCenterAnalyticsIos = "YOUR_APPCENTER_IOS_ANALYTICS_ID";
        private const string DefaultMobileCenterAnalyticsWindows = "YOUR_APPCENTER_WINDOWS_ANALYTICS_ID";

        // Maps
        private const string DefaultBingMapsApiKey = "YOUR_BINGMAPS_API_KEY";
        public const string DefaultFallbackMapsLocation = "40.762246 -73.986943";

        // Booking 
        private const bool DefaultHasBooking = false;

        // Fakes
        private const bool DefaultUseFakes = false;

        private static ISettings Settings => CrossSettings.Current;

       
        // Other settings
        public static string BingMapsApiKey
        {
            get => Settings.GetValueOrDefault(nameof(BingMapsApiKey), DefaultBingMapsApiKey);

            set => Settings.AddOrUpdateValue(nameof(BingMapsApiKey), value);
        }

        public static string FallbackMapsLocation
        {
            get => Settings.GetValueOrDefault(nameof(FallbackMapsLocation), DefaultFallbackMapsLocation);

            set => Settings.AddOrUpdateValue(nameof(FallbackMapsLocation), value);
        }

        public static User User
        {
            get => Settings.GetValueOrDefault(nameof(User), default(User));

            set => Settings.AddOrUpdateValue(nameof(User), value);
        }

        public static string MobileCenterAnalyticsAndroid
        {
            get => Settings.GetValueOrDefault(nameof(MobileCenterAnalyticsAndroid), DefaultMobileCenterAnalyticsAndroid);

            set => Settings.AddOrUpdateValue(nameof(MobileCenterAnalyticsAndroid), value);
        }

        public static string MobileCenterAnalyticsIos
        {
            get => Settings.GetValueOrDefault(nameof(MobileCenterAnalyticsIos), DefaultMobileCenterAnalyticsIos);

            set => Settings.AddOrUpdateValue(nameof(MobileCenterAnalyticsIos), value);
        }

        public static string MobileCenterAnalyticsWindows
        {
            get => Settings.GetValueOrDefault(nameof(MobileCenterAnalyticsWindows), DefaultMobileCenterAnalyticsWindows);

            set => Settings.AddOrUpdateValue(nameof(MobileCenterAnalyticsWindows), value);
        }

        public static bool UseFakes => true;

        public static bool HasBooking
        {
            get => Settings.GetValueOrDefault(nameof(HasBooking), DefaultHasBooking);

            set => Settings.AddOrUpdateValue(nameof(HasBooking), value);
        }

        public static void RemoveUserData()
        {
            Settings.Remove(nameof(User));
        }
    }
}