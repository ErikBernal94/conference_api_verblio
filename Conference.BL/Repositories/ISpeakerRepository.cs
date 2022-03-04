using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conference.BL.Repositories
{
    public interface ISpeakerRepository: IGenericRepository<Speaker>
    {
        Speaker GetByIdTalk(int idTalk);
    }
}
