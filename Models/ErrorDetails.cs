using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FindDistanceApp.Models
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
