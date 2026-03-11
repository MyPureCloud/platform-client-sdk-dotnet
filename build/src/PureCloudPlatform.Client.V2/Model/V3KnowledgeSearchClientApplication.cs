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
    /// V3KnowledgeSearchClientApplication
    /// </summary>
    [DataContract]
    public partial class V3KnowledgeSearchClientApplication :  IEquatable<V3KnowledgeSearchClientApplication>
    {
        /// <summary>
        /// Application type.
        /// </summary>
        /// <value>Application type.</value>
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
            /// Enum Botflow for "BotFlow"
            /// </summary>
            [EnumMember(Value = "BotFlow")]
            Botflow,
            
            /// <summary>
            /// Enum Smartadvisor for "SmartAdvisor"
            /// </summary>
            [EnumMember(Value = "SmartAdvisor")]
            Smartadvisor
        }
        /// <summary>
        /// Application type.
        /// </summary>
        /// <value>Application type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3KnowledgeSearchClientApplication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V3KnowledgeSearchClientApplication() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3KnowledgeSearchClientApplication" /> class.
        /// </summary>
        /// <param name="Type">Application type. (required).</param>
        /// <param name="BotFlow">Application details when type is BotFlow..</param>
        /// <param name="Assistant">Application details when type is Assistant..</param>
        public V3KnowledgeSearchClientApplication(TypeEnum? Type = null, AddressableEntityRef BotFlow = null, AddressableEntityRef Assistant = null)
        {
            this.Type = Type;
            this.BotFlow = BotFlow;
            this.Assistant = Assistant;
            
        }
        




        /// <summary>
        /// Application details when type is BotFlow.
        /// </summary>
        /// <value>Application details when type is BotFlow.</value>
        [DataMember(Name="botFlow", EmitDefaultValue=false)]
        public AddressableEntityRef BotFlow { get; set; }



        /// <summary>
        /// Application details when type is Assistant.
        /// </summary>
        /// <value>Application details when type is Assistant.</value>
        [DataMember(Name="assistant", EmitDefaultValue=false)]
        public AddressableEntityRef Assistant { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3KnowledgeSearchClientApplication {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BotFlow: ").Append(BotFlow).Append("\n");
            sb.Append("  Assistant: ").Append(Assistant).Append("\n");
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
            return this.Equals(obj as V3KnowledgeSearchClientApplication);
        }

        /// <summary>
        /// Returns true if V3KnowledgeSearchClientApplication instances are equal
        /// </summary>
        /// <param name="other">Instance of V3KnowledgeSearchClientApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3KnowledgeSearchClientApplication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.BotFlow == other.BotFlow ||
                    this.BotFlow != null &&
                    this.BotFlow.Equals(other.BotFlow)
                ) &&
                (
                    this.Assistant == other.Assistant ||
                    this.Assistant != null &&
                    this.Assistant.Equals(other.Assistant)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.BotFlow != null)
                    hash = hash * 59 + this.BotFlow.GetHashCode();

                if (this.Assistant != null)
                    hash = hash * 59 + this.Assistant.GetHashCode();

                return hash;
            }
        }
    }

}
