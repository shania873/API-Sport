# API-Sport

Projet personnel pour apprendre le C# et .NET, construit avec ASP.NET Core 9.

## Stack

- **ASP.NET Core 9** — framework web
- **Entity Framework Core** — ORM pour la base de données
- **SQLite** — base de données locale
- **JWT** — authentification par token
- **MediatR** — pattern CQRS (Commands / Queries / Handlers)

## Fonctionnalités

- Inscription et connexion utilisateur (JWT)
- Création et récupération de rendez-vous
- Endpoints protégés par authentification

## Lancer le projet

```bash
dotnet run --project Api_Sport
```

L'API sera disponible sur `https://localhost:5001` avec Swagger sur `/swagger`.

## Structure

```
Controllers/      → Endpoints HTTP
Features/         → Commands, Queries et Handlers (MediatR)
Models/           → Entités base de données
DTOs/             → Objets de transfert de données
Data/             → DbContext Entity Framework
```