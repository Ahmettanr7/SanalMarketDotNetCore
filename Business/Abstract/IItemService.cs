using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IItemService
    {
		IResult Add(Item item);

		IResult Delete(int id);

		//IDataResult<List<Item>> GetCategory1Id(int cat1Id, int pageNo, int pageSize);

		IDataResult<Item> GetById(int id);

		IDataResult<List<Item>> GetAllCategory1Id(int cat1Id);

		IDataResult<List<Item>> GetByItemName(String itemName);

		//IDataResult<List<Item>> GetByItemNamePageable(String itemName, int pageNo, int pageSize);
	}
}
