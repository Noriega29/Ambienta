using Ambienta.Services.Tests;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Services Layers
builder.Services.AddScoped<QuintoTest>();
builder.Services.AddScoped<SeptimoTest>();
builder.Services.AddScoped<NovenoTest>();
builder.Services.AddScoped<DecimoTest>();
builder.Services.AddScoped<UndecimoTest>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
