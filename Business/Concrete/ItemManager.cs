using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Item>> GetAllCategory1Id(int cat1Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Item> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Item>> GetByItemName(string itemName)
        {
            return new SuccessDataResult<List<Item>>(_itemDal.GetAll(i => i.ItemName.Contains(itemName)));
        }
    }
}
