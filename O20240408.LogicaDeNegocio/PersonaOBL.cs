using O20240408.AccesoADatos;
using O20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O20240408.LogicaDeNegocio
{
    public class PersonaOBL 
    {
        readonly PersonaODAL _personaODAL;
        public PersonaOBL(PersonaODAL personaODAL)
        {
            _personaODAL = personaODAL;
        }
        public async Task<int> Crear(PersonaO persona)
        {
            return await _personaODAL.Crear(persona);
        }
        public async Task<int> Modificar(PersonaO persona)
        {
            return await _personaODAL.Modificar(persona);
        }
        public async Task<int> Eliminar(PersonaO persona)
        {
            return await _personaODAL.Eliminar(persona);
        }
        public async Task<PersonaO> ObtenerPorId(PersonaO persona)
        {
            return await _personaODAL.ObtenerPorId(persona);
        }
        public async Task<List<PersonaO>> ObtenerTodos()
        {
            return await _personaODAL.ObtenerTodos();
        }
        public async Task<List<PersonaO>> Buscar(PersonaO persona)
        {
            return await _personaODAL.Buscar(persona);
        }
    }
}
