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
1. Wyb�r trasy z Serwisu REST (co najmniej 3 tras)
2. Pobranie trasy � waypoint�w z serwisu REST razem z opisem miejsca do kt�rych nale�y trafi�
3. Zapis trasy w urz�dzeniu z podstawowymi informacjami potrzebnymi do dzia�ania bez dost�pu do sieci
4. Nawigacja do punkt�w wycieczki � mapa, w�asne wyznaczanie trasy, uruchamianie nawigacji w telefonie
5. Uruchamianie opisu po dotarciu na miejsce (lokalizacja u�ytkownika - urz�dzenia)
*/