using CloudinaryDotNet.Actions;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IImageService
    {
        IResult Add(int itemId, IFormFile file);


        IResult Upload(ImagePath image);

        IDataResult<List<ImagePath>> GetByItemId(int itemId);
    }
}
