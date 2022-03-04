using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conference.BL.Services
{
    public interface ITalkService: IGenericService<Talk>
    {
        new Task<IEnumerable<Talk>> GetAll();
    }
}
