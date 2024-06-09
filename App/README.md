DOT NET ENTITITY
dotnet tool install --global dotnet-ef

SQL SERVER

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

docker pull mcr.microsoft.com/mssql/server
docker run -v ~/docker --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=1q2w3e4r@#$" -p 1433:1433 -d mcr.microsoft.com/mssql/server

Connection string
Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$

dotnet ef migrations add InitialCreate
dotnet ef database update