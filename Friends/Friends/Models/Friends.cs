using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Friends.Models
{
    public class Friends
    {
        [Key]
        public string FriendId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        public string NickName { get; set; }
        [DataType(DataType.Date)]
        public int BirthDay { get; set; }
    }
}