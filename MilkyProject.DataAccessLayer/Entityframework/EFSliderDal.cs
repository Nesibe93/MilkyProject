using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.Entityframework
{
    public class EFSliderDal:GenericRepository<Slider>,ISliderDal
    {
        public EFSliderDal(MilkyContext context) : base(context)
        {
             
        }
    }
}
