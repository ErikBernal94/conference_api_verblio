using Conference.BL.Repositories;
using Conference.BL.Repositories.Implements;
using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.BL.Services.Implements
{
    public class AttendeeService: GenericService<Attendee>, IAttendeeService
    {
        public AttendeeService(IAttendeeRepository atendeeRepository): base(atendeeRepository)
        {

        }
    }
}
