using System.Collections.Generic;
using System.Globalization;
using Murtain.Dependency;
using Murtain.Localization.Configuration;
using Murtain.Localization.Settings;

namespace Murtain.Localization.Sources
{
    /// <summary>
    /// Null object pattern for <see cref="ILocalizationSource"/>.
    /// </summary>
    public class NullLocalizationSource : ILocalizationSource
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static NullLocalizationSource Instance { get { return SingletonInstance; } }
        private static readonly NullLocalizationSource SingletonInstance = new NullLocalizationSource();

        public string Name { get { return null; } }

        private readonly IReadOnlyList<LocalizedString> _emptyStringArray = new LocalizedString[0];

        private NullLocalizationSource()
        {
            
        }

        public void Initialize(ILocalizationConfiguration configuration)
        {
            
        }

        public string GetString(string name)
        {
            return name;
        }

        public string GetString(string name, CultureInfo culture)
        {
            return name;
        }

        public string GetStringOrNull(string name, bool tryDefaults = true)
        {
            return null;
        }

        public string GetStringOrNull(string name, CultureInfo culture, bool tryDefaults = true)
        {
            return null;
        }

        public IReadOnlyList<LocalizedString> GetAllStrings(bool includeDefaults = true)
        {
            return _emptyStringArray;
        }

        public IReadOnlyList<LocalizedString> GetAllStrings(CultureInfo culture, bool includeDefaults = true)
        {
            return _emptyStringArray;
        }
    }
}