using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApp.DAL.Interface;
using SchoolManagementApp.EF.Models;
using SchoolManagementApp.EF.UnitOfWork;
using SchoolManagementApp.DAL.DTO;


namespace SchoolManagementApp.DAL.Concrete
{
   public class GenderDataService : DataServiceBase, IGender
    {
       public GenderDataService()
       {

       }

       public GenderDataService(IUnitOfWork<SchoolManagementAppEntities> unitOfWork)
           : base(unitOfWork)
        {

        }

       public int SaveGender(GenderDTO gender)
       {
           if (gender.GenderId == 0)
           {
               var c = new Gender()
               {
                   Name = gender.Name,
                   CreatedOn = DateTime.Now
               };
               this.UnitOfWork.Get<Gender>().AddNew(c);
               this.UnitOfWork.SaveChanges();
               return c.GenderId;
           }
           else
           {
               var c = this.UnitOfWork.Get<Gender>().AsQueryable()
                       .FirstOrDefault(d => d.GenderId == gender.GenderId);
               if (c != null)
               {
                   c.Name = gender.Name;
                   c.CreatedOn = gender.CreatedOn;
                   c.TimeStamp = gender.TimeStamp;
                   this.UnitOfWork.Get<Gender>().Update(c);
                   this.UnitOfWork.SaveChanges();
               }
               return c.GenderId;
           }
       }   
    }
}
