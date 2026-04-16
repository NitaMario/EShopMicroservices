# EShopMicroservices

**A comprehensive microservices-based e-commerce project demonstrating modern software architecture principles, leveraging cutting-edge .NET technologies.** This project highlights essential design patterns, best practices, showcasing expertise in building scalable and maintainable distributed systems.

---

## Overview

The **EShopMicroservices** project showcases a highly modular and scalable microservices architecture built using the latest advancements in .NET 8 and C# 12. It emphasizes best practices such as **Domain-Driven Design (DDD)**, **CQRS**, and **Clean Architecture** to ensure maintainability and extensibility.

---

## Key Features

### Backend Technologies & Architecture
- **ASP.NET Core 8 Web API** for microservices development.
- Utilization of **Minimal APIs** and the latest features of .NET 8.
- **Vertical Slice Architecture** with feature-based folder organization.
- **CQRS (Command Query Responsibility Segregation)** implemented using:
  - **MediatR** for message handling and processing.
  - **FluentValidation** for pipeline-based validation.
- **Marten Library** for transactional document storage on PostgreSQL.
- **Entity Framework Core**:
  - Code-first approach with automatic migrations to SQL Server.
  - Clean architecture integration for domain entity configurations.

### Design Patterns & Best Practices
- Incorporation of **Proxy**, **Decorator**, and **Cache-aside** design patterns.
- **Distributed caching** using **Redis** for enhanced performance.
- **High-performance inter-service communication** with **gRPC**.
  - Basket Microservice integration with the Discount gRPC service for product pricing.
- **RabbitMQ** for asynchronous messaging:
  - **MassTransit** for simplified abstraction and messaging workflows.
  - Publish/Subscribe pattern using **Topic Exchange** Model.
- **API Gateway** with **YARP Reverse Proxy**:
  - Advanced routing, transformation, and rate limiting.

###  Frontend
- **ASP.NET Core Web Application** with Razor templates and Bootstrap 4 for responsive UI.
- **Refit Library** integration for seamless API consumption.

---

## Run The Project
You will need the following tools:

* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
* [.Net Core 8 or later](https://dotnet.microsoft.com/download/dotnet-core/8)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Installing
Follow these steps to get your development environment set up: (Before Run Start the Docker Desktop)
1. Clone the repository
2. Once Docker for Windows is installed, go to the **Settings > Advanced option**, from the Docker icon in the system tray, to configure the minimum amount of memory and CPU like so:
* **Memory: 4 GB**
* CPU: 2
3. At the root directory of solution, select **docker-compose** and **Set a startup project**. **Run docker-compose without debugging on visual studio**.
  Or you can go to root directory which include **docker-compose.yml** files, run below command:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

4. Wait for docker compose all microservices. That’s it!

5. Launch **Shopping Web UI -> https://localhost:6065** in your browser to view index page. You can use Web project in order to **call microservices over Yarp API Gateway**. When you **checkout the basket** you can follow **queue record on RabbitMQ dashboard**.
