﻿using Hospital.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public enum AppointmentStatusType
    {
        [Display(Name = "Open")] Open,
        [Display(Name = "Reserved")] Reserved
    }
    [MiddlewareFilter(typeof(LocalizationPipeline))]
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [NotMapped]
        public int doctorId { get; set; }
        public virtual Doctor doctor { get; set; }
        [NotMapped]
        public int? patientId { get; set; }
        public virtual Patient patient { get; set; }

        public string reason { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime date { get; set; }

        public AppointmentStatusType status { get; set; }

    }
}
