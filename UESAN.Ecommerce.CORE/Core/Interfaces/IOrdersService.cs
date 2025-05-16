using System.Threading.Tasks;
using UESAN.Ecommerce.CORE.Core.DTOs;

namespace UESAN.Ecommerce.CORE.Core.Interfaces
{
    public interface IOrdersService
    {
        Task<int> CreateOrderAsync(OrdersDTO orderDto);
        // Otros m�todos como Get, Update, Delete pueden agregarse seg�n necesidad
    }
}