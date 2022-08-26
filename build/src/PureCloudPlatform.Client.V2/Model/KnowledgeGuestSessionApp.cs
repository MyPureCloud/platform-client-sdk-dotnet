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
    /// KnowledgeGuestSessionApp
    /// </summary>
    [DataContract]
    public partial class KnowledgeGuestSessionApp :  IEquatable<KnowledgeGuestSessionApp>
    {
        /// <summary>
        /// App type.
        /// </summary>
        /// <value>App type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Messengerknowledgeapp for "MessengerKnowledgeApp"
            /// </summary>
            [EnumMember(Value = "MessengerKnowledgeApp")]
            Messengerknowledgeapp,
            
            /// <summary>
            /// Enum Supportcenter for "SupportCenter"
            /// </summary>
            [EnumMember(Value = "SupportCenter")]
            Supportcenter
        }
        /// <summary>
        /// App type.
        /// </summary>
        /// <value>App type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeGuestSessionApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeGuestSessionApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeGuestSessionApp" /> class.
        /// </summary>
        /// <param name="DeploymentId">App deployment ID. (required).</param>
        /// <param name="Type">App type. (required).</param>
        public KnowledgeGuestSessionApp(string DeploymentId = null, TypeEnum? Type = null)
        {
            this.DeploymentId = DeploymentId;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// App deployment ID.
        /// </summary>
        /// <value>App deployment ID.</value>
        [DataMember(Name="deploymentId", EmitDefaultValue=false)]
        public string DeploymentId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeGuestSessionApp {\n");

            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as KnowledgeGuestSessionApp);
        }

        /// <summary>
        /// Returns true if KnowledgeGuestSessionApp instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeGuestSessionApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeGuestSessionApp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DeploymentId == other.DeploymentId ||
                    this.DeploymentId != null &&
                    this.DeploymentId.Equals(other.DeploymentId)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.DeploymentId != null)
                    hash = hash * 59 + this.DeploymentId.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
