# DGIIApp - Prueba Técnica Programador

# Descripción General

El sistema permite a los directivos consultar:
- El listado de todos los contribuyentes registrados (personas físicas o jurídicas).
- Los comprobantes fiscales asociados a cada contribuyente.
- El total del ITBIS acumulado por contribuyente.
- Clasificación automática de contribuyentes como `ACTIIVO` o `INACTIVO` según si poseen comprobantes.



# Tecnologías utilizadas

# Backend (.NET Core)
- ASP.NET Core 7
- Entity Framework Core (InMemory para pruebas)
- Arquitectura por capas (Controllers, Services, Data, Models)
- Middleware para manejo global de excepciones
- Logging estructurado

# Frontend (Angular)
- Angular CLI 16+
- Bootstrap 5
- Componentes con filtros, botones y diseño moderno

---

# Requisitos cumplidos

✔ Utiliza .NET Core y Angular  
✔ Implementación de capas separadas (responsabilidades bien definidas)  
✔ Middleware global para manejo de errores y logs  
✔ Aplicación de principios SOLID
✔ Inyección de dependencias
✔ Tests unitarios (xUnit + EF InMemory)  
✔ Persistencia de datos (opcional, con InMemory en pruebas)

---

# Tests Unitarios

Se implementaron pruebas para los servicios principales:

- `ContribuyenteService`
  - `GetAllAsync` 
- `ComprobanteService`
  - `GetAllAsync` 
  - `GetTotalItbisByRncAsync` 

Todos los tests están **implementados y pasan correctamente**.



Instrucciones de uso

1. Clonar el repositorio
```bash
git clone https://github.com/tuusuario/DGIIApp.git
cd DGIIApp
