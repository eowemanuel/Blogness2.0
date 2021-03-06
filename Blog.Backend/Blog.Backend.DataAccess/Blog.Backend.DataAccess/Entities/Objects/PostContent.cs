﻿using System;

namespace Blog.Backend.DataAccess.Entities.Objects
{
    public class PostContent
    {
        public int PostContentId { get; set; }
        public virtual Post Post { get; set; }
        public int PostId { get; set; }
        public virtual Media Media { get; set; }
        public int MediaId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
