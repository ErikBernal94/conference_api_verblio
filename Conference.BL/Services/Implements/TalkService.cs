using Conference.BL.Repositories;
using Conference.BL.Repositories.Implements;
using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.BL.Services.Implements
{
    public class TalkService: GenericService<Talk>, ITalkService
    {
        private readonly ITalkRepository talkRepository;
        private readonly ISpeakerRepository speakerRepository;
        private readonly IAttendeeRepository attendeeRepository;

        public TalkService(ITalkRepository talkRepository, ISpeakerRepository speakerRepository, IAttendeeRepository attendeeRepository): base(talkRepository)
        {
            this.talkRepository = talkRepository;
            this.speakerRepository = speakerRepository;
            this.attendeeRepository = attendeeRepository;
        }

        public async new Task<IEnumerable<Talk>> GetAll()
        {
            var talks = await talkRepository.GetAll();
            foreach(var talk in talks)
            {
                talk.speaker = speakerRepository.GetByIdTalk(talk.id);
                talk.attendees = attendeeRepository.GetByIdTalk(talk.id).ToList();
            }
            return talks;
        }
    }
}
