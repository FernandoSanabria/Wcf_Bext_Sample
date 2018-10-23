using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf_Bext_Sample
{
        
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "GetDeptos")]
        IEnumerable<Department> GetDep();


        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        UriTemplate = "InsertDep")]
        void InsertDep(Department pobj);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        UriTemplate = "UpdateDepto")]
        void UpdateDep(Department pobj);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped,     
        UriTemplate = "DeleteDepto")]
        void DeleteDep(string Id);

    }

    [DataContract]
    public class Department
    {

        [DataMember]
        [Key]
        [Required]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string Departamento { get; set; }
        [DataMember]
        [Required]
        public string Capital { get; set; }
    }
}
