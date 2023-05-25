using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using ZealandZooEksamen.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IPersonService, PersonService>();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ITilmeldteService, TilmeldteService>();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<INyhedsbrevService, NyhedsbrevService>();

builder.Services.AddSingleton<IEventService, EventService>();
//builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSession(); // opretter login session
builder.Services.AddSingleton<ILagerService, LagerService>();
builder.Services.AddSingleton<ISalgService, SalgService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession(); // gør brug af session

app.MapRazorPages();

app.Run();


