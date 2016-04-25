using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GsVacancy.DAL.Models;

using Microsoft.Data.Entity;

namespace GsVacancy.BLL.Managers
{
    public class VacancyManager : IVacancyManager
    {
        #region Implementation of IVacancyManager

        public Vacancy GetVacancy(int vacancyId)
        {
            using (var appDbContext = new AppDbContext())
            {
               
                return appDbContext.Vacancies;
            }
            
        }

        #endregion
    }
}
