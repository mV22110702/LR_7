namespace LR_7.Services.File
{
    public static class ServiceProviderFileExtensions
    {
        public static void AddFileService(this IServiceCollection services)

        {

            services.AddSingleton<FileService>();

        }
    }
}
