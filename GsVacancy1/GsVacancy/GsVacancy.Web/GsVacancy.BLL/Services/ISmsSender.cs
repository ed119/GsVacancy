using System.Threading.Tasks;

namespace GsVacancy.BLL.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}