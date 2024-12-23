using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Hotel_API.Models;

namespace Hotel_API.Data
{
    public class HotelDataLoader
    {
        public static List<Hotel>LoadHotels(string filepath) 
        {
            if (!File.Exists(filepath))
                throw new FileNotFoundException($"The file {filepath} doesnot exist..!");
            var json = File.ReadAllText(filepath);
            if (string.IsNullOrEmpty(json))
                throw new ArgumentException("The JSON content cannot be null or empty..!");
            return JsonSerializer.Deserialize<List<Hotel>>(json)!;



        }
    }
}
