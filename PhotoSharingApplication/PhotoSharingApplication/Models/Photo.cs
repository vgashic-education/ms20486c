using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models {
	public class Photo {

		public int PhotoID { get; set; }

		[Display(Name="Picture")]
		public string Title { get; set; }

		public byte[] PhotoFile { get; set; }

		public string ImageMimeType { get; set; }

		[DataType(DataType.MultilineText)]
		public string Description { get; set; }

		public string UserName { get; set; }

		public DateTime CreatedDate { get; set; }

		public virtual List<Comment> Comments { get; set; }
	}
}