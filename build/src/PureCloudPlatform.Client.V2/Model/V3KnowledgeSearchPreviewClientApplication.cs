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
    /// V3KnowledgeSearchPreviewClientApplication
    /// </summary>
    [DataContract]
    public partial class V3KnowledgeSearchPreviewClientApplication :  IEquatable<V3KnowledgeSearchPreviewClientApplication>
    {
        /// <summary>
        /// The application type to simulate for the preview.
        /// </summary>
        /// <value>The application type to simulate for the preview.</value>
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
        /// The application type to simulate for the preview.
        /// </summary>
        /// <value>The application type to simulate for the preview.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3KnowledgeSearchPreviewClientApplication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V3KnowledgeSearchPreviewClientApplication() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3KnowledgeSearchPreviewClientApplication" /> class.
        /// </summary>
        /// <param name="Type">The application type to simulate for the preview. (required).</param>
        public V3KnowledgeSearchPreviewClientApplication(TypeEnum? Type = null)
        {
            this.Type = Type;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3KnowledgeSearchPreviewClientApplication {\n");

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
            return this.Equals(obj as V3KnowledgeSearchPreviewClientApplication);
        }

        /// <summary>
        /// Returns true if V3KnowledgeSearchPreviewClientApplication instances are equal
        /// </summary>
        /// <param name="other">Instance of V3KnowledgeSearchPreviewClientApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3KnowledgeSearchPreviewClientApplication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
