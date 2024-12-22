Hotel API - Backend Developer Test

This project is a simple REST API built using ASP.NET Core to serve hotel-related data for a frontend application.

Features:
	Retrieve a list of all hotels.
	Retrieve details of a specific hotel by its ID.
	Handles edge cases like invalid IDs and hotel not found.
	Validates input to ensure the ID is a numeric value.
	Serves data from a `hotels.json` file.




1. Get All Hotels
URL: `GET /api/hotels`  
Description: Returns a list of all available hotels.  


2. Get Hotel By ID
URL: `GET /api/hotels/{id}`  
Description: Fetches details of a specific hotel by its ID.  

3. Invalid ID (400 Bad Request):

 "message": "Invalid ID. Please provide a numeric value."

4. Hotel Not Found (404 Not Found):

"message": "Hotel Not Found..!"



Data Source::

The API uses a `hotels.json` file located in the `Data` folder. This file contains an array of 10 hotel objects with fields like:
- `id` (integer)
- `name` (string)
- `location` (string)
- `rating` (float)
- `imageUrl` (string)
- `datesOfTravel` (array of strings)
- `boardBasis` (string)
- `rooms` (array of room objects)

- Error Handling
- Invalid ID: Returns a 400 Bad Request if the ID is not numeric.
- Hotel Not Found: Returns a 404 Not Found if no hotel matches the provided ID.
- Server Errors: Returns a 500 Internal Server Error if an issue occurs while reading data.



