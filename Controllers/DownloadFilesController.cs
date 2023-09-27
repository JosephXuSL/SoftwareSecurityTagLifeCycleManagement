using SSTLifeCycleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace SSTLifeCycleManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DownloadFilesController : ControllerBase
    {
        private readonly ILogger<DownloadFilesController> _logger;
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public DownloadFilesController(ILogger<DownloadFilesController> logger, FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _logger = logger;
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider
                ?? throw  new System.ArgumentNullException(nameof(fileExtensionContentTypeProvider));
        }

        [HttpGet]
        public IActionResult Get()
        {
            //change the file path when use
            var path = "xxx.pdf";
            if (!System.IO.File.Exists(path))
            {
                return NotFound();
            }
            if (!_fileExtensionContentTypeProvider.TryGetContentType(path, out var contentType)) {
                contentType = "applicaation/octet-steam";
            }
            var bytes=System.IO.File.ReadAllBytes(path);
            return File(bytes, contentType, Path.GetFileName(path));

        }
    }
}
