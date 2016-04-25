using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GsVacancy.DAL.Models;

namespace GsVacancy.BLL.Managers
{
    public interface IVacancyManager
    {
        Vacancy GetVacancy(int vacancyId);
    }
}
