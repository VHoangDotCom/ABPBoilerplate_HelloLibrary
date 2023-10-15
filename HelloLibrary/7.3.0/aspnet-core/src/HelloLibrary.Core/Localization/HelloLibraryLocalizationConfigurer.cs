using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HelloLibrary.Localization
{
    public static class HelloLibraryLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HelloLibraryConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HelloLibraryLocalizationConfigurer).GetAssembly(),
                        "HelloLibrary.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
