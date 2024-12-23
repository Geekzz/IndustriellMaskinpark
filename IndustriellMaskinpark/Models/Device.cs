﻿using System.ComponentModel.DataAnnotations;

namespace IndustriellMaskinpark.Models
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
        Maintenance,
        Offline
    }
    public class Device
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(100, ErrorMessage = "Location cannot exceed 100 characters.")]
        public required string Location { get; set; }

        [Display(Name = "Last Updated")]
        [Required]
        public DateTime LastUpdated { get; set; }

        [Required]
        public DeviceType Type { get; set; }

        [Required]
        public DeviceStatus Status { get; set; }
    }
}
