using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.BL.DTOs
{
    public class TalkDto
    {
        public int id { get; set; }
        public string title { get; set; }
        public string @abstract { get; set; }
        public string room { get; set; }
        public SpeakerDto speaker { get; set; }
        public ICollection<AtendeeDto> attendees { get; set; }
    }
}
