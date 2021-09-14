using Business.Abstract;
using Core.Utilities.FileManager;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImagePathDal _imageDal;
        IItemDal _itemDal;

        public ImageManager(IImagePathDal imageDal, IItemDal itemDal)
        {
            _imageDal = imageDal;
            _itemDal = itemDal;
        }
        public IResult Add(int itemId, IFormFile file)
        {
            ImagePath image = new ImagePath();
            DateTime now = DateTime.Now;
            image.DateOfCreation = now;
            image.ImageUrl = FileHelper.Add(file);
            image.ItemId = itemId;
            _imageDal.Add(image);
            Item item = _itemDal.Get(i => i.Id == image.ItemId);
            item.ImageUrl = image.ImageUrl;
            _itemDal.Update(item);
            return new SuccessResult("Başarıyla eklendi");
        }

        public IDataResult<List<ImagePath>> GetByItemId(int itemId)
        {
            return new SuccessDataResult<List<ImagePath>>(_imageDal.GetAll(i => i.ItemId == itemId));
        }
    }
}
