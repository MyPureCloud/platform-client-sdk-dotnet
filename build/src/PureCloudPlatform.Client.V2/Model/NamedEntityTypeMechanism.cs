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
    /// NamedEntityTypeMechanism
    /// </summary>
    [DataContract]
    public partial class NamedEntityTypeMechanism :  IEquatable<NamedEntityTypeMechanism>
    {
        /// <summary>
        /// The type of the mechanism.
        /// </summary>
        /// <value>The type of the mechanism.</value>
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
            /// Enum Ai for "AI"
            /// </summary>
            [EnumMember(Value = "AI")]
            Ai,
            
            /// <summary>
            /// Enum Dynamiclist for "DynamicList"
            /// </summary>
            [EnumMember(Value = "DynamicList")]
            Dynamiclist,
            
            /// <summary>
            /// Enum List for "List"
            /// </summary>
            [EnumMember(Value = "List")]
            List,
            
            /// <summary>
            /// Enum Regex for "Regex"
            /// </summary>
            [EnumMember(Value = "Regex")]
            Regex,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Subtype of detection mechanism
        /// </summary>
        /// <value>Subtype of detection mechanism</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SubTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alphanumeric for "Alphanumeric"
            /// </summary>
            [EnumMember(Value = "Alphanumeric")]
            Alphanumeric,
            
            /// <summary>
            /// Enum Numbersequence for "NumberSequence"
            /// </summary>
            [EnumMember(Value = "NumberSequence")]
            Numbersequence,
            
            /// <summary>
            /// Enum Freeform for "FreeForm"
            /// </summary>
            [EnumMember(Value = "FreeForm")]
            Freeform
        }
        /// <summary>
        /// The type of the mechanism.
        /// </summary>
        /// <value>The type of the mechanism.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Subtype of detection mechanism
        /// </summary>
        /// <value>Subtype of detection mechanism</value>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public SubTypeEnum? SubType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityTypeMechanism" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NamedEntityTypeMechanism() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityTypeMechanism" /> class.
        /// </summary>
        /// <param name="Items">The items that define the named entity type. (required).</param>
        /// <param name="Restricted">Whether the named entity type is restricted to the items provided. Default: false.</param>
        /// <param name="Type">The type of the mechanism. (required).</param>
        /// <param name="SubType">Subtype of detection mechanism.</param>
        /// <param name="MaxLength">The maximum length of the entity resolved value.</param>
        /// <param name="Examples">Examples for entity detection.</param>
        public NamedEntityTypeMechanism(List<NamedEntityTypeItem> Items = null, bool? Restricted = null, TypeEnum? Type = null, SubTypeEnum? SubType = null, int? MaxLength = null, List<NamedEntityTypeMechanismExample> Examples = null)
        {
            this.Items = Items;
            this.Restricted = Restricted;
            this.Type = Type;
            this.SubType = SubType;
            this.MaxLength = MaxLength;
            this.Examples = Examples;
            
        }
        


        /// <summary>
        /// The items that define the named entity type.
        /// </summary>
        /// <value>The items that define the named entity type.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<NamedEntityTypeItem> Items { get; set; }



        /// <summary>
        /// Whether the named entity type is restricted to the items provided. Default: false
        /// </summary>
        /// <value>Whether the named entity type is restricted to the items provided. Default: false</value>
        [DataMember(Name="restricted", EmitDefaultValue=false)]
        public bool? Restricted { get; set; }







        /// <summary>
        /// The maximum length of the entity resolved value
        /// </summary>
        /// <value>The maximum length of the entity resolved value</value>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }



        /// <summary>
        /// Examples for entity detection
        /// </summary>
        /// <value>Examples for entity detection</value>
        [DataMember(Name="examples", EmitDefaultValue=false)]
        public List<NamedEntityTypeMechanismExample> Examples { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamedEntityTypeMechanism {\n");

            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Restricted: ").Append(Restricted).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  Examples: ").Append(Examples).Append("\n");
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
            return this.Equals(obj as NamedEntityTypeMechanism);
        }

        /// <summary>
        /// Returns true if NamedEntityTypeMechanism instances are equal
        /// </summary>
        /// <param name="other">Instance of NamedEntityTypeMechanism to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamedEntityTypeMechanism other)
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
                    this.Restricted == other.Restricted ||
                    this.Restricted != null &&
                    this.Restricted.Equals(other.Restricted)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.SubType == other.SubType ||
                    this.SubType != null &&
                    this.SubType.Equals(other.SubType)
                ) &&
                (
                    this.MaxLength == other.MaxLength ||
                    this.MaxLength != null &&
                    this.MaxLength.Equals(other.MaxLength)
                ) &&
                (
                    this.Examples == other.Examples ||
                    this.Examples != null &&
                    this.Examples.SequenceEqual(other.Examples)
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

                if (this.Restricted != null)
                    hash = hash * 59 + this.Restricted.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.SubType != null)
                    hash = hash * 59 + this.SubType.GetHashCode();

                if (this.MaxLength != null)
                    hash = hash * 59 + this.MaxLength.GetHashCode();

                if (this.Examples != null)
                    hash = hash * 59 + this.Examples.GetHashCode();

                return hash;
            }
        }
    }

}
