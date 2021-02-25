﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entity) : base($"{entity} not found.")
        {
        }
    }
}
