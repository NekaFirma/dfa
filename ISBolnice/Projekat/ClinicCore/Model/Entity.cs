﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicCore.Model
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity(int id)
        {
            Id = id;
        }
        public Entity()
        {

        }
    }
}
