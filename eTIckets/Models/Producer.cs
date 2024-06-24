using System.ComponentModel.DataAnnotations;

namespace eTIckets.Models
{
    public class Producer
    {
        [Key]


        public int ID { get; set; }


        public string profilePictureUrl { get; set; }
        public string fullName { get; set; }
        public string bio { get; set; }


    }
}
