﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.FilmReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FilmReference.IFilm")]
    public interface IFilm {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/GetFilms", ReplyAction="http://tempuri.org/IFilm/GetFilmsResponse")]
        ApplicationService.DTOs.FilmDTO[] GetFilms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/GetFilms", ReplyAction="http://tempuri.org/IFilm/GetFilmsResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.FilmDTO[]> GetFilmsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/GetFilmByID", ReplyAction="http://tempuri.org/IFilm/GetFilmByIDResponse")]
        ApplicationService.DTOs.FilmDTO GetFilmByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/GetFilmByID", ReplyAction="http://tempuri.org/IFilm/GetFilmByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.FilmDTO> GetFilmByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/PostFilm", ReplyAction="http://tempuri.org/IFilm/PostFilmResponse")]
        string PostFilm(ApplicationService.DTOs.FilmDTO filmDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/PostFilm", ReplyAction="http://tempuri.org/IFilm/PostFilmResponse")]
        System.Threading.Tasks.Task<string> PostFilmAsync(ApplicationService.DTOs.FilmDTO filmDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/PutFilm", ReplyAction="http://tempuri.org/IFilm/PutFilmResponse")]
        string PutFilm(ApplicationService.DTOs.FilmDTO filmDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/PutFilm", ReplyAction="http://tempuri.org/IFilm/PutFilmResponse")]
        System.Threading.Tasks.Task<string> PutFilmAsync(ApplicationService.DTOs.FilmDTO filmDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/DeleteFilm", ReplyAction="http://tempuri.org/IFilm/DeleteFilmResponse")]
        string DeleteFilm(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/DeleteFilm", ReplyAction="http://tempuri.org/IFilm/DeleteFilmResponse")]
        System.Threading.Tasks.Task<string> DeleteFilmAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/Message", ReplyAction="http://tempuri.org/IFilm/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilm/Message", ReplyAction="http://tempuri.org/IFilm/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFilmChannel : Website.FilmReference.IFilm, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FilmClient : System.ServiceModel.ClientBase<Website.FilmReference.IFilm>, Website.FilmReference.IFilm {
        
        public FilmClient() {
        }
        
        public FilmClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FilmClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FilmClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FilmClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ApplicationService.DTOs.FilmDTO[] GetFilms() {
            return base.Channel.GetFilms();
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.FilmDTO[]> GetFilmsAsync() {
            return base.Channel.GetFilmsAsync();
        }
        
        public ApplicationService.DTOs.FilmDTO GetFilmByID(int id) {
            return base.Channel.GetFilmByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.FilmDTO> GetFilmByIDAsync(int id) {
            return base.Channel.GetFilmByIDAsync(id);
        }
        
        public string PostFilm(ApplicationService.DTOs.FilmDTO filmDto) {
            return base.Channel.PostFilm(filmDto);
        }
        
        public System.Threading.Tasks.Task<string> PostFilmAsync(ApplicationService.DTOs.FilmDTO filmDto) {
            return base.Channel.PostFilmAsync(filmDto);
        }
        
        public string PutFilm(ApplicationService.DTOs.FilmDTO filmDto) {
            return base.Channel.PutFilm(filmDto);
        }
        
        public System.Threading.Tasks.Task<string> PutFilmAsync(ApplicationService.DTOs.FilmDTO filmDto) {
            return base.Channel.PutFilmAsync(filmDto);
        }
        
        public string DeleteFilm(int id) {
            return base.Channel.DeleteFilm(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteFilmAsync(int id) {
            return base.Channel.DeleteFilmAsync(id);
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
    }
}
