using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group5
{
    public static class FormData
    {
        public static string StudentNo { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static string Surname { get; set; }
        public static string Email { get; set; }
        public static string ContactNo { get; set; }
        public static string Course { get; set; }

     
        public static string BirthPlace { get; set; }
        public static string LastSemYear { get; set; }
        public static DateTime BirthDate { get; set; }

        public static bool ClearFieldsFlag { get; set; } = false;
        public static string HomeAddress { get; set; }
        public static string LastSchoolAddress { get; set; }
        public static string LastSchoolName { get; set; }
        public static string StudentStatus { get; set; }
        public static string Purpose { get; set; }
        public static string RequestFor { get; set; }

        public static void Clear()
        {
            StudentNo = "";
            HomeAddress = "";
            LastSchoolAddress = "";
            LastSchoolName = "";
            StudentStatus = "";
            Purpose = "";
            RequestFor = "";
            PickupDate = DateTime.MinValue;
        }
        public static DateTime PickupDate { get; set; } = DateTime.MinValue;

       
    }
}
