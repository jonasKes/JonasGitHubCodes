﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public User GroupUser { get; set; }
        public string Post { get; set; }

    }
}