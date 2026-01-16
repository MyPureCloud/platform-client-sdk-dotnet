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
    /// KnowledgeSettings
    /// </summary>
    [DataContract]
    public partial class KnowledgeSettings :  IEquatable<KnowledgeSettings>
    {
        /// <summary>
        /// The type of the knowledge settings (Standard or Enhanced)
        /// </summary>
        /// <value>The type of the knowledge settings (Standard or Enhanced)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KnowledgeTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Enhanced for "Enhanced"
            /// </summary>
            [EnumMember(Value = "Enhanced")]
            Enhanced
        }
        /// <summary>
        /// The type of the knowledge settings (Standard or Enhanced)
        /// </summary>
        /// <value>The type of the knowledge settings (Standard or Enhanced)</value>
        [DataMember(Name="knowledgeType", EmitDefaultValue=false)]
        public KnowledgeTypeEnum? KnowledgeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSettings" /> class.
        /// </summary>
        /// <param name="KnowledgeId">The ID of the knowledge settings to use.</param>
        /// <param name="Description">Description of the knowledge settings.</param>
        /// <param name="KnowledgeType">The type of the knowledge settings (Standard or Enhanced).</param>
        public KnowledgeSettings(string KnowledgeId = null, string Description = null, KnowledgeTypeEnum? KnowledgeType = null)
        {
            this.KnowledgeId = KnowledgeId;
            this.Description = Description;
            this.KnowledgeType = KnowledgeType;
            
        }
        


        /// <summary>
        /// The ID of the knowledge settings to use
        /// </summary>
        /// <value>The ID of the knowledge settings to use</value>
        [DataMember(Name="knowledgeId", EmitDefaultValue=false)]
        public string KnowledgeId { get; set; }



        /// <summary>
        /// Description of the knowledge settings
        /// </summary>
        /// <value>Description of the knowledge settings</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSettings {\n");

            sb.Append("  KnowledgeId: ").Append(KnowledgeId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  KnowledgeType: ").Append(KnowledgeType).Append("\n");
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
            return this.Equals(obj as KnowledgeSettings);
        }

        /// <summary>
        /// Returns true if KnowledgeSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.KnowledgeId == other.KnowledgeId ||
                    this.KnowledgeId != null &&
                    this.KnowledgeId.Equals(other.KnowledgeId)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.KnowledgeType == other.KnowledgeType ||
                    this.KnowledgeType != null &&
                    this.KnowledgeType.Equals(other.KnowledgeType)
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
                if (this.KnowledgeId != null)
                    hash = hash * 59 + this.KnowledgeId.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.KnowledgeType != null)
                    hash = hash * 59 + this.KnowledgeType.GetHashCode();

                return hash;
            }
        }
    }

}
