using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public sealed class ListaBDAlumnos : IDisposable
{
    private readonly StreamReader _reader;
    private readonly List<Alumno> _alumnos = new();
    private bool _disposed;

    public ListaBDAlumnos()
    {
        const string dataFileName = "alumnos.csv";

        if (!File.Exists(dataFileName))
        {
            throw new FileNotFoundException("El archivo de datos de alumnos no se encontró.", dataFileName);
        }

        _reader = new StreamReader(dataFileName);
        LoadAlumnosFromFile();
    }

    private void LoadAlumnosFromFile()
    {
        string? line = _reader.ReadLine();

        while ((line = _reader.ReadLine()) != null)
        {
            var parts = line.Split(',');
            if (parts.Length != 5)
            {
                continue;
            }

            if (!int.TryParse(parts[0].Trim(), out int legajo) || !int.TryParse(parts[3].Trim(), out int edad))
            {
                continue;
            }

            _alumnos.Add(new Alumno(
                legajo,
                parts[1].Trim(),
                parts[2].Trim(),
                edad,
                parts[4].Trim()));
        }
    }

    public Alumno? BuscarAlumnoPorLegajo(int legajo)
    {
        return _alumnos.FirstOrDefault(a => a.Legajo == legajo);
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _reader.Dispose();
        _disposed = true;
    }
}

public sealed record Alumno(int Legajo, string Nombre, string Apellido, int Edad, string Curso);
