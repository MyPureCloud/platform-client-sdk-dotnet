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
    /// DataIngestionRuleCriteria
    /// </summary>
    [DataContract]
    public partial class DataIngestionRuleCriteria :  IEquatable<DataIngestionRuleCriteria>
    {
        /// <summary>
        /// The effective platform for the data ingestion rule.
        /// </summary>
        /// <value>The effective platform for the data ingestion rule.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EffectivePlatformEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Facebook for "Facebook"
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Instagram for "Instagram"
            /// </summary>
            [EnumMember(Value = "Instagram")]
            Instagram,
            
            /// <summary>
            /// Enum Twitter for "Twitter"
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Googlebusinessprofile for "GoogleBusinessProfile"
            /// </summary>
            [EnumMember(Value = "GoogleBusinessProfile")]
            Googlebusinessprofile
        }
        /// <summary>
        /// The effective platform for the data ingestion rule.
        /// </summary>
        /// <value>The effective platform for the data ingestion rule.</value>
        [DataMember(Name="effectivePlatform", EmitDefaultValue=false)]
        public EffectivePlatformEnum? EffectivePlatform { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataIngestionRuleCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataIngestionRuleCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataIngestionRuleCriteria" /> class.
        /// </summary>
        /// <param name="EffectivePlatform">The effective platform for the data ingestion rule. (required).</param>
        /// <param name="Id">The ID of the data ingestion rule. (required).</param>
        public DataIngestionRuleCriteria(EffectivePlatformEnum? EffectivePlatform = null, string Id = null)
        {
            this.EffectivePlatform = EffectivePlatform;
            this.Id = Id;
            
        }
        




        /// <summary>
        /// The ID of the data ingestion rule.
        /// </summary>
        /// <value>The ID of the data ingestion rule.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataIngestionRuleCriteria {\n");

            sb.Append("  EffectivePlatform: ").Append(EffectivePlatform).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as DataIngestionRuleCriteria);
        }

        /// <summary>
        /// Returns true if DataIngestionRuleCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of DataIngestionRuleCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataIngestionRuleCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EffectivePlatform == other.EffectivePlatform ||
                    this.EffectivePlatform != null &&
                    this.EffectivePlatform.Equals(other.EffectivePlatform)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.EffectivePlatform != null)
                    hash = hash * 59 + this.EffectivePlatform.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                return hash;
            }
        }
    }

}
