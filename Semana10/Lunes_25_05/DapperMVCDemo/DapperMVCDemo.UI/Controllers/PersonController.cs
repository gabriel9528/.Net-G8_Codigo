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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Person? person = new Person();
            try
            {
                person = await _personRepository.GetPersonByIdAsync(id);
                return View(person);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Person person)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(person);
                }

                bool result = await _personRepository.UpdatePersonAsync(person);

                if (result)
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

        public async Task<IActionResult> Delete(int personId)
        {
            var result = await _personRepository.DeletePersonAsync(personId);
            return RedirectToAction(nameof(DisplayAll));
        }
    }
}
