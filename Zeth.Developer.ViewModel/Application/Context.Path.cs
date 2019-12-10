using Zeth.Core;

namespace Zeth.Developer.ViewModel.Application
{
    public static partial class Context
    {
        public static class Path
        {
            public static string References
            {
                get { return "ReferencesPath".GetConfigValue(); }
            }
        }
    }
}
