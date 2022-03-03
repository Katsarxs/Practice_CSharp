using Newtonsoft.Json;
using Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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

app.MapRazorPages();


app.MapPost("/hotel", async x =>
{
    var requestModel = await x.Request.ReadFromJsonAsync<HotelRequestModel>();

    if (requestModel?.Name == null)
    {
        x.Response.StatusCode = 400;

        await x.Response.WriteAsJsonAsync("Name is reuiqred");

        return;
    }

    //return x.Response.WriteAsJsonAsync(new Test { Name = "Nikos" });
});

app.Run();
