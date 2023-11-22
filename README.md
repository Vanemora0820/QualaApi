# QualaApi

Este proyecto consiste en un CRUD desarrollado en ASP.NET Core para la parte del backend, con un frontend en Angular.

## Funcionalidades

- Operaciones CRUD para dos entidades.
- Validación de sucursales.

## Tecnologías Utilizadas

- ASP.NET Core (Backend)
- Angular (Frontend)
- SQL Server (BD TestDB)

## Configuración del Proyecto

### Requisitos Previos

- .NET Core SDK
- Node.js y npm

### Configuración del Backend

1. Clona el repositorio:

    ```bash
    git clone https://github.com/Vanemora0820/QualaApi.git
    cd QualaApi
  

2. Navega al directorio del proyecto backend:

    ```bash
    cd ApiQuala
    ```

3. Restaura las dependencias y ejecuta la aplicación:

    ```bash
    dotnet restore
    dotnet run
    ```

### Configuración del Frontend

1. Navega al directorio del proyecto frontend:

    ```bash
    cd AngularApp
    ```

2. Instala las dependencias:

    ```bash
    npm install
    ```

3. Inicia la aplicación Angular:

    ```bash
    ng serve
    ```

4. Abre tu navegador y visita http://localhost:4200/.

## Contribuir

Si deseas contribuir a este proyecto, sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una nueva rama: `git checkout -b feature/nueva-funcionalidad`
3. Realiza tus cambios y haz commit: `git commit -am 'Agrega nueva funcionalidad'`
4. Haz push a la rama: `git push origin feature/nueva-funcionalidad`
5. Envía un pull request.
