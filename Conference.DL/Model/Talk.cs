using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Conference.DL.Model
{
    [Table("Talk")]
    public class Talk
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string @abstract { get; set; }
        public int room { get; set; }
        public virtual Speaker speaker { get; set; }
        //public int idSpeaker { get; set; }
        public ICollection<Attendee> attendees { get; set; }
    }
}
