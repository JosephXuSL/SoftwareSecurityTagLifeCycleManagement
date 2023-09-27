using SSTLifeCycleManagement.DataSeeder;
using SSTLifeCycleManagement.DbContexts;
using SSTLifeCycleManagement.Repositories;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => {
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson(cfg => cfg.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
.AddXmlDataContractSerializerFormatters(); //accept return xml formate

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<FileExtensionContentTypeProvider>();// help get file type
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<DataRepository>();
//Inject Services
builder.Services.AddTransient<MainDataSeeder>();

//#if DEBUG
//builder.Services.AddSingleton<XXXX>();
//#else
//builder.Services.AddSingleton<XXXX>();
//#endif

builder.Services.AddDbContext<MainDbContext>(options =>
{   
    options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]);
});

var app = builder.Build();
//Load Dummy Data For Local
if (args.Length == 1 && args[0].ToLower() == "/seed")
{
    var scopeFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopeFactory.CreateScope())
    {
        var seeder = scope.ServiceProvider.GetService<MainDataSeeder>();
        seeder.Seed();
    }
}
// Run APi
else
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();

    }
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}


