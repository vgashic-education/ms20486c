using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Models {
	public class Comment {
		public int CommentID { get; set; }
		public int PhotoID { get; set; }
		public string USerName { get; set; }
		public string Subjet { get; set; }
		public string Body { get; set; }
		public DateTime DateCreated { get; set; }

		public virtual Photo Photo { get; set; }
	}
}