﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.LocationReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LocationDTO", Namespace="http://schemas.datacontract.org/2004/07/ApplicationService.DTOs")]
    [System.SerializableAttribute()]
    public partial class LocationDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClimateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Surface_waterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idLField;
        
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
        public string Climate {
            get {
                return this.ClimateField;
            }
            set {
                if ((object.ReferenceEquals(this.ClimateField, value) != true)) {
                    this.ClimateField = value;
                    this.RaisePropertyChanged("Climate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Surface_water {
            get {
                return this.Surface_waterField;
            }
            set {
                if ((this.Surface_waterField.Equals(value) != true)) {
                    this.Surface_waterField = value;
                    this.RaisePropertyChanged("Surface_water");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idL {
            get {
                return this.idLField;
            }
            set {
                if ((this.idLField.Equals(value) != true)) {
                    this.idLField = value;
                    this.RaisePropertyChanged("idL");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LocationReference.ILocation")]
    public interface ILocation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/GetLocations", ReplyAction="http://tempuri.org/ILocation/GetLocationsResponse")]
        Website.LocationReference.LocationDTO[] GetLocations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/GetLocations", ReplyAction="http://tempuri.org/ILocation/GetLocationsResponse")]
        System.Threading.Tasks.Task<Website.LocationReference.LocationDTO[]> GetLocationsAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ILocation/GetLocationByID", ReplyAction = "http://tempuri.org/ILocation/GetLocationByIDResponse")]
        Website.LocationReference.LocationDTO GetLocationByID(int id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ILocation/GetLocationByID", ReplyAction = "http://tempuri.org/ILocation/GetLocationByIDResponse")]
        System.Threading.Tasks.Task<Website.LocationReference.LocationDTO> GetLocationByIDAsync(int id);


        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/PostLocation", ReplyAction="http://tempuri.org/ILocation/PostLocationResponse")]
        string PostLocation(Website.LocationReference.LocationDTO locationDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/PostLocation", ReplyAction="http://tempuri.org/ILocation/PostLocationResponse")]
        System.Threading.Tasks.Task<string> PostLocationAsync(Website.LocationReference.LocationDTO locationDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/PutLocation", ReplyAction="http://tempuri.org/ILocation/PutLocationResponse")]
        string PutLocation(Website.LocationReference.LocationDTO locationDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/PutLocation", ReplyAction="http://tempuri.org/ILocation/PutLocationResponse")]
        System.Threading.Tasks.Task<string> PutLocationAsync(Website.LocationReference.LocationDTO locationDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/DeleteLocation", ReplyAction="http://tempuri.org/ILocation/DeleteLocationResponse")]
        string DeleteLocation(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/DeleteLocation", ReplyAction="http://tempuri.org/ILocation/DeleteLocationResponse")]
        System.Threading.Tasks.Task<string> DeleteLocationAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/Message", ReplyAction="http://tempuri.org/ILocation/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocation/Message", ReplyAction="http://tempuri.org/ILocation/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILocationChannel : Website.LocationReference.ILocation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LocationClient : System.ServiceModel.ClientBase<Website.LocationReference.ILocation>, Website.LocationReference.ILocation {
        
        public LocationClient() {
        }
        
        public LocationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LocationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Website.LocationReference.LocationDTO[] GetLocations() {
            return base.Channel.GetLocations();
        }
        
        public System.Threading.Tasks.Task<Website.LocationReference.LocationDTO[]> GetLocationsAsync() {
            return base.Channel.GetLocationsAsync();
        }
        public Website.LocationReference.LocationDTO GetLocationByID(int id)
        {
            return base.Channel.GetLocationByID(id);
        }

        public System.Threading.Tasks.Task<Website.LocationReference.LocationDTO> GetLocationByIDAsync(int id)
        {
            return base.Channel.GetLocationByIDAsync(id);
        }
        public string PostLocation(Website.LocationReference.LocationDTO locationDto) {
            return base.Channel.PostLocation(locationDto);
        }
        
        public System.Threading.Tasks.Task<string> PostLocationAsync(Website.LocationReference.LocationDTO locationDto) {
            return base.Channel.PostLocationAsync(locationDto);
        }
        
        public string PutLocation(Website.LocationReference.LocationDTO locationDto) {
            return base.Channel.PutLocation(locationDto);
        }
        
        public System.Threading.Tasks.Task<string> PutLocationAsync(Website.LocationReference.LocationDTO locationDto) {
            return base.Channel.PutLocationAsync(locationDto);
        }
        
        public string DeleteLocation(int id) {
            return base.Channel.DeleteLocation(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteLocationAsync(int id) {
            return base.Channel.DeleteLocationAsync(id);
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
    }
}