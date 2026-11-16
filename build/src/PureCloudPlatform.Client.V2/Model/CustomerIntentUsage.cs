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
    /// A place where a customer intent or category is used
    /// </summary>
    [DataContract]
    public partial class CustomerIntentUsage :  IEquatable<CustomerIntentUsage>
    {
        /// <summary>
        /// Whether the usage is for a customer intent or category
        /// </summary>
        /// <value>Whether the usage is for a customer intent or category</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Intent for "Intent"
            /// </summary>
            [EnumMember(Value = "Intent")]
            Intent,
            
            /// <summary>
            /// Enum Category for "Category"
            /// </summary>
            [EnumMember(Value = "Category")]
            Category
        }
        /// <summary>
        /// Type of the source using the customer intent or category
        /// </summary>
        /// <value>Type of the source using the customer intent or category</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bot for "Bot"
            /// </summary>
            [EnumMember(Value = "Bot")]
            Bot,
            
            /// <summary>
            /// Enum Copilot for "Copilot"
            /// </summary>
            [EnumMember(Value = "Copilot")]
            Copilot,
            
            /// <summary>
            /// Enum Digitalbot for "Digitalbot"
            /// </summary>
            [EnumMember(Value = "Digitalbot")]
            Digitalbot,
            
            /// <summary>
            /// Enum Segment for "Segment"
            /// </summary>
            [EnumMember(Value = "Segment")]
            Segment,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Whether the usage is for a customer intent or category
        /// </summary>
        /// <value>Whether the usage is for a customer intent or category</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; private set; }
        /// <summary>
        /// Type of the source using the customer intent or category
        /// </summary>
        /// <value>Type of the source using the customer intent or category</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerIntentUsage" /> class.
        /// </summary>
        public CustomerIntentUsage()
        {
            
        }
        






        /// <summary>
        /// Source using the customer intent or category. The selfUri is included when the source type has an addressable Public API resource.
        /// </summary>
        /// <value>Source using the customer intent or category. The selfUri is included when the source type has an addressable Public API resource.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public DomainEntityRef Source { get; private set; }



        /// <summary>
        /// Creation date of the usage. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation date of the usage. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerIntentUsage {\n");

            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
            return this.Equals(obj as CustomerIntentUsage);
        }

        /// <summary>
        /// Returns true if CustomerIntentUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerIntentUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerIntentUsage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.SourceType == other.SourceType ||
                    this.SourceType != null &&
                    this.SourceType.Equals(other.SourceType)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
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
                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                return hash;
            }
        }
    }

}
