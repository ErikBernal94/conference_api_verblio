using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.BL.DTOs
{
    public class AtendeeDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string registered { get; set; }
        public int  idTalk { get; set; }
    }
}
