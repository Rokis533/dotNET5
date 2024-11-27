using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PotatoApi.Database;
using PotatoApi.Requests;

namespace PotatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public PhotoController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //[HttpPost("UploadPhoto")]
        //public IActionResult UploadPhoto([FromForm] ImageUploadRequest imageUploadRequest)
        //{
        //    using var memoryStream = new MemoryStream();
        //    imageUploadRequest.Photo.CopyTo(memoryStream);
        //    var imageBytes = memoryStream.ToArray();
        //    var potato = _dbContext.Potatoes.FirstOrDefault(x => x.Id == imageUploadRequest.PotatoId);
        //    if (potato is not null)
        //    {
        //        potato.Bytes = imageBytes;
        //        _dbContext.SaveChanges();
        //    }

        //    return Ok();
        //}
        //[HttpGet("GetPhoto")]
        //public IActionResult GetPhoto(int potatoId)
        //{
        //    var potato = _dbContext.Potatoes.FirstOrDefault(x => x.Id == potatoId);
        //    if (potato is null)
        //    {
        //        return NotFound();
        //    }

        //    return File(potato.Bytes, "image/jpeg");
        //}
        [HttpPost("UploadPhoto")]
        public IActionResult UploadPhoto([FromForm] ImageUploadRequest imageUploadRequest)
        {

            string pathWhereToSave = "uploads/";
            Directory.CreateDirectory(pathWhereToSave);

            var extention = Path.GetExtension(imageUploadRequest.Photo.FileName);

            string filePath = Path.Combine(pathWhereToSave, $"{imageUploadRequest.Photo.Name}_{DateTime.Now:yyyy_MM_dd}{extention}");

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                imageUploadRequest.Photo.CopyTo(stream);
            }

            var potato = _dbContext.Potatoes.FirstOrDefault(x => x.Id == imageUploadRequest.PotatoId);
            if (potato is null)
            {
                return NotFound();
            }

            potato.FilePath = filePath;
            _dbContext.SaveChanges();


            return Ok();
        }
        [HttpGet("GetPhoto")]
        public IActionResult GetPhoto(int potatoId)
        {
            var potato = _dbContext.Potatoes.FirstOrDefault(x => x.Id == potatoId);
            if (potato is null)
            {
                return NotFound();
            }

            string path = potato.FilePath;

            if (!System.IO.File.Exists(path))
            {
                return NotFound();
            }
            var bytes = System.IO.File.ReadAllBytes(path);

            var extention = Path.GetExtension(path);

            var fileName = Path.GetFileName(path);

            return File(bytes, $"image/{extention.Replace(".", "")}", fileName);
        }
    }
}
