using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using O20240408.EntidadesDeNegocio;
using O20240408.LogicaDeNegocio;

namespace O20240408.UI.AppWebMVC.Controllers
{
    public class PersonaOController : Controller
    {
        readonly PersonaOBL _personaOBL;
        public PersonaOController(PersonaOBL personasO)
        {
            _personaOBL = personasO;
        }
        // GET: ClienteController
        public async Task<ActionResult> Index(PersonaO persona)
        {
            var personaO = await _personaOBL.Buscar(persona);
            return View(personaO);
        }

        // GET: ClienteController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personaO = await _personaOBL.ObtenerPorId(new PersonaO { Id = id});
            return View(personaO);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaO personaO)
        {
            try
            {
                await _personaOBL.Crear(personaO);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var cliente = await _personaOBL.ObtenerPorId(new PersonaO { Id = id });
            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaO persona)
        {
            try
            {
                await _personaOBL.Modificar(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await _personaOBL.ObtenerPorId(new EntidadesDeNegocio.PersonaO { Id = id });
            return View(cliente);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaO persona)
        {
            try
            {
                await _personaOBL.Eliminar(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
