﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateApi.Models
{
    public class Sms : BaseModel
    {
        [Key]
        public int SmsId { get; set; }
        public string Type { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string Message { get; set; }
        public int Code { get; set; }
        public string Response { get; set; }
    }
}
