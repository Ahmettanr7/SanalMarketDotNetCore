using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class Category1Manager : ICategory1Service
    {

        ICategory1Dal _categoryDal;

        public Category1Manager(ICategory1Dal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category1 category1)
        {
            _categoryDal.Add(category1);
            return new SuccessResult("Kategori ekleme işlemi başarılı");
        }

        public IResult Delete(int id)
        {
            Category1 category = _categoryDal.Get(c => c.Id == id);
            _categoryDal.Delete(category);
            return new SuccessResult("Kategori silme işlemi başarılı");
        }

        public IDataResult<List<Category1>> GetAll()
        {
            return new SuccessDataResult<List<Category1>>(_categoryDal.GetAll());
        }

        public IDataResult<Category1> GetById(int id)
        {
            return new SuccessDataResult<Category1>(_categoryDal.Get(c => c.Id == id));
        }
    }
}
