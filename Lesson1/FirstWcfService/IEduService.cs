using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEduService" in both code and config file together.
    [ServiceContract]
    public interface IEduService
    {
        [OperationContract]
        List<Student> GetAllStudents();

        [OperationContract]
        Student GetStudentById(int id);

		[OperationContract]
		void AddNewStudent(Student S);

		[OperationContract]
		int Addition(int x, int y);
    }
}
