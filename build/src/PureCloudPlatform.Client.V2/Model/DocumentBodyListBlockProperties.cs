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
    /// DocumentBodyListBlockProperties
    /// </summary>
    [DataContract]
    public partial class DocumentBodyListBlockProperties :  IEquatable<DocumentBodyListBlockProperties>
    {
        /// <summary>
        /// The type of icon for the unordered list.
        /// </summary>
        /// <value>The type of icon for the unordered list.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UnorderedTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Normal for "Normal"
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal,
            
            /// <summary>
            /// Enum Square for "Square"
            /// </summary>
            [EnumMember(Value = "Square")]
            Square,
            
            /// <summary>
            /// Enum Circle for "Circle"
            /// </summary>
            [EnumMember(Value = "Circle")]
            Circle
        }
        /// <summary>
        /// The type of icon for the ordered list.
        /// </summary>
        /// <value>The type of icon for the ordered list.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OrderedTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number,
            
            /// <summary>
            /// Enum Loweralpha for "LowerAlpha"
            /// </summary>
            [EnumMember(Value = "LowerAlpha")]
            Loweralpha,
            
            /// <summary>
            /// Enum Lowergreek for "LowerGreek"
            /// </summary>
            [EnumMember(Value = "LowerGreek")]
            Lowergreek,
            
            /// <summary>
            /// Enum Lowerroman for "LowerRoman"
            /// </summary>
            [EnumMember(Value = "LowerRoman")]
            Lowerroman,
            
            /// <summary>
            /// Enum Upperalpha for "UpperAlpha"
            /// </summary>
            [EnumMember(Value = "UpperAlpha")]
            Upperalpha,
            
            /// <summary>
            /// Enum Upperroman for "UpperRoman"
            /// </summary>
            [EnumMember(Value = "UpperRoman")]
            Upperroman
        }
        /// <summary>
        /// The type of icon for the unordered list.
        /// </summary>
        /// <value>The type of icon for the unordered list.</value>
        [DataMember(Name="unorderedType", EmitDefaultValue=false)]
        public UnorderedTypeEnum? UnorderedType { get; set; }
        /// <summary>
        /// The type of icon for the ordered list.
        /// </summary>
        /// <value>The type of icon for the ordered list.</value>
        [DataMember(Name="orderedType", EmitDefaultValue=false)]
        public OrderedTypeEnum? OrderedType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyListBlockProperties" /> class.
        /// </summary>
        /// <param name="UnorderedType">The type of icon for the unordered list..</param>
        /// <param name="OrderedType">The type of icon for the ordered list..</param>
        public DocumentBodyListBlockProperties(UnorderedTypeEnum? UnorderedType = null, OrderedTypeEnum? OrderedType = null)
        {
            this.UnorderedType = UnorderedType;
            this.OrderedType = OrderedType;
            
        }
        





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyListBlockProperties {\n");

            sb.Append("  UnorderedType: ").Append(UnorderedType).Append("\n");
            sb.Append("  OrderedType: ").Append(OrderedType).Append("\n");
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
            return this.Equals(obj as DocumentBodyListBlockProperties);
        }

        /// <summary>
        /// Returns true if DocumentBodyListBlockProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyListBlockProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyListBlockProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UnorderedType == other.UnorderedType ||
                    this.UnorderedType != null &&
                    this.UnorderedType.Equals(other.UnorderedType)
                ) &&
                (
                    this.OrderedType == other.OrderedType ||
                    this.OrderedType != null &&
                    this.OrderedType.Equals(other.OrderedType)
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
                if (this.UnorderedType != null)
                    hash = hash * 59 + this.UnorderedType.GetHashCode();

                if (this.OrderedType != null)
                    hash = hash * 59 + this.OrderedType.GetHashCode();

                return hash;
            }
        }
    }

}
