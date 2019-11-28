using System;
using Cosmos.I18N.Adapters.Json.Core.Internals;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Adapters.Json
{
    public static partial class JsonFormattingAdapterExtensions
    {
        public static II18NServiceCollection AddJsonAnonymousResourceFrom(this II18NServiceCollection services, string path = "Anonymous.*", bool referenceToBasePath = true)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (!path.ToLower().EndsWith(".json"))
                path += ".json";

            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (PathHelper.IsSeveralPath(path))
            {
                foreach (var file in PathHelper.GetSeveralPathList(services.ExposeOptions, path))
                {
                    AddJsonAnonymousResourceFromOnce(services, file, false);
                }

                return services;
            }

            return AddJsonAnonymousResourceFromOnce(services, path, referenceToBasePath);
        }

        private static II18NServiceCollection AddJsonAnonymousResourceFromOnce(II18NServiceCollection services, string path, bool referenceToBasePath)
        {
            try
            {
                using (var adapter = new AnonymousJsonFileAdapter(PathHelper.Combine(services.ExposeOptions, path, referenceToBasePath)))
                {
                    if (adapter.Process())
                    {
                        var speaker = adapter.Speak();
                        services.ExposeOptions.AddAnonymousResource(TranslateResourceFactory.Create(speaker));
                    }
                }
            }
            catch (Exception exception)
            {
                InternalLogger.WriteLine($"Thrown exception when add json resource from {path}, message: {0}", exception.Message);
            }

            return services;
        }

        public static II18NServiceCollection AddJsonAnonymousResource(this II18NServiceCollection services, string originContext)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (string.IsNullOrWhiteSpace(originContext)) throw new ArgumentNullException(nameof(originContext));

            using (var adapter = new AnonymousJsonContentAdapter(originContext))
            {
                if (adapter.Process())
                {
                    var speaker = adapter.Speak();
                    services.ExposeOptions.AddAnonymousResource(TranslateResourceFactory.Create(speaker));
                }
            }

            return services;
        }
    }
}