using coresolution.Debugging;

namespace coresolution
{
    public class coresolutionConsts
    {
        public const string LocalizationSourceName = "coresolution";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b0ecb243a06d4d7e881c752d0c0b4a06";
    }
}
