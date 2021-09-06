using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategory1Service
    {
		IResult Add(Category1 category1);

		IResult Delete(int id);

		IDataResult<List<Category1>> GetAll();

		IDataResult<Category1> GetById(int id);
	}
}
