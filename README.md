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

# Base de datos Normalizada

Para el API de Dogs, se Normaliza por ejemplo especies y perros por si queremos usar otra raza o especie gato sea idenpendite. 
CREATE TABLE Species (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Breed (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    SpeciesId INT NOT NULL,
    FOREIGN KEY (SpeciesId) REFERENCES Species(Id)
);

CREATE TABLE Dog (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    ImageUrl NVARCHAR(255) NOT NULL,
    BreedId INT NOT NULL,
    FOREIGN KEY (BreedId) REFERENCES Breed(Id)
);

INSERT INTO Species (Name) VALUES ('Canis');

INSERT INTO Breed (Name, SpeciesId) VALUES 
('Border collie', 1),
('Beagle', 1),
('Pastor alemán', 1),
('French poodle', 1),
('Samoyedo', 1),
('Corgi', 1);

INSERT INTO Dog (Name, ImageUrl, BreedId) VALUES 
('Rex', 'https://i.imgur.com/wU5dt1l_d.webp?maxwidth=760&fidelity=grand', 1),
('Luna', 'https://i.imgur.com/6sgQSYe_d.webp?maxwidth=760&fidelity=grand', 2),
('Max', 'https://i.pinimg.com/originals/ff/3b/b3/ff3bb31a54462ea817fac885d88f3a85.jpg', 3),
('Bella', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThitY3oY0-BIqJnY-C2d4JPGqELHz-kok0wg&s', 4),
('Nieve', 'https://preview.redd.it/funny-pix-of-my-dog-when-he-waits-outside-of-the-bathroom-v0-xfqwbwbv8r0a1.jpg?width=640&crop=smart&auto=webp&s=bd0f06ef2bd6918aec9ee9d5b5b78e40ff357c25', 5),
('Toby', 'https://cdn1.tedsby.com/tb/hugesquare/storage/5/4/5/545380/stuffed-dog-welsh-corgi-funny-by-natalia-roschina.jpg', 6);



