using Microsoft.EntityFrameworkCore;
using O20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O20240408.AccesoADatos
{
    public class PersonaODAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaODAL(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public async Task<int> Crear(PersonaO persona)
        {
            _appDbContext.Add(persona);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaO persona)
        {
            var clienteData = await _appDbContext.Personas.FirstOrDefaultAsync(s => s.Id == persona.Id);
            if (clienteData != null)
            {
                clienteData.NombreO = persona.NombreO;
                clienteData.ApellidoO = persona.ApellidoO;
                clienteData.FechaNacimientoO = persona.FechaNacimientoO;
                _appDbContext.Update(clienteData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaO persona)
        {
            var clienteData = await _appDbContext.Personas.FirstOrDefaultAsync(s => s.Id == persona.Id);
            if (clienteData != null)
                _appDbContext.Remove(clienteData);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<PersonaO> ObtenerPorId(PersonaO persona)
        {
            var clienteData = await _appDbContext.Personas.FirstOrDefaultAsync(s => s.Id == persona.Id);
            if (clienteData != null)
                return clienteData;
            else
                return new PersonaO();
        }
        public async Task<List<PersonaO>> ObtenerTodos()
        {
            return await _appDbContext.Personas.ToListAsync();
        }
        public async Task<List<PersonaO>> Buscar(PersonaO persona)
        {

            var query = _appDbContext.Personas.AsQueryable();
            if (!string.IsNullOrWhiteSpace(persona.NombreO))
            {
                query = query.Where(s => s.NombreO.Contains(persona.NombreO));
            }
            if (!string.IsNullOrWhiteSpace(persona.ApellidoO))
            {
                query = query.Where(s => s.ApellidoO.Contains(persona.ApellidoO));
            }
            return await query.ToListAsync();
        }
    }
}
