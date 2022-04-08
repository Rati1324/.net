using FirstWcfService.DataContracts;
using FirstWcfService.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWcfService.BL
{
    static public class StudentManagement
    {
        public static List<StudentDTO> GetAllStudents()
        {
            using (EduModel db = new EduModel())
            {
				return db.Students.Select(i => new StudentDTO {
					Id = i.Id,
					FirstName = i.FirstName,
					LastName = i.LastName,
					GPA = (float)i.GPA,
					BirthDate = i.BirthDate
				}).ToList();
            }
        }

        public static StudentDTO GetStudentById(string id)
        {
            using (EduModel db = new EduModel())
            {
                int code;
                if (!int.TryParse(id, out code))
                    throw new Exception("სტუდენტის უნიკალური კოდი არავალიდურია!");

				return db.Students.Where(i => i.Id == code).Select(i => new StudentDTO {
					Id = i.Id,
					FirstName = i.FirstName,
					LastName = i.LastName,
					GPA = (float)i.GPA,
					BirthDate = i.BirthDate
				}).FirstOrDefault();
            }
        }

        public static Result AddNewStudent(StudentDTO student)
        {
            try
            {
                using (EduModel db = new EduModel())
                {
                    Student st = new Student();
                    st.FirstName = student.FirstName;
                    st.LastName = student.LastName;
                    st.BirthDate = student.BirthDate;
                    st.GPA = student.GPA;
                    db.Students.Add(st);
                    db.SaveChanges();
                    return new Result {ErrorMessage = student.FirstName.ToString()};
                }
            }
            catch (Exception ex)
            {                
                return new Result { IsSuccess= false };
            }
        }

        public static Result UpdateStudent(StudentDTO student)
        {
            try
            {
                using (EduModel db = new EduModel())
                {
                    if (!db.Students.Any(i => i.Id == student.Id))
                        throw new Exception($"სტუდენტი უნიკალური ნომერით {student.Id} ვერ მოიძებნა!");
                    
                    Student st = db.Students.Where(i => i.Id == student.Id).First();
                    st.BirthDate = student.BirthDate;
                    st.FirstName = student.FirstName;
                    st.LastName = student.LastName;
                    st.GPA = student.GPA;                    
                    db.SaveChanges();

                    return new Result { IsSuccess = true };
                }
            }
            catch (Exception ex)
            {
                return new Result { IsSuccess = false, ErrorMessage = "სტუდენტის რედაქტირება წარუმატებელია! " };
            }
        }

        public static Result DeleteStudent(string id)
        {
            try
            {
                using (EduModel db = new EduModel())
                {
                    int code;
                    if (!int.TryParse(id, out code))
                        throw new Exception("სტუდენტის უნიკალური კოდი არავალიდურია!");

                    if (!db.Students.Any(i => i.Id == code))
                        throw new Exception($"სტუდენტი უნიკალური ნომერით {id} ვერ მოიძებნა!");

                    Student st = db.Students.Where(i => i.Id == code).First();
                    db.Students.Remove(st);
                    db.SaveChanges();

                    return new Result { IsSuccess = true };
                }
            }
            catch (Exception ex)
            {
                return new Result { IsSuccess = false, ErrorMessage = "სტუდენტის წაშლა წარუმატებელია! " };
            }
        }
    }
}