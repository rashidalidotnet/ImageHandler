using ImageHandler.Models;
using System.Collections.Generic;

namespace ImageHandler.Repositories.Contracts
{
    public interface IImagesRepository
    {
        List<string> GetImagesWithContent();
        List<string> GetImagesWithCdn();
    }
}
