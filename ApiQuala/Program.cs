using DB;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<QualaContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("QualaConnection"))
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


    var app = builder.Build();
 

using (var scope = app.Services.CreateScope())
{
    var Context = scope.ServiceProvider.GetRequiredService<QualaContext>();
    Context.Database.Migrate();
}

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

