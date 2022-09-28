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
    /// The Footer template identifies the Footer type and its footerUsage
    /// </summary>
    [DataContract]
    public partial class FooterTemplate :  IEquatable<FooterTemplate>
    {
        /// <summary>
        /// Specifies the type represented by Footer.
        /// </summary>
        /// <value>Specifies the type represented by Footer.</value>
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
            /// Enum Signature for "Signature"
            /// </summary>
            [EnumMember(Value = "Signature")]
            Signature
        }
        /// <summary>
        /// Gets or Sets ApplicableResources
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ApplicableResourcesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Campaign for "Campaign"
            /// </summary>
            [EnumMember(Value = "Campaign")]
            Campaign
        }
        /// <summary>
        /// Specifies the type represented by Footer.
        /// </summary>
        /// <value>Specifies the type represented by Footer.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FooterTemplate" /> class.
        /// </summary>
        /// <param name="Type">Specifies the type represented by Footer..</param>
        /// <param name="ApplicableResources">Specifies the canned response template where the footer can be used..</param>
        public FooterTemplate(TypeEnum? Type = null, List<ApplicableResourcesEnum> ApplicableResources = null)
        {
            this.Type = Type;
            this.ApplicableResources = ApplicableResources;
            
        }
        




        /// <summary>
        /// Specifies the canned response template where the footer can be used.
        /// </summary>
        /// <value>Specifies the canned response template where the footer can be used.</value>
        [DataMember(Name="applicableResources", EmitDefaultValue=false)]
        public List<ApplicableResourcesEnum> ApplicableResources { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FooterTemplate {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ApplicableResources: ").Append(ApplicableResources).Append("\n");
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
            return this.Equals(obj as FooterTemplate);
        }

        /// <summary>
        /// Returns true if FooterTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of FooterTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FooterTemplate other)
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
                    this.ApplicableResources == other.ApplicableResources ||
                    this.ApplicableResources != null &&
                    this.ApplicableResources.SequenceEqual(other.ApplicableResources)
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

                if (this.ApplicableResources != null)
                    hash = hash * 59 + this.ApplicableResources.GetHashCode();

                return hash;
            }
        }
    }

}
