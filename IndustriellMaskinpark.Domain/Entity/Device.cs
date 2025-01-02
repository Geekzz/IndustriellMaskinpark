using System.ComponentModel.DataAnnotations;

namespace IndustriellMaskinpark.Domain.Entity
{
    public enum DeviceType
    {
        Sensor,
        Actuator,
        Controller
    }

    public enum DeviceStatus
    {
        Online,
        Offline
    }
    public class Device
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(100, ErrorMessage = "Location cannot exceed 100 characters.")]
        public required string Location { get; set; }

        [Display(Name = "Last Updated")]
        [Required]
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        [Required]
        public DeviceType Type { get; set; }

        [Required]
        public DeviceStatus Status { get; set; }
    }
}
