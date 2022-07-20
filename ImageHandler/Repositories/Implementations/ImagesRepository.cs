using System;
using ImageHandler.Models;
using System.Collections.Generic;
using ImageHandler.Repositories.Contracts;
using System.Linq;

namespace ImageHandler.Repositories.Implementations
{
    public class ImagesRepository : IImagesRepository
    {
        private readonly ImageHandlerDbContext _imageHandlerDbContext;
        public ImagesRepository(ImageHandlerDbContext imageHandlerDbContext)
        {
            _imageHandlerDbContext = imageHandlerDbContext ?? throw new ArgumentNullException(nameof(imageHandlerDbContext));
        }

        public List<string> GetImagesWithContent()
        {
            var images = _imageHandlerDbContext.Images.Select(image => image.FileContent).ToList();
            return images;
        }

        public List<string> GetImagesWithCdn()
        {
            var images = _imageHandlerDbContext.Images.Select(image => image.FilePath).ToList();
            return images;
        }
    }
}
