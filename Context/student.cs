//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student_Management_System.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            this.fees = new HashSet<fee>();
            this.results = new HashSet<result>();
        }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Student Id : ")]
        public int std_id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(40)]
        [Display(Name = "Firstname : ")]
        public string std_Fname { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(40)]
        [Display(Name = "Lastname : ")]
        public string std_Lname { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(40)]
        [Display(Name = "Fathername : ")]
        public string std_Fathername { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(40)]
        [Display(Name = "Mothername : ")]
        public string std_Mothername { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(20)]
        [Display(Name = "Gender : ")]
        public string std_gender { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(11)]
        [Display(Name = "Phone Number : ")]
        public string std_phone { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(200)]
        [Display(Name = "Address : ")]
        public string std_address { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(40)]
        [Display(Name = "Email : ")]
        [EmailAddress]
        public string std_email { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Nationality : ")]
        [StringLength(20)]
        public string std_nationality { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Date of Birth : ")]
        public System.DateTime std_dob { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Display(Name = "Date of Admission : ")]
        public System.DateTime std_doa { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Age : ")]
        public int std_age { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(20)]
        [Display(Name = "Religion : ")]
        public string std_religion { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Class Id : ")]
        public Nullable<int> std_class_id { get; set; }

        public virtual @class @class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fee> fees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<result> results { get; set; }
    }

    public partial class JoinClass
    {
        public int std_id { get; set; }
        public string std_Fname { get; set; }
        public string std_Lname { get; set; }
        public string std_Fathername { get; set; }
        public string std_Mothername { get; set; }
        public string std_gender { get; set; }
        public string std_phone { get; set; }
        public string std_address { get; set; }
        public string std_email { get; set; }
        public string std_nationality { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public System.DateTime std_dob { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public System.DateTime std_doa { get; set; }
        public int std_age { get; set; }
        public string std_religion { get; set; }
        public Nullable<int> std_class_id { get; set; }
        public string ClassName { get; set; }
    }
}
