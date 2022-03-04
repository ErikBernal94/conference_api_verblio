using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conference.BL.Repositories
{
    public interface IAttendeeRepository: IGenericRepository<Attendee>
    {
        IEnumerable<Attendee> GetByIdTalk(int idTalk); 
    }
}
