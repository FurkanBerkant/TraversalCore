using Business.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TAdd(SubAbout entity)
        {
            _subAboutDal.Insert(entity);    
        }

        public void TDelete(SubAbout entity)
        {
            _subAboutDal.Delete(entity);    
        }

        public List<SubAbout> TGetAll()
        {
            return _subAboutDal.GetAll();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAbout entity)
        {
            _subAboutDal.Update(entity);
        }
    }
}
