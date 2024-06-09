docker pull mcr.microsoft.com/mssql/server

dotnet dev-certs https --clean
dotnet dev-certs https --trust

String de conexão
Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;

Em Program.cs adicionar ref. ao sql server // Entity
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));


dotnet ef migrations add InitialCreate
dotnet ef database update

dotnet run

se erro no comando dotnet ef

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

