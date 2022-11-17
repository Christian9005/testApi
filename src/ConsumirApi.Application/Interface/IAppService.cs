
namespace ConsumirApi.Application.Interface;
public interface IAppService
{
    Task<ICollection<Personajes>> GetAllAsync();
}
