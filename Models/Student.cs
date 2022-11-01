using System.ComponentModel.DataAnnotations;
namespace StudentManagementApp.Models{
    public class Student{
         [Key]
        public int Sid{get;set;}
        public string Sname{get;set;}
        public string grade{get;set;}
        public string email{get;set;}
    }
}