﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsClientApp.ServiceEdu {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/FirstWcfService")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float GPAField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float GPA {
            get {
                return this.GPAField;
            }
            set {
                if ((this.GPAField.Equals(value) != true)) {
                    this.GPAField = value;
                    this.RaisePropertyChanged("GPA");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceEdu.IEduService")]
    public interface IEduService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEduService/GetAllStudents", ReplyAction="http://tempuri.org/IEduService/GetAllStudentsResponse")]
        WindowsFormsClientApp.ServiceEdu.Student[] GetAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEduService/GetAllStudents", ReplyAction="http://tempuri.org/IEduService/GetAllStudentsResponse")]
        System.Threading.Tasks.Task<WindowsFormsClientApp.ServiceEdu.Student[]> GetAllStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEduService/GetStudentById", ReplyAction="http://tempuri.org/IEduService/GetStudentByIdResponse")]
        WindowsFormsClientApp.ServiceEdu.Student GetStudentById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEduService/GetStudentById", ReplyAction="http://tempuri.org/IEduService/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<WindowsFormsClientApp.ServiceEdu.Student> GetStudentByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEduService/AddNewStudent", ReplyAction="http://tempuri.org/IEduService/AddNewStudentResponse")]
        void AddNewStudent(WindowsFormsClientApp.ServiceEdu.Student S);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEduService/AddNewStudent", ReplyAction="http://tempuri.org/IEduService/AddNewStudentResponse")]
        System.Threading.Tasks.Task AddNewStudentAsync(WindowsFormsClientApp.ServiceEdu.Student S);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEduServiceChannel : WindowsFormsClientApp.ServiceEdu.IEduService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EduServiceClient : System.ServiceModel.ClientBase<WindowsFormsClientApp.ServiceEdu.IEduService>, WindowsFormsClientApp.ServiceEdu.IEduService {
        
        public EduServiceClient() {
        }
        
        public EduServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EduServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EduServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EduServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsClientApp.ServiceEdu.Student[] GetAllStudents() {
            return base.Channel.GetAllStudents();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClientApp.ServiceEdu.Student[]> GetAllStudentsAsync() {
            return base.Channel.GetAllStudentsAsync();
        }
        
        public WindowsFormsClientApp.ServiceEdu.Student GetStudentById(int id) {
            return base.Channel.GetStudentById(id);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClientApp.ServiceEdu.Student> GetStudentByIdAsync(int id) {
            return base.Channel.GetStudentByIdAsync(id);
        }
        
        public void AddNewStudent(WindowsFormsClientApp.ServiceEdu.Student S) {
            base.Channel.AddNewStudent(S);
        }
        
        public System.Threading.Tasks.Task AddNewStudentAsync(WindowsFormsClientApp.ServiceEdu.Student S) {
            return base.Channel.AddNewStudentAsync(S);
        }
    }
}
