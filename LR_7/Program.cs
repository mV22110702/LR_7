using LR_7.Services.File;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddFileService();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.MapControllers();

app.Run();
