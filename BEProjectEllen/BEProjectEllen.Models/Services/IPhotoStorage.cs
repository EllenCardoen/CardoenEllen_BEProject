using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Services
{
    public interface IPhotoStorage
    {
        void DeletePhoto(string oldPhoto);
        Task<string> StorePhoto(IFormFile file, string uploadsFolderPath, string name);
        string UpdatePhoto(string folderPath, string oldPhoto, string newPhoto);
    }
}