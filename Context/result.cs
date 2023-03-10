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

    public partial class result
    {

        [Display(Name = "Result Id : ")]
        public int RES_id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Class Id : ")]
        public Nullable<int> RES_class_id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Student Id : ")]
        public Nullable<int> RES_std_id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Exam Type : ")]
        public string Exam_type { get; set; }

        [Display(Name = "Maths Marks : ")]
        public int RES_maths_marks { get; set; }

        [Display(Name = "English Literature Marks : ")]
        public int RES_englishliterature_marks { get; set; }

        [Display(Name = "English Grammar Marks : ")]
        public int RES_englishgrammar_marks { get; set; }

        [Display(Name = "Urdu Marks : ")]
        public int RES_urdu_marks { get; set; }

        [Display(Name = "Islamiyat Marks : ")]
        public int RES_islamiyat_marks { get; set; }

        [Display(Name = "Science Marks : ")]
        public int RES_Science_marks { get; set; }

        [Display(Name = "Physics Marks : ")]
        public int RES_Physics_marks { get; set; }

        [Display(Name = "Chemistry Marks : ")]
        public int RES_Chemistry_marks { get; set; }

        [Display(Name = "History Marks : ")]
        public int RES_History_marks { get; set; }

        [Display(Name = "Geography Marks : ")]
        public int RES_Geography_marks { get; set; }

        [Display(Name = "Computer Marks : ")]
        public int RES_Computer_marks { get; set; }

        [Display(Name = "Activity Marks : ")]
        public int RES_activity_marks { get; set; }

        [Display(Name = "Total Marks : ")]
        public int RES_total_marks { get; set; }

        [Display(Name = "Percentage : ")]
        public double RES_percentage { get; set; }

        [Display(Name = "Grade : ")]
        public string RES_grade { get; set; }

        [Display(Name = "Remarks : ")]
        public string RES_REmarks { get; set; }

        public virtual @class @class { get; set; }
        public virtual student student { get; set; }
    }

    public partial class Joinresult
    {

        [Display(Name = "Result Id : ")]
        public int RES_id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Class Id : ")]
        public Nullable<int> RES_class_id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Student Id : ")]
        public Nullable<int> RES_std_id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Exam Type : ")]
        public string Exam_type { get; set; }

        [Display(Name = "Maths Marks : ")]
        public int RES_maths_marks { get; set; }

        [Display(Name = "English Literature Marks : ")]
        public int RES_englishliterature_marks { get; set; }

        [Display(Name = "English Grammar Marks : ")]
        public int RES_englishgrammar_marks { get; set; }

        [Display(Name = "Urdu Marks : ")]
        public int RES_urdu_marks { get; set; }

        [Display(Name = "Islamiyat Marks : ")]
        public int RES_islamiyat_marks { get; set; }

        [Display(Name = "Science Marks : ")]
        public int RES_Science_marks { get; set; }

        [Display(Name = "Physics Marks : ")]
        public int RES_Physics_marks { get; set; }

        [Display(Name = "Chemistry Marks : ")]
        public int RES_Chemistry_marks { get; set; }

        [Display(Name = "History Marks : ")]
        public int RES_History_marks { get; set; }

        [Display(Name = "Geography Marks : ")]
        public int RES_Geography_marks { get; set; }

        [Display(Name = "Computer Marks : ")]
        public int RES_Computer_marks { get; set; }

        [Display(Name = "Activity Marks : ")]
        public int RES_activity_marks { get; set; }

        [Display(Name = "Total Marks : ")]
        public int RES_total_marks { get; set; }

        [Display(Name = "Percentage : ")]
        public double RES_percentage { get; set; }

        [Display(Name = "Grade : ")]
        public string RES_grade { get; set; }

        [Display(Name = "Remarks : ")]
        public string RES_REmarks { get; set; }

        [Display(Name = "Class : ")]
        public string ClassName { get; set; }

        [Display(Name = "Section : ")]
        public string ClassSection { get; set; }

        [Display(Name = "Student First name : ")]
        public string StudentFname { get; set; }

        [Display(Name = "Student last name : : ")]
        public string StudentLname { get; set; }


    }
}
