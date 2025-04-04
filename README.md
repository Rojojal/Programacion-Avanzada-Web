# Proyecto Final del Curso Programación Avanzada Web

## Integrantes del grupo:
- **Josué García Rojas**  
- **Karen Tatiana Obando Jimenez**  
- **Jonathan Gerardo Esquivel Guillen**  
- **Nicole Torres Rodriguez**  



## 📌 Arquitectura del Proyecto  
La arquitectura del proyecto se basa en la creacion de un PAP.API, PAP.Mvc y diferentes class libraries como, Architecture, Business, Data, Models, Repositories y Servicies.

- PAP.API
- (Explicar q tiene)
- PAP.Mvc
- (Explicar q tiene)
- AP.Architecture
- (Explicar q tiene)
- PAP.Business
- (Explicar q tiene)
- PAP.Data
- (Explicar q tiene)
- PAP.Models
- (Explicar q tiene)
- PAP.Repositories
- (Explicar q tiene)
- PAP.Servicies
- (Explicar q tiene)

- Comandos utilizados: 
dotnet aspnet-codegenerator identity -dc ApplicationDbContext (creacion de vistas pq no son visibles)
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet ef dbcontext scaffold "Server=(LocalDb)\MSSQLLocalDB;Database=aspnet-PAP.Mvc-75877624-2b5d-4de4-af1d-754cadeb9234;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models

## 📦 Librerías/Paquetes NuGet Utilizados  
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.VisualStudio.Web.CodeGeneration.Design
- NewsAPI
- Microsoft.AspNetCore.Identity.UI


## 🔥 Principios SOLID y Patrones de Diseño Utilizados  

