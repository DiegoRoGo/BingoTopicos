﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bingo.BingoWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfBingo")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Board", Namespace="http://schemas.datacontract.org/2004/07/WcfBingo.Dominio.Modelos")]
    [System.SerializableAttribute()]
    public partial class Board : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Bingo.BingoWCF.Cell[][] GameBoardField;
        
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
        public Bingo.BingoWCF.Cell[][] GameBoard {
            get {
                return this.GameBoardField;
            }
            set {
                if ((object.ReferenceEquals(this.GameBoardField, value) != true)) {
                    this.GameBoardField = value;
                    this.RaisePropertyChanged("GameBoard");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cell", Namespace="http://schemas.datacontract.org/2004/07/WcfBingo.Dominio.Modelos")]
    [System.SerializableAttribute()]
    public partial class Cell : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsMarkedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValueField;
        
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
        public bool IsMarked {
            get {
                return this.IsMarkedField;
            }
            set {
                if ((this.IsMarkedField.Equals(value) != true)) {
                    this.IsMarkedField = value;
                    this.RaisePropertyChanged("IsMarked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BingoWCF.IServiceBingo")]
    public interface IServiceBingo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GetData", ReplyAction="http://tempuri.org/IServiceBingo/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GetData", ReplyAction="http://tempuri.org/IServiceBingo/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceBingo/GetDataUsingDataContractResponse")]
        Bingo.BingoWCF.CompositeType GetDataUsingDataContract(Bingo.BingoWCF.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceBingo/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Bingo.BingoWCF.CompositeType> GetDataUsingDataContractAsync(Bingo.BingoWCF.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/MarkBoards", ReplyAction="http://tempuri.org/IServiceBingo/MarkBoardsResponse")]
        void MarkBoards(Bingo.BingoWCF.Board[] Players, int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/MarkBoards", ReplyAction="http://tempuri.org/IServiceBingo/MarkBoardsResponse")]
        System.Threading.Tasks.Task MarkBoardsAsync(Bingo.BingoWCF.Board[] Players, int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GetWinningBoards", ReplyAction="http://tempuri.org/IServiceBingo/GetWinningBoardsResponse")]
        Bingo.BingoWCF.Board[] GetWinningBoards(Bingo.BingoWCF.Board[] players, Bingo.BingoWCF.Board winningPattern);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GetWinningBoards", ReplyAction="http://tempuri.org/IServiceBingo/GetWinningBoardsResponse")]
        System.Threading.Tasks.Task<Bingo.BingoWCF.Board[]> GetWinningBoardsAsync(Bingo.BingoWCF.Board[] players, Bingo.BingoWCF.Board winningPattern);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GenerateBoards", ReplyAction="http://tempuri.org/IServiceBingo/GenerateBoardsResponse")]
        Bingo.BingoWCF.Board[] GenerateBoards(int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GenerateBoards", ReplyAction="http://tempuri.org/IServiceBingo/GenerateBoardsResponse")]
        System.Threading.Tasks.Task<Bingo.BingoWCF.Board[]> GenerateBoardsAsync(int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GenerateWinningPattern", ReplyAction="http://tempuri.org/IServiceBingo/GenerateWinningPatternResponse")]
        Bingo.BingoWCF.Board GenerateWinningPattern();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBingo/GenerateWinningPattern", ReplyAction="http://tempuri.org/IServiceBingo/GenerateWinningPatternResponse")]
        System.Threading.Tasks.Task<Bingo.BingoWCF.Board> GenerateWinningPatternAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBingoChannel : Bingo.BingoWCF.IServiceBingo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBingoClient : System.ServiceModel.ClientBase<Bingo.BingoWCF.IServiceBingo>, Bingo.BingoWCF.IServiceBingo {
        
        public ServiceBingoClient() {
        }
        
        public ServiceBingoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBingoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBingoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBingoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Bingo.BingoWCF.CompositeType GetDataUsingDataContract(Bingo.BingoWCF.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Bingo.BingoWCF.CompositeType> GetDataUsingDataContractAsync(Bingo.BingoWCF.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public void MarkBoards(Bingo.BingoWCF.Board[] Players, int number) {
            base.Channel.MarkBoards(Players, number);
        }
        
        public System.Threading.Tasks.Task MarkBoardsAsync(Bingo.BingoWCF.Board[] Players, int number) {
            return base.Channel.MarkBoardsAsync(Players, number);
        }
        
        public Bingo.BingoWCF.Board[] GetWinningBoards(Bingo.BingoWCF.Board[] players, Bingo.BingoWCF.Board winningPattern) {
            return base.Channel.GetWinningBoards(players, winningPattern);
        }
        
        public System.Threading.Tasks.Task<Bingo.BingoWCF.Board[]> GetWinningBoardsAsync(Bingo.BingoWCF.Board[] players, Bingo.BingoWCF.Board winningPattern) {
            return base.Channel.GetWinningBoardsAsync(players, winningPattern);
        }
        
        public Bingo.BingoWCF.Board[] GenerateBoards(int amount) {
            return base.Channel.GenerateBoards(amount);
        }
        
        public System.Threading.Tasks.Task<Bingo.BingoWCF.Board[]> GenerateBoardsAsync(int amount) {
            return base.Channel.GenerateBoardsAsync(amount);
        }
        
        public Bingo.BingoWCF.Board GenerateWinningPattern() {
            return base.Channel.GenerateWinningPattern();
        }
        
        public System.Threading.Tasks.Task<Bingo.BingoWCF.Board> GenerateWinningPatternAsync() {
            return base.Channel.GenerateWinningPatternAsync();
        }
    }
}
