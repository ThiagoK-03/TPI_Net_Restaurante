# TPIRestaurante
Modelo: https://drive.google.com/file/d/1-rRmmbvwirnpWUCl2Xdpeob-IEvPBIes/view?usp=drive_link

## Conexion a la bdd
- **SQL Server Express 2022**  
   👉 [Descargar aquí](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

- **SQL Server Management Studio (SSMS)** (opcional, para administrar la base)  
   👉 [Descargar aquí](https://aka.ms/ssmsfullsetup)

- **Entity Framework Core Tools**  
   Instalar globalmente (si no lo tenés):  
   ```bash
   dotnet tool install --global dotnet-ef

- **Crear la bdd**
  ```bash
  dotnet ef database update --project Data --startup-project WebApplication1


## Documentaciones utiles
- EF Core: https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
