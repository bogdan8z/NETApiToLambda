namespace ApiToLambda
{
    public class LambdaEntryPoint : Amazon.Lambda.AspNetCoreServer.APIGatewayProxyFunction
    {
        /// <summary>
        /// The builder has configuration, logging and Amazon API Gateway already configured. The startup class
        /// needs to be configured in this method using the UseStartup<>() method.
        /// </summary>
        /// <param name="builder">The IWebHostBuilder to configure.</param>
        protected override void Init(IWebHostBuilder builder)
        {
            builder
                .UseStartup<Program>();

        }

        /// <summary>
        /// Use this override to customize the services registered with the IHostBuilder. 
        /// 
        /// It is recommended not to call ConfigureWebHostDefaults to configure the IWebHostBuilder inside this method.
        /// Instead customize the IWebHostBuilder in the Init(IWebHostBuilder) overload.
        /// </summary>
        /// <param name="builder">The IHostBuilder to configure.</param>
        protected override void Init(IHostBuilder builder)
        {
            // builder.ConfigureWebHostDefaults(webBuilder =>
            //{
            //    webBuilder.UseStartup<StartupLambda>(); // We'll define StartupLambda next
            //});
        }

    }
}