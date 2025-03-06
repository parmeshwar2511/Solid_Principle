using AutoMapper;
using DAL;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CategoryBL : ICategoryBL
    {
        ICategoryRepository _cateRepo;
        IMapper _mapper;

        public CategoryBL(ICategoryRepository catRepo, IMapper mapper)
        {
            _cateRepo = catRepo;
            _mapper = mapper;
        }

        public void Create(CategoryViewModel category)
        {
            Category cat = Mapper.Map<Category>(category);
            _cateRepo.Create(cat);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryViewModel> GetAll()
        {
            var categories = _cateRepo.GetAll();
            return _mapper.Map<List<CategoryViewModel>>(categories);
        }

        public CategoryViewModel GetById(int id)
        {
            var category = _cateRepo.GetById(id);
            return _mapper.Map<CategoryViewModel>(category);
        }

        public void Update(CategoryViewModel category)
        {
            throw new NotImplementedException();
        }
    }
}
