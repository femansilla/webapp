using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhotoSharingApplication.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }

        [Required]
        [DisplayName("Picture")]        public string Title { get; set; }

        public byte[] PhotoFile { get; set; }

        [DataType(DataType.MultilineText)]
        public string ImageMimeType { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UserName { get; set; }

        [Required]
        [StringLength(250)]        public virtual ICollection<Comment> Comments { get; set; }
    }
}