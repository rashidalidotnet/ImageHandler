using System;
using ImageHandler.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ImageHandler.Controllers
{
    [Route("")]
    public class ImageController : Controller
    {
        private readonly IImagesRepository _imagesRepository;
        public ImageController(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository ?? throw new ArgumentNullException(nameof(imagesRepository));
        }

        [HttpGet("cdn")]
        public IActionResult Cdn()
        {
            var images = _imagesRepository.GetImagesWithCdn();
            return View(images);
        }

        [HttpGet("base64")]
        public IActionResult Base64()
        {
            var images = _imagesRepository.GetImagesWithContent();
            return View(images);
        }
    }
}
