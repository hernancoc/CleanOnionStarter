# CleanOnionStarter

Mi primer proyecto utilizando Arquitectura Limpia y Onion Architecture. Incluye separación por capas, principios SOLID y buenas prácticas para aprendizaje y futuras implementaciones.

El proyecto implementa el patrón **Generic Repository**, uso de **DTOs** para la transferencia de datos y **AutoMapper** para el mapeo entre entidades y modelos. Esta estructura permite un código más mantenible, escalable y fácil de extender.

---

## Estructura del Proyecto

- **Loggin.Api**: Capa de presentación, contiene controladores y configuración de la API.
- **Loggin.Application**: Capa de aplicación, incluye servicios, interfaces, DTOs y mapeos.
- **Loggin.Domain**: Capa de dominio, con las entidades y reglas de negocio.
- **Loggin.Infrastructure**: Capa de infraestructura, acceso a datos, repositorios y contexto de base de datos.

---

## Tecnologías y Herramientas

- .NET (versión que uses)
- C#
- Entity Framework Core
- AutoMapper
- Generic Repository Pattern
- Arquitectura Limpia + Onion Architecture
- SQL Server (o la base de datos que utilices)

---

