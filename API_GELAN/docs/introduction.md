# Introducción

Esta API ha sido construida utilizando **ASP.NET Core 8.0** y sigue la arquitectura RESTful.
El objetivo es proporcionar una interfaz robusta y segura para las aplicaciones cliente (Web y Móvil).

## Características Principales

1.  **Arquitectura en Capas**: Separación de responsabilidades entre Controladores, Lógica de Negocio (Servicios) y Acceso a Datos (Repositorios).
2.  **Documentación Automática**: Uso de Swagger y DocFX para generar documentación actualizada.
3.  **DTOs (Data Transfer Objects)**: Uso de objetos de transferencia para desacoplar la capa de presentación de la base de datos.

## Requisitos Previos

Para ejecutar y consumir esta API, se requiere:
- .NET 8.0 SDK
- Base de datos SQL Server (o la configurada en el proyecto)
- Acceso a la red local para pruebas desde dispositivos móviles.
