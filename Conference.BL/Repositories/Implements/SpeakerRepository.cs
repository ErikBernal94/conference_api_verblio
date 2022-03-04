using Conference.DL.Context;
using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.BL.Repositories.Implements
{
    public class SpeakerRepository: GenericRepository<Speaker>, ISpeakerRepository
    {
        private readonly ConferenceContext conferenceContext;

        public SpeakerRepository(ConferenceContext conferenceContext): base(conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public Speaker GetByIdTalk(int idTalk)
        {
            return conferenceContext.Speakers.First(s => s.idTalk == idTalk);
        }
    }
}
