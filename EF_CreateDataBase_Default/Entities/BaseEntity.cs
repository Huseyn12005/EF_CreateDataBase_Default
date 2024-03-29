﻿using EF_CreateDataBase_Default.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CreateDataBase_Default.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DataStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
