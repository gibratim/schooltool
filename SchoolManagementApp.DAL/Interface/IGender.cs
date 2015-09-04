using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApp.DAL.DTO;

namespace SchoolManagementApp.DAL.Interface
{
   public interface IGender
    {
       int SaveGender(GenderDTO gender);
    }
}
