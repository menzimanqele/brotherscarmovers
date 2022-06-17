using BrothersCarMovers.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BrothersCarMovers.Domain.Interfaces
{
    public interface IFileService
    {
        Task<FileCreatedDto> Upload(FileCreatedDto fileCreatedDto);
    }
}
