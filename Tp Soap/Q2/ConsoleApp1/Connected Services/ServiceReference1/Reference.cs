﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.MonWebServiceSoap")]
    public interface MonWebServiceSoap {
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément idAgence de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Consulterlesdisponibilites", ReplyAction="*")]
        ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesResponse Consulterlesdisponibilites(ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Consulterlesdisponibilites", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesResponse> ConsulterlesdisponibilitesAsync(ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequest request);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément idAgence de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Effectuerunereservation", ReplyAction="*")]
        ConsoleApp1.ServiceReference1.EffectuerunereservationResponse Effectuerunereservation(ConsoleApp1.ServiceReference1.EffectuerunereservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Effectuerunereservation", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.EffectuerunereservationResponse> EffectuerunereservationAsync(ConsoleApp1.ServiceReference1.EffectuerunereservationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsulterlesdisponibilitesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Consulterlesdisponibilites", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequestBody Body;
        
        public ConsulterlesdisponibilitesRequest() {
        }
        
        public ConsulterlesdisponibilitesRequest(ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConsulterlesdisponibilitesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idAgence;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string mdpAgence;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.DateTime dateDebutReservation;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime dateFinReservation;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int prixMax;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int nombrePersonneHébergés;
        
        public ConsulterlesdisponibilitesRequestBody() {
        }
        
        public ConsulterlesdisponibilitesRequestBody(string idAgence, string mdpAgence, System.DateTime dateDebutReservation, System.DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés) {
            this.idAgence = idAgence;
            this.mdpAgence = mdpAgence;
            this.dateDebutReservation = dateDebutReservation;
            this.dateFinReservation = dateFinReservation;
            this.prixMax = prixMax;
            this.nombrePersonneHébergés = nombrePersonneHébergés;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsulterlesdisponibilitesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsulterlesdisponibilitesResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesResponseBody Body;
        
        public ConsulterlesdisponibilitesResponse() {
        }
        
        public ConsulterlesdisponibilitesResponse(ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConsulterlesdisponibilitesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConsulterlesdisponibilitesResult;
        
        public ConsulterlesdisponibilitesResponseBody() {
        }
        
        public ConsulterlesdisponibilitesResponseBody(string ConsulterlesdisponibilitesResult) {
            this.ConsulterlesdisponibilitesResult = ConsulterlesdisponibilitesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EffectuerunereservationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Effectuerunereservation", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.EffectuerunereservationRequestBody Body;
        
        public EffectuerunereservationRequest() {
        }
        
        public EffectuerunereservationRequest(ConsoleApp1.ServiceReference1.EffectuerunereservationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EffectuerunereservationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idAgence;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string mdp;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string idOffre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string nom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string prenom;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public long numeroCarte;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string dateExpiration;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public long code;
        
        public EffectuerunereservationRequestBody() {
        }
        
        public EffectuerunereservationRequestBody(string idAgence, string mdp, string idOffre, string nom, string prenom, long numeroCarte, string dateExpiration, long code) {
            this.idAgence = idAgence;
            this.mdp = mdp;
            this.idOffre = idOffre;
            this.nom = nom;
            this.prenom = prenom;
            this.numeroCarte = numeroCarte;
            this.dateExpiration = dateExpiration;
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EffectuerunereservationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EffectuerunereservationResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.EffectuerunereservationResponseBody Body;
        
        public EffectuerunereservationResponse() {
        }
        
        public EffectuerunereservationResponse(ConsoleApp1.ServiceReference1.EffectuerunereservationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EffectuerunereservationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EffectuerunereservationResult;
        
        public EffectuerunereservationResponseBody() {
        }
        
        public EffectuerunereservationResponseBody(string EffectuerunereservationResult) {
            this.EffectuerunereservationResult = EffectuerunereservationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MonWebServiceSoapChannel : ConsoleApp1.ServiceReference1.MonWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MonWebServiceSoapClient : System.ServiceModel.ClientBase<ConsoleApp1.ServiceReference1.MonWebServiceSoap>, ConsoleApp1.ServiceReference1.MonWebServiceSoap {
        
        public MonWebServiceSoapClient() {
        }
        
        public MonWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MonWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesResponse ConsoleApp1.ServiceReference1.MonWebServiceSoap.Consulterlesdisponibilites(ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequest request) {
            return base.Channel.Consulterlesdisponibilites(request);
        }
        
        public string Consulterlesdisponibilites(string idAgence, string mdpAgence, System.DateTime dateDebutReservation, System.DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés) {
            ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequest inValue = new ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequestBody();
            inValue.Body.idAgence = idAgence;
            inValue.Body.mdpAgence = mdpAgence;
            inValue.Body.dateDebutReservation = dateDebutReservation;
            inValue.Body.dateFinReservation = dateFinReservation;
            inValue.Body.prixMax = prixMax;
            inValue.Body.nombrePersonneHébergés = nombrePersonneHébergés;
            ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesResponse retVal = ((ConsoleApp1.ServiceReference1.MonWebServiceSoap)(this)).Consulterlesdisponibilites(inValue);
            return retVal.Body.ConsulterlesdisponibilitesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesResponse> ConsoleApp1.ServiceReference1.MonWebServiceSoap.ConsulterlesdisponibilitesAsync(ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequest request) {
            return base.Channel.ConsulterlesdisponibilitesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesResponse> ConsulterlesdisponibilitesAsync(string idAgence, string mdpAgence, System.DateTime dateDebutReservation, System.DateTime dateFinReservation, int prixMax, int nombrePersonneHébergés) {
            ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequest inValue = new ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.ConsulterlesdisponibilitesRequestBody();
            inValue.Body.idAgence = idAgence;
            inValue.Body.mdpAgence = mdpAgence;
            inValue.Body.dateDebutReservation = dateDebutReservation;
            inValue.Body.dateFinReservation = dateFinReservation;
            inValue.Body.prixMax = prixMax;
            inValue.Body.nombrePersonneHébergés = nombrePersonneHébergés;
            return ((ConsoleApp1.ServiceReference1.MonWebServiceSoap)(this)).ConsulterlesdisponibilitesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.ServiceReference1.EffectuerunereservationResponse ConsoleApp1.ServiceReference1.MonWebServiceSoap.Effectuerunereservation(ConsoleApp1.ServiceReference1.EffectuerunereservationRequest request) {
            return base.Channel.Effectuerunereservation(request);
        }
        
        public string Effectuerunereservation(string idAgence, string mdp, string idOffre, string nom, string prenom, long numeroCarte, string dateExpiration, long code) {
            ConsoleApp1.ServiceReference1.EffectuerunereservationRequest inValue = new ConsoleApp1.ServiceReference1.EffectuerunereservationRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.EffectuerunereservationRequestBody();
            inValue.Body.idAgence = idAgence;
            inValue.Body.mdp = mdp;
            inValue.Body.idOffre = idOffre;
            inValue.Body.nom = nom;
            inValue.Body.prenom = prenom;
            inValue.Body.numeroCarte = numeroCarte;
            inValue.Body.dateExpiration = dateExpiration;
            inValue.Body.code = code;
            ConsoleApp1.ServiceReference1.EffectuerunereservationResponse retVal = ((ConsoleApp1.ServiceReference1.MonWebServiceSoap)(this)).Effectuerunereservation(inValue);
            return retVal.Body.EffectuerunereservationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.EffectuerunereservationResponse> ConsoleApp1.ServiceReference1.MonWebServiceSoap.EffectuerunereservationAsync(ConsoleApp1.ServiceReference1.EffectuerunereservationRequest request) {
            return base.Channel.EffectuerunereservationAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.EffectuerunereservationResponse> EffectuerunereservationAsync(string idAgence, string mdp, string idOffre, string nom, string prenom, long numeroCarte, string dateExpiration, long code) {
            ConsoleApp1.ServiceReference1.EffectuerunereservationRequest inValue = new ConsoleApp1.ServiceReference1.EffectuerunereservationRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.EffectuerunereservationRequestBody();
            inValue.Body.idAgence = idAgence;
            inValue.Body.mdp = mdp;
            inValue.Body.idOffre = idOffre;
            inValue.Body.nom = nom;
            inValue.Body.prenom = prenom;
            inValue.Body.numeroCarte = numeroCarte;
            inValue.Body.dateExpiration = dateExpiration;
            inValue.Body.code = code;
            return ((ConsoleApp1.ServiceReference1.MonWebServiceSoap)(this)).EffectuerunereservationAsync(inValue);
        }
    }
}