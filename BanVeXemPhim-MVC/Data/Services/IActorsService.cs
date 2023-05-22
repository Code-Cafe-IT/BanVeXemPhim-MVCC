using BanVeXemPhim_MVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BanVeXemPhim_MVC.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        IActorsService GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
