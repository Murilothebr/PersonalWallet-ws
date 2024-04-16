using Microsoft.AspNetCore.SignalR;
using PersonalWalletApi;
using PersonalWalletApi.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<TimeHub>("/timenow");

app.Run();
