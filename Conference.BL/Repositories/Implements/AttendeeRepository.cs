using Conference.DL.Context;
using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.BL.Repositories.Implements
{
    public class AttendeeRepository: GenericRepository<Attendee>, IAttendeeRepository
    {
        private readonly ConferenceContext conferenceContext;

        public AttendeeRepository(ConferenceContext conferenceContext): base(conferenceContext) 
        {
            this.conferenceContext = conferenceContext;
        }

        public IEnumerable<Attendee> GetByIdTalk(int idTalk)
        {
            return conferenceContext.Atendees.Where(a => a.idTalk == idTalk);
        }
    }
}
