using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContantManager : IContantService
    {
        public readonly IContantDal _contantDal;

        public ContantManager(IContantDal contantDal)
        {
            _contantDal = contantDal;
        }

        public void Delete(Contant t)
        {
            _contantDal.Delete(t);
        }

        public Contant GetById(int id)
        {
            return _contantDal.GetById(id);
        }

        public List<Contant> GetListAll()
        {
            return _contantDal.GetListAll();
        }

        public void Insert(Contant t)
        {
            _contantDal.Insert(t);
        }

        public void Update(Contant t)
        {
            _contantDal.Update(t);
        }
    }
}
