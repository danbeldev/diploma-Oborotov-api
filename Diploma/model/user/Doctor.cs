﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.model.user
{
    [Table(name: "Doctors")]
    public class Doctor : User
    {
        public string? Photo { get; set; } = null;
        [Required] public string Offece { get; set; } = string.Empty;
        public override string Role => "DoctorUser";
        public virtual List<Recipe> Recipes { get; set; } = new List<Recipe>();
        public virtual List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
