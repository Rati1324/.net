using FirstWcfService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FirstWcfService
{   
    [ServiceContract]
    public interface IEduService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetAllStudents", ResponseFormat = WebMessageFormat.Json)]
        List<StudentDTO> GetAllStudents();

        [OperationContract]
        [WebGet(UriTemplate = "/GetStudentById/{id}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        StudentDTO GetStudentById(string id);

        [OperationContract]
		[WebInvoke(UriTemplate = "/AddNewStudent", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]  
        Result AddNewStudent(StudentDTO student);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateStudent", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Result UpdateStudent(StudentDTO student);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/DeleteStudent/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Result DeleteStudent(string id);
    }
}
