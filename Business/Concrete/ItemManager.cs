using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace Business.Concrete
{
    public class ItemManager : IItemService
    {

        IItemDal _itemDal;

        public ItemManager(IItemDal itemDal)
        {
            _itemDal = itemDal;
        }
        public IResult Add(Item item)
        {
            _itemDal.Add(item);
            return new SuccessResult("Ürün Ekleme İşlemi Başarılı" + "  Ürün ID : " + item.Id);
        }

        public IResult Delete(int id)
        {
            Item item = _itemDal.Get(i => i.Id == id);
            _itemDal.Delete(item);
            return new SuccessResult("Silme işlemi başarılı");
        }

        public IDataResult<List<Item>> GetAllCategory1Id(int cat1Id)
        {
            return new SuccessDataResult<List<Item>>(_itemDal.GetAll(i => i.Category1 == cat1Id));
        }

        public IDataResult<Item> GetById(int id)
        {
            return new SuccessDataResult<Item>(_itemDal.Get(i => i.Id == id));
        }

        public IDataResult<List<Item>> GetByItemName(string itemName)
        {
            return new SuccessDataResult<List<Item>>(_itemDal.GetAll(i => i.ItemName.Contains(itemName)));
        }

        public IDataResult<List<Item>> GetByItemNamePageable(string itemName, int pageNo, int pageSize)
        {
            int skipRows = (pageNo - 1) * pageSize;
            return new SuccessDataResult<List<Item>>(_itemDal.GetAll(i => i.ItemName.Contains(itemName)).Skip(skipRows).Take(pageSize).ToList());
        }

        public IDataResult<List<Item>> GetCategory1Id(int cat1Id, int pageNo, int pageSize)
        {

            int skipRows = (pageNo - 1) * pageSize;

            return new SuccessDataResult<List<Item>>(_itemDal.GetAll(i => i.Category1 == cat1Id).Skip(skipRows).Take(pageSize).ToList());
        }
    }
}
