using Microsoft.AspNetCore.Mvc;
using Hotel_API.Models;
using Hotel_API.Data;
namespace Hotel_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HotelController:ControllerBase
    {
        private readonly List<Hotel> _hotels;
        public HotelController()
        {
            _hotels = HotelDataLoader.LoadHotels("Data/hotels.json");

            if (!_hotels.Any())
            {
                Console.WriteLine("No hotels loaded.");
            }
            else
            {
                var duplicateIds = _hotels
                    .GroupBy(h => h.id)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToList();

                if (duplicateIds.Any())
                {
                    Console.WriteLine($"Duplicate IDs found: {string.Join(", ", duplicateIds)}");
                    throw new InvalidOperationException($"Duplicate hotel IDs detected: {string.Join(", ", duplicateIds)}");
                }
                foreach (var hotel in _hotels)
                {
                    Console.WriteLine($"Hotel {hotel.id}: {hotel.name}");
                }
            }

        }
        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> GetHotels() 
        {
            return Ok(_hotels);
        }
        [HttpGet("{id}")]
        public ActionResult<Hotel> GetHotelByID(string id)
        {
            if (!int.TryParse(id, out int hotelId))
            {
                return BadRequest(new { message = "Invalid ID. Please provide a numeric value." });
            }
            var hotel = _hotels.FirstOrDefault(h => h.id == hotelId);
            if (hotel == null) 
            { 
                return NotFound(new {message = "Hotel Not Found..!"});
            }
            return Ok(hotel);

        }
    }
}
