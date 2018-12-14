using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace adonetCourseProject
{
    public class Employee
    {
        public int Id { get; set; }
        public Byte[] Photo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set;}
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public decimal Reward { get; set; }

        public virtual Account Account { get; set; }

        public int? PositionId { get; set; }
        public Position Position { get; set; }

        [NotMapped]
        public string DateView  => Birthdate.ToLongDateString();

        public static byte[] GetImageBytes(string path)
        {
            FileInfo fi = new FileInfo(path);
            byte[] image;
            
            using (FileStream fs = new FileStream(fi.FullName, FileMode.Open))
            {
                image = new byte[fs.Length];
                fs.Read(image, 0, image.Length);
            }
             return image;
        }



    }

}
