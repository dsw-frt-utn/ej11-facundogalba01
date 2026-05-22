using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    // 1. Crear un campo que represente una lista de alumnos
    private List<Alumno> _alumnos = new List<Alumno>();

    // 2. Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        if (alumno != null)
        {
            _alumnos.Add(alumno);
        }
    }

    // 3. Incluir un método para retornar la lista
    public List<Alumno> ObtenerLista()
    {
        return _alumnos;
    }

    // 4. Incluir un método para buscar un alumno por nombre
    public Alumno BuscarPorNombre(string nombre)
    {
        // Mapea impecable con tu propiedad Nombre
        return _alumnos.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    // 5. Incluir un método para eliminar un alumno (debe recibir un alumno)
    public bool EliminarAlumno(Alumno alumno)
    {
        // Remove retorna true si lo encontró y lo borró, o false en caso contrario
        return _alumnos.Remove(alumno);
    }

    // 6. Incluir un método para eliminar un alumno en una determinada posición de la lista
    public bool EliminarEnPosicion(int indice)
    {
        // Validamos que el índice esté dentro del rango válido de la lista
        if (indice >= 0 && indice < _alumnos.Count)
        {
            _alumnos.RemoveAt(indice);
            return true;
        }
        return false; // Índice fuera de rango
    }
}
