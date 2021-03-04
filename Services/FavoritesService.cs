using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzonStore.Services
{
    public class FavoritesService : StorageService<string>
    {
        public FavoritesService(ILocalStorageService storageService) : base(storageService)
        {
            SetStorageName("favorites");
        }
    }
}
