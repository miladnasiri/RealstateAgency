# Real Estate Agency

A modern real estate management system built with .NET 8, featuring clean architecture and both API and web interfaces.

## Features

- **Clean Architecture** with Domain, Application, Infrastructure, and Presentation layers
- **RESTful API** with Swagger documentation
- **Blazor Server** web interface
- **In-Memory Database** for easy setup and demo
- **Property Management** for apartments, houses, and villas
- **Agent Information** with contact details

## Projects Structure

- `RealEstate.Domain` - Core business entities and enums
- `RealEstate.Application` - Business logic and interfaces
- `RealEstate.Infrastructure` - Data access and external services
- `RealEstate.WebApi` - RESTful API endpoints
- `RealEstate.Web` - Blazor Server web application

## Getting Started

### Prerequisites
- .NET 8 SDK

### Running the API
```bash
cd RealEstate.WebApi
dotnet run
```
API will be available at `https://localhost:5001` with Swagger UI

### Running the Web Application
```bash
cd RealEstate.Web
dotnet run
```
Web app will be available at `https://localhost:5002`

## API Endpoints

- `GET /api/properties` - Get all properties
- `GET /api/properties/{id}` - Get property by ID
- `POST /api/properties` - Create new property
- `PUT /api/properties/{id}` - Update property
- `DELETE /api/properties/{id}` - Delete property

## Technology Stack

- .NET 8
- Entity Framework Core (In-Memory)
- Blazor Server
- Bootstrap 5
- Swagger/OpenAPI
