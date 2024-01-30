﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Member
    {
        public Member()
        {
            RegisterDate = DateTime.Now;
        }
        public int Id { get; set; }


        [Required(ErrorMessage = "اسم الزامی است")]
        [DataType(DataType.Text)]
        [DisplayName("اسم")]
        public string Name { get; set; }


        [Required(ErrorMessage = "نام خانوادگی الزامی است")]
        [DataType(DataType.Text)]
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }


        public DateTime RegisterDate { get; set; }


        [Required(ErrorMessage = "تاریخ تولد الزامی است")]
        [DisplayName("تاریخ تولد")]
        [DataType(DataType.Date, ErrorMessage = "تاریخ اشتباه وارد شده است")]
        public DateTime BirthDay { get; set; }


        [Required(ErrorMessage = "کد ملی الزامی است")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "کد ملی باید شامل 10 رقم باشد")]
        [DisplayName("کد ملی")]
        public int NationalCode { get; set; }


        [Required(ErrorMessage = "شماره همراه الزامی است")]
        [DisplayName("شماره همراه")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [DisplayName("جنسیت")]
        public GenderEnum Gender { get; set; }


        [DisplayName("نوع عضویت")]
        public MemberShip MemType { get; set; }
    }
}
