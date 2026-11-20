\# SmartHome.API



!\[.NET CI](https://github.com/VadimKG/CSharp-practice/actions/workflows/dotnet-ci.yml/badge.svg)



Production-oriented RESTful Web API for managing smart home devices, built with \*\*ASP.NET Core\*\*, \*\*Clean Architecture\*\*, \*\*PostgreSQL\*\*, and \*\*Docker\*\*.



\## Tech Stack

\- \*\*Backend:\*\* C#, ASP.NET Core 10.0 Web API

\- \*\*Database \& ORM:\*\* PostgreSQL 16, Entity Framework Core (Code-First, Auto-Migrations)

\- \*\*Security:\*\* JWT Bearer Authentication, Role-Based Access Control (`Admin`), `IOptions` pattern

\- \*\*Architecture \& Patterns:\*\* Clean Architecture, Repository Pattern, Dependency Injection (Layer Extension Methods), DTOs \& AutoMapper

\- \*\*Validation \& Reliability:\*\* FluentValidation, Global Exception Handling Middleware, API Versioning (`v1`), CORS, Health Checks, `IMemoryCache`

\- \*\*Observability:\*\* Serilog structured logging

\- \*\*Testing \& DevOps:\*\* xUnit, Moq, Multi-stage Dockerfile, Docker Compose, GitHub Actions CI



\## Architecture

```text

CSharp-practice

├── SmartHome.Core            # Domain entities \& abstractions (zero external dependencies)

├── SmartHome.Application     # Business logic, services, DTOs, AutoMapper, FluentValidation

├── SmartHome.Infrastructure  # EF Core AppDbContext, PostgreSQL repositories, migrations

├── SmartHome.API             # Controllers, Middleware, JWT/CORS/Swagger/Versioning setup

└── SmartHome.API.Tests       # Unit \& behavior tests (xUnit + Moq)

```



\## Quick Start (Docker)

Run the API and PostgreSQL database together with automatic startup migrations:



```bash

git clone https://github.com/VadimKG/CSharp-practice.git

cd CSharp-practice

docker compose up --build

```



Once running:



Swagger UI: http://localhost:5000/swagger

Health Check: http://localhost:5000/health



\## Running Tests

Unit tests are fully isolated from the database via Moq and run in memory:



```bash

dotnet test SmartHome.API/SmartHome.API.slnx

```



\## Key Endpoints

| Method | Endpoint | Description | Auth |

| :---   | :---     | :---        | :--- |

| `POST` | `/api/Auth/login` | Authenticate and receive a JWT token | Public |

| `GET`  | `/api/v1/Device` | Get paginated/filtered list of devices | Bearer Token |

| `POST` | `/api/v1/Device` | Register a new smart device | Bearer Token (Admin) |

| `GET`  | `/health` | Service availability status | Public |



