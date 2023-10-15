using HelloLibrary.Debugging;

namespace HelloLibrary
{
    public class HelloLibraryConsts
    {
        public const string LocalizationSourceName = "HelloLibrary";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "0db0038109fc4366a657ef1e52432e3f";
    }
}
