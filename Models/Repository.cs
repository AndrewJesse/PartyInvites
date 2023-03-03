// Declares a namespace called "PartyInvites.Models"
namespace PartyInvites.Models
{
    // Declares a public static class called "Repository"
    public static class Repository
    {
        // Declares a private static List object called "responses" that holds GuestResponse objects
        private static List<GuestResponse> responses = new();

        // Declares a public static property called "Responses" that returns the "responses" List object
        public static IEnumerable<GuestResponse> Responses => responses;

        // Declares a public static method called "AddResponse" that takes a GuestResponse object called "response" as input
        public static void AddResponse(GuestResponse response)
        {
            // Writes the "response" object to the console
            Console.WriteLine(response);

            // Adds the "response" object to the "responses" List object
            responses.Add(response);
        }
    }
}
