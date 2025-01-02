using IndustriellMaskinpark.Application.Interfaces;
using IndustriellMaskinpark.Domain.Entity;

namespace IndustriellMaskinpark.Application.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _repository;

        public DeviceService(IDeviceRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Device>> GetAllDevicesAsync()
        {
            return await _repository.GetAllDevicesAsync();
        }

        public async Task<Device?> GetDeviceByIdAsync(Guid id)
        {
            return await _repository.GetDeviceByIdAsync(id);
        }

        public async Task AddDeviceAsync(Device device)
        {
            await _repository.AddDeviceAsync(device);
        }

        public async Task UpdateDeviceAsync(Device device)
        {
            await _repository.UpdateDeviceAsync(device);
        }

        public async Task DeleteDeviceAsync(Guid id)
        {
            await _repository.DeleteDeviceAsync(id);
        }
    }
}
