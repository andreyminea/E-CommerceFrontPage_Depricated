using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IzonStore.Services
{
    public abstract class StorageService<T>
    {
        private List<T> data;
        private string storageName;
        protected ILocalStorageService localStorageService;
        public delegate void Notify();
        public event Notify ChangeNotification;

        public StorageService(ILocalStorageService storageService)
        {
            localStorageService = storageService;
        }
        protected void SetStorageName(string name)
        {
            storageName = name;
        }
        public int GetDataCount()
        {
            if (data == null)
                data = new List<T>();
            return data.Count;
        }
        public async Task<List<T>> GetAllDataAsync()
        {
            var items = await localStorageService.GetItemAsync<List<T>>(storageName);

            if (items != null)
                data = items;
            else
                data = new List<T>();
            return data;
        }
        public async Task<T> GetDataFromIndexAsync(int index)
        {
            await GetAllDataAsync();

            if (index > data.Count - 1 || index < 0)
                return default(T);
            return data[index];
        }
        public async Task AddDataAsync(T newData)
        {
            if (newData != null)
            {
                data.Add(newData);
                await localStorageService.SetItemAsync(storageName, data);
                ChangeNotification?.Invoke();
            }
        }
        public async Task UpdateDataAync()
        {
            await localStorageService.SetItemAsync(storageName, data);
        }
        public async Task DeleteDataAsync()
        {
            await localStorageService.ClearAsync();
        }
    }
}
