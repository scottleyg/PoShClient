namespace PoShApiClient.Models.Requests
{
    public class WeatherForecastRequest
    {
        public int Days { get;set;} = 5;
        public string City { get;set;}
    }   
}