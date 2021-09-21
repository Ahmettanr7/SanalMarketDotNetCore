using Business.Abstract;
using CloudinaryDotNet.Actions;
using Core.Utilities.Cloudinaryy;
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

        public IResult Upload(ImagePath image)
        {

            DateTime now = DateTime.Now;
            image.DateOfCreation = now;
            _imageDal.Add(image);
            Item item = _itemDal.Get(i => i.Id == image.ItemId);
            item.ImageUrl = image.ImageUrl;
            _itemDal.Update(item);
            return new SuccessResult("Resim Ekleme İşlemi Başarılı");
        }

        public IDataResult<List<ImagePath>> GetByItemId(int itemId)
        {
            return new SuccessDataResult<List<ImagePath>>(_imageDal.GetAll(i => i.ItemId == itemId));
        }

       
    }
}
