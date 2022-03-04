using Conference.BL.Repositories;
using Conference.BL.Repositories.Implements;
using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.BL.Services.Implements
{
    public class SpeakerService: GenericService<Speaker>, ISpeakerService
    {
        public SpeakerService(ISpeakerRepository speakerRepository): base(speakerRepository)
        {

        }
    }
}
