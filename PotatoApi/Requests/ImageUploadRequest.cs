using PotatoApi.ValidationAttributes;

namespace PotatoApi.Requests
{
    public class ImageUploadRequest
    {
        public int PotatoId { get; set; }

        [MaxFileSize(10 * 1024)]
        [AllowedFileExtentions([".jpeg", ".svg", ".png", ".jpg"])]
        public IFormFile Photo { get; set; }
    }
}
