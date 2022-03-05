using Barbearia.Api;

Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(s => s.UseStartup<Startup>())
    .Build()
    .Run();
