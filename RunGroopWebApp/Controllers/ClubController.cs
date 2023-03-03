using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;
using RunGroopWebApp.ViewModels;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubRepository _clubRepository;
        private readonly IPhotoService _photoServices;

        public ClubController(IClubRepository clubRepository, IPhotoService photoServices)
        {
            _clubRepository = clubRepository;
            _photoServices = photoServices;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAllAsync();
            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateClubViewModel clubVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoServices.AddPhotoAsync(clubVM .Image);

                var club = new Club
                {
                    Title = clubVM.Title,
                    Description = clubVM.Description,
                    Address = new Address
                    {
                        City 
                    }
                    Image = result.Url.ToString()
                };
                _clubRepository.Add(club);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }

            return View(clubVM);

            
        }
    }
}
