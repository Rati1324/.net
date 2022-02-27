using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FirstWcfService.EF;

namespace FirstWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EduService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EduService.svc or EduService.svc.cs at the Solution Explorer and start debugging.
    public class EduService : IEduService
    {
        public List<Student> GetAllStudents()
        {
            using(EduModel db = new EduModel())
            {
                return db.Students.Select(i => new Student
                {
                    Id= i.Id,
                    FullName = i.FirstName+" "+i.LastName,
                    GPA= (float)i.GPA
                }).ToList();
            }
        }

        public Student GetStudentById(int id)
        {
            using (EduModel db = new EduModel())
            {
                return db.Students.Where(i => i.Id == id).Select(i => new Student
                {
                    Id = i.Id,
                    FullName = i.FirstName + " " + i.LastName,
                    GPA = (float)i.GPA
                }).FirstOrDefault();
            }
        }
    }
}
