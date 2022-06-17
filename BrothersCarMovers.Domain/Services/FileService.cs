using BrothersCarMovers.Domain.Dtos;
using BrothersCarMovers.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BrothersCarMovers.Domain.Services
{
    public class FileService : IFileService
    {
        public async Task<FileCreatedDto> Upload(FileCreatedDto fileCreatedDto)
        {
            var isSaved = await SaveFile("", "", fileCreatedDto.Bytes);
            fileCreatedDto.IsUploadComplete = isSaved.IsSuccess;
            return fileCreatedDto;
        }

        private async Task<(bool IsSuccess, Exception error)> SaveFile(String path, string altPath, byte[] bytes)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    System.IO.File.WriteAllBytes(path, bytes);
                }
                else
                {
                    //Log or something.
                    System.IO.File.WriteAllBytes(altPath, bytes);
                }

                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }
        }
    }
}
