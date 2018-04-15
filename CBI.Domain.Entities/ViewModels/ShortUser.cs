﻿using CBI.Domain.Entities.Infrastructure;
using System;
using System.Collections.Generic;

namespace CBI.Domain.Entities.ViewModels
{
    public class ShortUser: BaseEntity
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}