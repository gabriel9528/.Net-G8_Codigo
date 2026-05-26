using DapperMVCDemo.Data.Models.Domain;
using DapperMVCDemo.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DapperMVCDemo.UI.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public async Task<IActionResult> DisplayAll()
        {
            var listPerson = await _personRepository.GetAllPersonsAsync();
            return View(listPerson);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Person person)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(person);
                }

                bool result = await _personRepository.AddPersonAsync(person);

                if(result)
                {
                    return RedirectToAction(nameof(DisplayAll));
                }
                return View(person);
            }
            catch (Exception ex)
            {
                return View(person);
            }
        }
    }
}
