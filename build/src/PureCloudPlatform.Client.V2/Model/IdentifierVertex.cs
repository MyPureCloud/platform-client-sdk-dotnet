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
    /// IdentifierVertex
    /// </summary>
    [DataContract]
    public partial class IdentifierVertex :  IEquatable<IdentifierVertex>
    {
        /// <summary>
        /// The normalized type of this identifier
        /// </summary>
        /// <value>The normalized type of this identifier</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NormalizedTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Externalid for "ExternalId"
            /// </summary>
            [EnumMember(Value = "ExternalId")]
            Externalid,
            
            /// <summary>
            /// Enum Twitterid for "TwitterId"
            /// </summary>
            [EnumMember(Value = "TwitterId")]
            Twitterid,
            
            /// <summary>
            /// Enum Twitterhandle for "TwitterHandle"
            /// </summary>
            [EnumMember(Value = "TwitterHandle")]
            Twitterhandle,
            
            /// <summary>
            /// Enum Facebookid for "FacebookId"
            /// </summary>
            [EnumMember(Value = "FacebookId")]
            Facebookid,
            
            /// <summary>
            /// Enum Instagramid for "InstagramId"
            /// </summary>
            [EnumMember(Value = "InstagramId")]
            Instagramid,
            
            /// <summary>
            /// Enum Instagramhandle for "InstagramHandle"
            /// </summary>
            [EnumMember(Value = "InstagramHandle")]
            Instagramhandle
        }
        /// <summary>
        /// The normalized type of this identifier
        /// </summary>
        /// <value>The normalized type of this identifier</value>
        [DataMember(Name="normalizedType", EmitDefaultValue=false)]
        public NormalizedTypeEnum? NormalizedType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentifierVertex" /> class.
        /// </summary>
        public IdentifierVertex()
        {
            
        }
        


        /// <summary>
        /// The ID of the vertex in the cluster graph. This ID is only unique within the graph!
        /// </summary>
        /// <value>The ID of the vertex in the cluster graph. This ID is only unique within the graph!</value>
        [DataMember(Name="vertexId", EmitDefaultValue=false)]
        public string VertexId { get; private set; }





        /// <summary>
        /// The normalized value of this identifier
        /// </summary>
        /// <value>The normalized value of this identifier</value>
        [DataMember(Name="normalizedValue", EmitDefaultValue=false)]
        public string NormalizedValue { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentifierVertex {\n");

            sb.Append("  VertexId: ").Append(VertexId).Append("\n");
            sb.Append("  NormalizedType: ").Append(NormalizedType).Append("\n");
            sb.Append("  NormalizedValue: ").Append(NormalizedValue).Append("\n");
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
            return this.Equals(obj as IdentifierVertex);
        }

        /// <summary>
        /// Returns true if IdentifierVertex instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentifierVertex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentifierVertex other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.VertexId == other.VertexId ||
                    this.VertexId != null &&
                    this.VertexId.Equals(other.VertexId)
                ) &&
                (
                    this.NormalizedType == other.NormalizedType ||
                    this.NormalizedType != null &&
                    this.NormalizedType.Equals(other.NormalizedType)
                ) &&
                (
                    this.NormalizedValue == other.NormalizedValue ||
                    this.NormalizedValue != null &&
                    this.NormalizedValue.Equals(other.NormalizedValue)
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
                if (this.VertexId != null)
                    hash = hash * 59 + this.VertexId.GetHashCode();

                if (this.NormalizedType != null)
                    hash = hash * 59 + this.NormalizedType.GetHashCode();

                if (this.NormalizedValue != null)
                    hash = hash * 59 + this.NormalizedValue.GetHashCode();

                return hash;
            }
        }
    }

}
