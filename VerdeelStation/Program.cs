var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/redirect",
    async (context) =>
    {
        context.Response.StatusCode = 307;
        context.Response.Headers["Location"] = "https://student.uva.nl";
    });

app.MapGet("/proxy",
    async (context) =>
    {
        context.Response.StatusCode = 418;
        context.Response.Headers["Location"] = "https://student.uva.nl";
    });

app.Run();
