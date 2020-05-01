using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Services
{
    public class FileExpPhotoStorage : IPhotoStorage
    {
        public async Task<string> StorePhoto(IFormFile file, string uploadsFolderPath, string name)
        {
            //check als opslag map bestaat
            if (!Directory.Exists(uploadsFolderPath))
            {
                //indien nodig maak map
                Directory.CreateDirectory(uploadsFolderPath);
            }

            //bestand naam bepalen
            var fileName = name + Path.GetExtension(file.FileName);

            //filepath bepalen
            var filePath = Path.Combine(uploadsFolderPath, fileName);

            //bestand opslaan
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return fileName;
        }

        public void DeletePhoto(string oldPhoto)
        {
            //zoek file
            FileInfo oldFile = new FileInfo(oldPhoto);

            //check of file bestaat
            if (!oldFile.Exists)
                throw new Exception("Photo doesn't exist!");

            //verwijder
            oldFile.Delete();

        }

        /// <summary>
        /// Updates the path of photo
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="oldPhoto"></param>
        /// <param name="newPhoto"></param>
        /// <returns></returns>
        public string UpdatePhoto(string folderPath, string oldPhoto, string newPhoto)
        {
            //oud file
            var fromFile = folderPath + oldPhoto;

            //check if not empty
            if (!File.Exists(fromFile))
                return null;

            //get extention
            var extention = Path.GetExtension(fromFile);
            //naam nieuw file
            var newPhotoName = newPhoto + extention;
            //nieuw file
            var toFile = folderPath + newPhotoName;

            //magic
            Directory.Move(fromFile, toFile);

            return newPhotoName;
        }
    }
}
