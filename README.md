# Pedidos Frontend

Este proyecto es una aplicación de frontend desarrollada con **React** y configurada con **Vite**. Su propósito es interactuar con una API de backend para gestionar **artículos**, **vendedores** y **pedidos**.

## 🚀 Características

- **Gestión de artículos:** Visualización de los artículos disponibles con detalles como descripción, precio y depósito.
- **Gestión de vendedores:** Listado de vendedores disponibles.
- **Creación de pedidos:** Selección de un vendedor, artículos y cantidades para generar pedidos.
- **Estilización minimalista:** Implementada con **Tailwind CSS** para un diseño rápido y limpio.

---

## 📋 Requisitos Previos

Antes de empezar, asegúrate de tener instalado lo siguiente:

- **Node.js** (versión 14 o superior) y **npm** o **yarn**
- **Backend API** ejecutándose en `http://localhost:5000` o ajusta la configuración del proxy si tu backend usa otro puerto.

---

## 🛠️ Instalación

1. **Clona el repositorio:**
   ```bash
   git clone <URL_DEL_REPOSITORIO>
   cd pedidos-frontend
2. **Instala las dependencias:* npm i*

3.**🗂️ Estructura del Proyecto**
 src/
├── components/       # Componentes de React para vistas específicas
│   ├── Articulos.jsx       # Página de artículos
│   ├── Vendedores.jsx      # Página de vendedores
│   ├── CrearPedido.jsx     # Página para crear pedidos
├── services/         # Configuración de Axios para llamadas a la API
│   ├── api.js
├── App.jsx           # Definición de rutas principales
├── main.jsx          # Punto de entrada de React
├── index.css         # Estilos globales con Tailwind CSS

4. **🔗 API Endpoints**:
Los siguientes endpoints deben estar disponibles desde el backend:

Artículos:

GET /api/Articulo: Devuelve una lista de artículos filtrados por depósito.
Vendedores:

GET /api/Vendedor: Devuelve una lista de vendedores disponibles.
Pedidos:

POST /api/Pedido: Crea un nuevo pedido.
GET /api/Pedido: Devuelve todos los pedidos existentes.

5. ** 🧪 Ejemplo de Datos**:
`Crear Pedido`
JSON de ejemplo para enviar al endpoint POST /api/Pedido:
`{
  "vendedorId": 1,
  "detalles": [
    {
      "articuloId": 1,
      "cantidad": 3
    },
    {
      "articuloId": 2,
      "cantidad": 5
    }
  ],
  "fecha": "2024-12-14"
}`

6. **🛠️ Herramientas Utilizadas**
FRONT END
React: Biblioteca para crear interfaces de usuario.
Vite: Herramienta de desarrollo rápida para React.
Tailwind CSS: Framework de CSS para estilos rápidos y personalizables.
Axios: Cliente HTTP para interactuar con la API.
React Router DOM: Manejo de rutas en la aplicación.

BACKEND
Entity Framework Core: ORM para manejar la base de datos.
SQLite: Base de datos liviana y fácil de configurar.
Newtonsoft.Json: Para trabajar con datos JSON (serialización/deserialización).
Swagger: Para documentar y probar la API.
Herramientas de desarrollo para EF Core: Para gestionar migraciones y base de datos
