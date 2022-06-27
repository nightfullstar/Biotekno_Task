﻿using Biotekno_Task.Api.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biotekno_Task.Api.Core.Entity
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }


    }
}
