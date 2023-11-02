using System.ComponentModel.DataAnnotations;

namespace CarManagement.web.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The make of the car is required.")]
        public string Make { get; set; }

        [Required(ErrorMessage = "The model of the car is required.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "The year of manufacture is required.")]
        [Range(1886, 9999, ErrorMessage = "Please enter a valid year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "The VIN (Vehicle Identification Number) is required.")]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "The VIN must be exactly 17 characters long.")]
        public string VIN { get; set; }

        [Required(ErrorMessage = "The color of the car is required.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "The registration number is required.")]
        public string RegistrationNumber { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The mileage must be a positive number.")]
        public int Mileage { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int OwnerId { get; set; }
        public string Owner { get; set; }
    }

}
