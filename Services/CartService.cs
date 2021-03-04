using Blazored.LocalStorage;

namespace IzonStore.Services
{
    public class CartService : StorageService<string>
    {
        public CartService(ILocalStorageService storageService) : base(storageService) 
        {
            SetStorageName("cart");
        }
    }
}
