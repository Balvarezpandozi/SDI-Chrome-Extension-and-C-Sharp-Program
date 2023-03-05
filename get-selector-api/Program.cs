using get_selector_api;

//API set up
var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseHttpsRedirection();

//Utilities Set up
NativeMessageManager messageManager = new NativeMessageManager();
ClosingManager closingManager = new ClosingManager(app);

// This route requests info to the chrome extension and waits for its response
app.MapGet("/api/getName", () =>
{
    string msgdata = "{\"request\":\"getName\"}";
    messageManager.SendMessage(msgdata);
    return messageManager.ReceiveMessage();
})
.WithName("getname");

//This route closes the api
app.MapGet("/api/kill", () =>
{
    app.StopAsync();
    return Results.Accepted;
})
    .WithName("kill");

app.Run("http://localhost:3000");