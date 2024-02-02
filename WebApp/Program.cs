var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(cfg => {
    cfg.RootDirectory = "/";
});

builder.Services.AddServerSideBlazor();

var app = builder.Build();

app.UseRouting();

app.UseStaticFiles();

app.UseEndpoints(endpoints => {
    endpoints.MapRazorPages();
    endpoints.MapBlazorHub();
});

app.Run();
