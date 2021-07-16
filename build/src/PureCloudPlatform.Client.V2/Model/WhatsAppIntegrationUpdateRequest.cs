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
    /// WhatsAppIntegrationUpdateRequest
    /// </summary>
    [DataContract]
    public partial class WhatsAppIntegrationUpdateRequest :  IEquatable<WhatsAppIntegrationUpdateRequest>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// The action used to activate and then confirm a WhatsApp Integration.
        /// </summary>
        /// <value>The action used to activate and then confirm a WhatsApp Integration.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activate for "Activate"
            /// </summary>
            [EnumMember(Value = "Activate")]
            Activate,
            
            /// <summary>
            /// Enum Confirm for "Confirm"
            /// </summary>
            [EnumMember(Value = "Confirm")]
            Confirm
        }
        
        
        
        
        /// <summary>
        /// The authentication method used to confirm a WhatsApp Integration activation. If action is set to Activate, then authenticationMethod is a required field. 
        /// </summary>
        /// <value>The authentication method used to confirm a WhatsApp Integration activation. If action is set to Activate, then authenticationMethod is a required field. </value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AuthenticationMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "Sms"
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The action used to activate and then confirm a WhatsApp Integration.
        /// </summary>
        /// <value>The action used to activate and then confirm a WhatsApp Integration.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        
        
        
        /// <summary>
        /// The authentication method used to confirm a WhatsApp Integration activation. If action is set to Activate, then authenticationMethod is a required field. 
        /// </summary>
        /// <value>The authentication method used to confirm a WhatsApp Integration activation. If action is set to Activate, then authenticationMethod is a required field. </value>
        [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
        public AuthenticationMethodEnum? AuthenticationMethod { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppIntegrationUpdateRequest" /> class.
        /// </summary>
        /// <param name="Action">The action used to activate and then confirm a WhatsApp Integration..</param>
        /// <param name="AuthenticationMethod">The authentication method used to confirm a WhatsApp Integration activation. If action is set to Activate, then authenticationMethod is a required field. .</param>
        /// <param name="ConfirmationCode">The confirmation code sent by Whatsapp to you during the activation step. If action is set to Confirm, then confirmationCode is a required field..</param>
        public WhatsAppIntegrationUpdateRequest(ActionEnum? Action = null, AuthenticationMethodEnum? AuthenticationMethod = null, string ConfirmationCode = null)
        {
            this.Action = Action;
            this.AuthenticationMethod = AuthenticationMethod;
            this.ConfirmationCode = ConfirmationCode;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// WhatsApp Integration name
        /// </summary>
        /// <value>WhatsApp Integration name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The confirmation code sent by Whatsapp to you during the activation step. If action is set to Confirm, then confirmationCode is a required field.
        /// </summary>
        /// <value>The confirmation code sent by Whatsapp to you during the activation step. If action is set to Confirm, then confirmationCode is a required field.</value>
        [DataMember(Name="confirmationCode", EmitDefaultValue=false)]
        public string ConfirmationCode { get; set; }
        
        
        
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
            sb.Append("class WhatsAppIntegrationUpdateRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
            sb.Append("  ConfirmationCode: ").Append(ConfirmationCode).Append("\n");
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
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WhatsAppIntegrationUpdateRequest);
        }

        /// <summary>
        /// Returns true if WhatsAppIntegrationUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppIntegrationUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppIntegrationUpdateRequest other)
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
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.AuthenticationMethod == other.AuthenticationMethod ||
                    this.AuthenticationMethod != null &&
                    this.AuthenticationMethod.Equals(other.AuthenticationMethod)
                ) &&
                (
                    this.ConfirmationCode == other.ConfirmationCode ||
                    this.ConfirmationCode != null &&
                    this.ConfirmationCode.Equals(other.ConfirmationCode)
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
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.AuthenticationMethod != null)
                    hash = hash * 59 + this.AuthenticationMethod.GetHashCode();
                
                if (this.ConfirmationCode != null)
                    hash = hash * 59 + this.ConfirmationCode.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
