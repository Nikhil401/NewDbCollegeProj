//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace NewDbCollegeProj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LatestUpdate
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter text here")]
        public string Information { get; set; }
        public System.DateTime Created_Date { get; set; }
        public Nullable<int> Createdby { get; set; }
    
        public virtual User User { get; set; }
    }
}
