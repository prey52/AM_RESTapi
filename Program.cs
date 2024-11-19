var builder = WebApplication.CreateBuilder(args);
//https
//builder.WebHost.UseUrls("http://0.0.0.0:7185");

//http
builder.WebHost.UseUrls("http://0.0.0.0:5098");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
1. Wybór trasy z Serwisu REST (co najmniej 3 tras)
2. Pobranie trasy – waypointów z serwisu REST razem z opisem miejsca do których nale¿y trafiæ
3. Zapis trasy w urz¹dzeniu z podstawowymi informacjami potrzebnymi do dzia³ania bez dostêpu do sieci
4. Nawigacja do punktów wycieczki – mapa, w³asne wyznaczanie trasy, uruchamianie nawigacji w telefonie
5. Uruchamianie opisu po dotarciu na miejsce (lokalizacja u¿ytkownika - urz¹dzenia)
*/