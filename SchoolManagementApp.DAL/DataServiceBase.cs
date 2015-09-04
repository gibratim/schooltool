using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApp.EF.Context;
using SchoolManagementApp.EF.UnitOfWork;
using SchoolManagementApp.EF.Models;

namespace SchoolManagementApp.DAL
{
   public class DataServiceBase
    {
       private IUnitOfWork<SchoolManagementAppEntities> _unitOfwork;

       protected IUnitOfWork<SchoolManagementAppEntities> UnitOfWork { get { return this._unitOfwork; } }

       public DataServiceBase(IUnitOfWork<SchoolManagementAppEntities> unitOfWork)
        {
            this._unitOfwork = unitOfWork;
        }
    }
}
