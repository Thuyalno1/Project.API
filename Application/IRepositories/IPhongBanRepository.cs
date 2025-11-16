using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IPhongBanRepository
    {
        Task<bool> Exist(int id);

    }
}
