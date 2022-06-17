using BrothersCarMovers.Common;
using BrothersCarMovers.Domain.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace BrothersCarMovers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileApiController : ControllerBase
    {
        private readonly Config _config;
        public FileApiController(IOptions<Config> config)
        {
            _config = config.Value;
        }

        [HttpPost]
        public async Task<FileCreatedDto> UploadFile()
        {
            return null;
        }
    }
}
