using Conference.DL.Context;
using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.BL.Repositories.Implements
{
    public class TalkRepository: GenericRepository<Talk>, ITalkRepository 
    {
        public TalkRepository(ConferenceContext conferenceContext): base(conferenceContext)
        {

        }
    }
}
