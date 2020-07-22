﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tier.Entities.Concrete
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string FullContent { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public string ImagePath { get; set; }
    }
}
