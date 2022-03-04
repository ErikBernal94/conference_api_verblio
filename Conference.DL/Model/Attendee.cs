using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Conference.DL.Model
{
    [Table("Atendee")]
    public class Attendee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string registered { get; set; }
        public Talk talk { get; set; }
        public int idTalk { get; set; }

    }
}
