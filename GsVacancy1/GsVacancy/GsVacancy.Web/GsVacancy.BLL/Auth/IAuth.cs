using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNet.Http.Features.Authentication;

namespace GsVacancy.BLL.Auth
{
    public interface IAuth
    {
       void SignOn(string login);
    }
}
