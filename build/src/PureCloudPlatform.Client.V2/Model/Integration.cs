using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Details for an Integration
    /// </summary>
    [DataContract]
    public partial class Integration :  IEquatable<Integration>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Configured state of the integration.
        /// </summary>
        /// <value>Configured state of the integration.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum IntendedStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enabled for "ENABLED"
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            Enabled,
            
            /// <summary>
            /// Enum Disabled for "DISABLED"
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            Disabled,
            
            /// <summary>
            /// Enum Deleted for "DELETED"
            /// </summary>
            [EnumMember(Value = "DELETED")]
            Deleted
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Configured state of the integration.
        /// </summary>
        /// <value>Configured state of the integration.</value>
        [DataMember(Name="intendedState", EmitDefaultValue=false)]
        public IntendedStateEnum? IntendedState { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Integration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Integration() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Integration" /> class.
        /// </summary>
        /// <param name="IntegrationType">Type of the integration.</param>
        /// <param name="IntendedState">Configured state of the integration. (required).</param>
        /// <param name="Config">Configuration information for the integration..</param>
        /// <param name="ReportedState">Last reported status of the integration..</param>
        /// <param name="Attributes">Read-only attributes for the integration..</param>
        public Integration(IntegrationType IntegrationType = null, IntendedStateEnum? IntendedState = null, IntegrationConfigurationInfo Config = null, IntegrationStatusInfo ReportedState = null, Dictionary<string, string> Attributes = null)
        {
            this.IntegrationType = IntegrationType;
            this.IntendedState = IntendedState;
            this.Config = Config;
            this.ReportedState = ReportedState;
            this.Attributes = Attributes;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the integration, used to distinguish this integration from others of the same type.
        /// </summary>
        /// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        /// <summary>
        /// Type of the integration
        /// </summary>
        /// <value>Type of the integration</value>
        [DataMember(Name="integrationType", EmitDefaultValue=false)]
        public IntegrationType IntegrationType { get; set; }
        
        
        
        /// <summary>
        /// Notes about the integration.
        /// </summary>
        /// <value>Notes about the integration.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Configuration information for the integration.
        /// </summary>
        /// <value>Configuration information for the integration.</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public IntegrationConfigurationInfo Config { get; set; }
        
        
        
        /// <summary>
        /// Last reported status of the integration.
        /// </summary>
        /// <value>Last reported status of the integration.</value>
        [DataMember(Name="reportedState", EmitDefaultValue=false)]
        public IntegrationStatusInfo ReportedState { get; set; }
        
        
        
        /// <summary>
        /// Read-only attributes for the integration.
        /// </summary>
        /// <value>Read-only attributes for the integration.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Integration {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  IntendedState: ").Append(IntendedState).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  ReportedState: ").Append(ReportedState).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Integration);
        }

        /// <summary>
        /// Returns true if Integration instances are equal
        /// </summary>
        /// <param name="other">Instance of Integration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Integration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.IntegrationType == other.IntegrationType ||
                    this.IntegrationType != null &&
                    this.IntegrationType.Equals(other.IntegrationType)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.IntendedState == other.IntendedState ||
                    this.IntendedState != null &&
                    this.IntendedState.Equals(other.IntendedState)
                ) &&
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                ) &&
                (
                    this.ReportedState == other.ReportedState ||
                    this.ReportedState != null &&
                    this.ReportedState.Equals(other.ReportedState)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.IntegrationType != null)
                    hash = hash * 59 + this.IntegrationType.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.IntendedState != null)
                    hash = hash * 59 + this.IntendedState.GetHashCode();
                
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                
                if (this.ReportedState != null)
                    hash = hash * 59 + this.ReportedState.GetHashCode();
                
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
