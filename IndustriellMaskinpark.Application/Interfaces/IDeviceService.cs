﻿using IndustriellMaskinpark.Domain.Entity;

namespace IndustriellMaskinpark.Application.Interfaces
{
    public interface IDeviceService
    {
        Task<List<Device>> GetAllDevicesAsync();
        Task<Device?> GetDeviceByIdAsync(Guid id);
        Task AddDeviceAsync(Device device);
        Task UpdateDeviceAsync(Device device);
        Task DeleteDeviceAsync(Guid id);
    }
}
