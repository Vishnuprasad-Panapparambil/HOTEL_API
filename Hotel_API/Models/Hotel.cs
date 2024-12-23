namespace Hotel_API.Models
{

    public class Hotel
    {
            public int id {  get; set; }
            public required string name { get; set; }
            public required string location { get; set; }
            public double rating {  get; set; }
            public required string imageUrl {  get; set; }
            public required List<string> datesOfTravel { get; set; }
            public required string boardBasis {  get; set; }

    }
    public class Room
    {
        public required string RoomType { get; set; }
        public int Amount { get; set; }
    }
}
