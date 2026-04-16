# EShopMicroservices

**A comprehensive microservices-based e-commerce project demonstrating modern software architecture principles, leveraging cutting-edge .NET technologies.** This project highlights essential design patterns, best practices, showcasing expertise in building scalable and maintainable distributed systems.

---

## ** Overview**

The **EShopMicroservices** project showcases a highly modular and scalable microservices architecture built using the latest advancements in .NET 8 and C# 12. It emphasizes best practices such as **Domain-Driven Design (DDD)**, **CQRS**, and **Clean Architecture** to ensure maintainability and extensibility.

---

## ** Key Features**

### ** Backend Technologies & Architecture**
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

### ** Design Patterns & Best Practices**
- Incorporation of **Proxy**, **Decorator**, and **Cache-aside** design patterns.
- **Distributed caching** using **Redis** for enhanced performance.
- **High-performance inter-service communication** with **gRPC**.
  - Basket Microservice integration with the Discount gRPC service for product pricing.
- **RabbitMQ** for asynchronous messaging:
  - **MassTransit** for simplified abstraction and messaging workflows.
  - Publish/Subscribe pattern using **Topic Exchange** Model.
- **API Gateway** with **YARP Reverse Proxy**:
  - Advanced routing, transformation, and rate limiting.

### ** Frontend**
- **ASP.NET Core Web Application** with Razor templates and Bootstrap 4 for responsive UI.
- **Refit Library** integration for seamless API consumption.

---
