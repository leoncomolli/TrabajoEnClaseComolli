using System;

try
{
    using var lista = new ListaBDAlumnos();

    Console.Write("Ingrese el legajo del alumno: ");
    string? entrada = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entrada) || !int.TryParse(entrada.Trim(), out int legajo))
    {
        Console.WriteLine("Error: el legajo debe ser un número entero.");
        return;
    }

    var alumno = lista.BuscarAlumnoPorLegajo(legajo);

    if (alumno is null)
    {
        Console.WriteLine($"No se encontró ningún alumno con legajo {legajo}.");
        return;
    }

    Console.WriteLine("Alumno encontrado:");
    Console.WriteLine($"Legajo: {alumno.Legajo}");
    Console.WriteLine($"Nombre: {alumno.Nombre}");
    Console.WriteLine($"Apellido: {alumno.Apellido}");
    Console.WriteLine($"Edad: {alumno.Edad}");
    Console.WriteLine($"Curso: {alumno.Curso}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error de datos: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrió un error inesperado.");
    Console.WriteLine($"Detalle: {ex.Message}");
}
