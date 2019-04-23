using System.Threading.Tasks;

namespace Reflexa
{
    interface IRequestHandler
    {
        Task HandleRequest();
    }
}
