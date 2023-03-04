using get_selector_api;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseHttpsRedirection();

NativeMessageManager messageManager = new NativeMessageManager();
ClosingManager closingManager = new ClosingManager(app);

app.MapGet("/api/getName", () =>
{
    string msgdata = "{\"request\":\"getName\"}";
    messageManager.SendMessage(msgdata);
    return messageManager.ReceiveMessage();
})
.WithName("getname");

app.MapGet("/api/kill", () =>
{
    app.StopAsync();
    return Results.Accepted;
})
    .WithName("kill");

app.Run("http://localhost:3000");