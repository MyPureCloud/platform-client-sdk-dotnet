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
    /// SupportCenterModuleSetting
    /// </summary>
    [DataContract]
    public partial class SupportCenterModuleSetting :  IEquatable<SupportCenterModuleSetting>
    {
        /// <summary>
        /// Screen module type
        /// </summary>
        /// <value>Screen module type</value>
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
            /// Enum Search for "Search"
            /// </summary>
            [EnumMember(Value = "Search")]
            Search,
            
            /// <summary>
            /// Enum Categories for "Categories"
            /// </summary>
            [EnumMember(Value = "Categories")]
            Categories,
            
            /// <summary>
            /// Enum Faq for "FAQ"
            /// </summary>
            [EnumMember(Value = "FAQ")]
            Faq,
            
            /// <summary>
            /// Enum Contact for "Contact"
            /// </summary>
            [EnumMember(Value = "Contact")]
            Contact,
            
            /// <summary>
            /// Enum Results for "Results"
            /// </summary>
            [EnumMember(Value = "Results")]
            Results,
            
            /// <summary>
            /// Enum Article for "Article"
            /// </summary>
            [EnumMember(Value = "Article")]
            Article,
            
            /// <summary>
            /// Enum Topviewedarticles for "TopViewedArticles"
            /// </summary>
            [EnumMember(Value = "TopViewedArticles")]
            Topviewedarticles
        }
        /// <summary>
        /// Screen module type
        /// </summary>
        /// <value>Screen module type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterModuleSetting" /> class.
        /// </summary>
        /// <param name="Type">Screen module type.</param>
        /// <param name="Enabled">Whether or not support center screen module is enabled.</param>
        public SupportCenterModuleSetting(TypeEnum? Type = null, bool? Enabled = null)
        {
            this.Type = Type;
            this.Enabled = Enabled;
            
        }
        




        /// <summary>
        /// Whether or not support center screen module is enabled
        /// </summary>
        /// <value>Whether or not support center screen module is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterModuleSetting {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(obj as SupportCenterModuleSetting);
        }

        /// <summary>
        /// Returns true if SupportCenterModuleSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterModuleSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterModuleSetting other)
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
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                return hash;
            }
        }
    }

}
