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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _annoumcementDal;

        public AnnouncementManager(IAnnouncementDal annoumcementDal)
        {
            _annoumcementDal = annoumcementDal;
        }

        public void Delete(Announcement t)
        {
            _annoumcementDal.Delete(t);
        }

        public Announcement GetById(int id)
        {
            return _annoumcementDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _annoumcementDal.GetListAll();
        }

        public void Insert(Announcement t)
        {
            _annoumcementDal.Insert(t);

        }

        public void Update(Announcement t)
        {
            _annoumcementDal.Update(t);
        }
    }
}
