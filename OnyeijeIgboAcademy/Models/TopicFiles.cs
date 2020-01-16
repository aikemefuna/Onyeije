﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models

{
    public class TopicFiles : BaseEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }

        public int TopicId { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
