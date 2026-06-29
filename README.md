# Trabajo en clase - Gestión de alumnos

Este proyecto fue desarrollado en C# con .NET 8 como una aplicación de consola para cargar y consultar datos de alumnos desde un archivo CSV.

## ¿Qué hace el proyecto?

La aplicación permite:
- Leer la información de alumnos desde el archivo `alumnos.csv`.
- Mostrar los datos cargados en consola.
- Buscar o listar registros de manera sencilla desde la ejecución del programa.

## Tecnologías utilizadas

- C#
- .NET 8
- Visual Studio Code o Visual Studio

## Requisitos previos

Para ejecutar este proyecto en otra computadora, se recomienda tener instalado:
- .NET 8 SDK
- Un editor como Visual Studio Code o Visual Studio

## Cómo inicializar el proyecto en otra PC

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/leoncomolli/TrabajoEnClaseComolli.git
   ```

2. Entrar en la carpeta del proyecto:
   ```bash
   cd TrabajoEnClaseComolli
   ```

3. Restaurar dependencias y compilar:
   ```bash
   dotnet restore
   dotnet build
   ```

4. Ejecutar la aplicación:
   ```bash
   dotnet run
   ```

## Estructura del proyecto

- `Program.cs`: punto de entrada de la aplicación.
- `ListaBDAlumnos.cs`: lógica relacionada con la lista y manejo de alumnos.
- `alumnos.csv`: archivo con los datos de ejemplo.
- `.gitignore`: archivos que no deben subirse al repositorio.

## Nota para el profesor

El trabajo fue realizado como una práctica de programación en consola, enfocada en el manejo de archivos CSV y en la organización básica de un proyecto en C#.

Si desea, también se puede agregar una versión con interfaz gráfica o con conexión a base de datos.
