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
    /// StaticListValues
    /// </summary>
    [DataContract]
    public partial class StaticListValues : ListValues,  IEquatable<StaticListValues>
    {
        /// <summary>
        /// Defines how matching should work.
        /// </summary>
        /// <value>Defines how matching should work.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MatchTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Exact for "Exact"
            /// </summary>
            [EnumMember(Value = "Exact")]
            Exact,
            
            /// <summary>
            /// Enum Semantic for "Semantic"
            /// </summary>
            [EnumMember(Value = "Semantic")]
            Semantic
        }
        /// <summary>
        /// Defines how matching should work.
        /// </summary>
        /// <value>Defines how matching should work.</value>
        [DataMember(Name="matchType", EmitDefaultValue=false)]
        public MatchTypeEnum? MatchType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticListValues" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaticListValues() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticListValues" /> class.
        /// </summary>
        /// <param name="Items">Array of list items. Each item contains a value and optional synonyms. (required).</param>
        /// <param name="MatchType">Defines how matching should work. (required).</param>
        public StaticListValues(List<ListItem> Items = null, MatchTypeEnum? MatchType = null)
        {
            this.Items = Items;
            this.MatchType = MatchType;
            
        }
        


        /// <summary>
        /// Array of list items. Each item contains a value and optional synonyms.
        /// </summary>
        /// <value>Array of list items. Each item contains a value and optional synonyms.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ListItem> Items { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaticListValues {\n");

            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as StaticListValues);
        }

        /// <summary>
        /// Returns true if StaticListValues instances are equal
        /// </summary>
        /// <param name="other">Instance of StaticListValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaticListValues other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) &&
                (
                    this.MatchType == other.MatchType ||
                    this.MatchType != null &&
                    this.MatchType.Equals(other.MatchType)
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
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();

                if (this.MatchType != null)
                    hash = hash * 59 + this.MatchType.GetHashCode();

                return hash;
            }
        }
    }

}
