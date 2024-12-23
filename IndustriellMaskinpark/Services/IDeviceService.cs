using IndustriellMaskinpark.Models;

namespace IndustriellMaskinpark.Services
{
    public interface IDeviceService
    {
        Task<List<Device>> GetAllDevicesAsync();
        Task<Device?> GetDeviceByIdAsync(int id);
        Task AddDeviceAsync(Device device);
        Task UpdateDeviceAsync(Device device);
        Task DeleteDeviceAsync(int id);
    }
}
