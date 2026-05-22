using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    // 1. Crear el diccionario privado (Clave: legajo [int], Valor: Alumno)
    private Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();

    // 2. Método para agregar un alumno al diccionario
    public bool AgregarAlumno(Alumno alumno)
    {
        if (alumno == null) return false;

        // Usamos Id como el legajo
        if (!_alumnos.ContainsKey(alumno.Id))
        {
            _alumnos.Add(alumno.Id, alumno);
            return true;
        }
        return false;
    }

    // 3. Método para buscar un alumno utilizando la clave
    public Alumno BuscarAlumno(int legajo)
    {
        // TryGetValue es la forma más segura y eficiente de buscar en un Dictionary
        if (_alumnos.TryGetValue(legajo, out Alumno alumno))
        {
            return alumno;
        }
        return null; // Retorna null si no lo encuentra
    }

    // 4. Método para retornar el diccionario completo
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnos;
    }

    // 5. Método para eliminar un alumno utilizando la clave
    public bool EliminarAlumno(int legajo)
    {
        // Remove retorna true si lo encontró y eliminó, o false si no existía
        return _alumnos.Remove(legajo);
    }
}