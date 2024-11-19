using Microsoft.AspNetCore.Mvc;
using AM_server_rest.Models;
using System.Collections.Generic;
using System.Linq;

namespace AM_server_rest.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class RoutesController : ControllerBase
    {
        private static List<Tour> Tours = new List<Tour>
        {
            new Tour
            {
                Id = 1,
                Name = "Centra handlowe",
                Waypoints = new List<Waypoint>
                {
                    new Waypoint { Latitude = 49.803455289739425, Longitude = 19.04886603355408, Description = "Gemini park" },
                    new Waypoint { Latitude = 49.826397695716445, Longitude = 19.0488338470459, Description = "Sfera" },
                    new Waypoint { Latitude = 49.83897194230134, Longitude = 19.035991430282596, Description = "Sarni stok" }
                }
            },

            new Tour
            {
                Id = 2,
                Name = "UBB główne budynki",
                Waypoints = new List<Waypoint>
                {
                    new Waypoint { Latitude = 49.7830063406409, Longitude = 19.05784606933594, Description = "L" },
                    new Waypoint { Latitude = 49.78329382854388, Longitude = 19.05838787555695, Description = "A" },
                    new Waypoint { Latitude = 49.7834877953219, Longitude = 19.059015512466434, Description = "B" }
                }
            },

            new Tour
            {
                Id = 3,
                Name = "UBB pobliske żabki",
                Waypoints = new List<Waypoint>
                {
                    new Waypoint { Latitude = 49.785912314523046, Longitude = 19.05288934707642, Description = "Srebrna" },
                    new Waypoint { Latitude = 49.78599543874424, Longitude = 19.057465195655826, Description = "Ustronie" },
                    new Waypoint { Latitude = 49.78809081470304, Longitude = 19.062175154685978, Description = "Bystrzańska" }
                }
            }
        };

        // GET api/routes
        [HttpGet]
        public ActionResult<IEnumerable<Tour>> GetTours()
        {
			Console.WriteLine("GET request received for routes");

			return Ok(Tours);
        }

        // GET api/routes/{id}
        [HttpGet("{id}")]
        public ActionResult<Tour> GetTourById(int id)
        {
            var tour = Tours.FirstOrDefault(t => t.Id == id);
            if (tour == null)
            {
                return NotFound();
            }
            return Ok(tour);
        }
    }
}
