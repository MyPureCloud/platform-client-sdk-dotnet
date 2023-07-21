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
    /// DocumentBodyListItemProperties
    /// </summary>
    [DataContract]
    public partial class DocumentBodyListItemProperties :  IEquatable<DocumentBodyListItemProperties>
    {
        /// <summary>
        /// The align type for the list item.
        /// </summary>
        /// <value>The align type for the list item.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlignEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            [EnumMember(Value = "Center")]
            Center,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            [EnumMember(Value = "Left")]
            Left,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            [EnumMember(Value = "Right")]
            Right,
            
            /// <summary>
            /// Enum Justify for "Justify"
            /// </summary>
            [EnumMember(Value = "Justify")]
            Justify
        }
        /// <summary>
        /// The font size for the list item. The valid values in 'em'.
        /// </summary>
        /// <value>The font size for the list item. The valid values in 'em'.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FontSizeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Xxsmall for "XxSmall"
            /// </summary>
            [EnumMember(Value = "XxSmall")]
            Xxsmall,
            
            /// <summary>
            /// Enum Xsmall for "XSmall"
            /// </summary>
            [EnumMember(Value = "XSmall")]
            Xsmall,
            
            /// <summary>
            /// Enum Small for "Small"
            /// </summary>
            [EnumMember(Value = "Small")]
            Small,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium,
            
            /// <summary>
            /// Enum Large for "Large"
            /// </summary>
            [EnumMember(Value = "Large")]
            Large,
            
            /// <summary>
            /// Enum Xlarge for "XLarge"
            /// </summary>
            [EnumMember(Value = "XLarge")]
            Xlarge,
            
            /// <summary>
            /// Enum Xxlarge for "XxLarge"
            /// </summary>
            [EnumMember(Value = "XxLarge")]
            Xxlarge,
            
            /// <summary>
            /// Enum Xxxlarge for "XxxLarge"
            /// </summary>
            [EnumMember(Value = "XxxLarge")]
            Xxxlarge
        }
        /// <summary>
        /// The font type for the list item.
        /// </summary>
        /// <value>The font type for the list item.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FontTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Paragraph for "Paragraph"
            /// </summary>
            [EnumMember(Value = "Paragraph")]
            Paragraph,
            
            /// <summary>
            /// Enum Heading1 for "Heading1"
            /// </summary>
            [EnumMember(Value = "Heading1")]
            Heading1,
            
            /// <summary>
            /// Enum Heading2 for "Heading2"
            /// </summary>
            [EnumMember(Value = "Heading2")]
            Heading2,
            
            /// <summary>
            /// Enum Heading3 for "Heading3"
            /// </summary>
            [EnumMember(Value = "Heading3")]
            Heading3,
            
            /// <summary>
            /// Enum Heading4 for "Heading4"
            /// </summary>
            [EnumMember(Value = "Heading4")]
            Heading4,
            
            /// <summary>
            /// Enum Heading5 for "Heading5"
            /// </summary>
            [EnumMember(Value = "Heading5")]
            Heading5,
            
            /// <summary>
            /// Enum Heading6 for "Heading6"
            /// </summary>
            [EnumMember(Value = "Heading6")]
            Heading6,
            
            /// <summary>
            /// Enum Preformatted for "Preformatted"
            /// </summary>
            [EnumMember(Value = "Preformatted")]
            Preformatted
        }
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
            Circle,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
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
            Upperroman,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        /// <summary>
        /// The align type for the list item.
        /// </summary>
        /// <value>The align type for the list item.</value>
        [DataMember(Name="align", EmitDefaultValue=false)]
        public AlignEnum? Align { get; set; }
        /// <summary>
        /// The font size for the list item. The valid values in 'em'.
        /// </summary>
        /// <value>The font size for the list item. The valid values in 'em'.</value>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public FontSizeEnum? FontSize { get; set; }
        /// <summary>
        /// The font type for the list item.
        /// </summary>
        /// <value>The font type for the list item.</value>
        [DataMember(Name="fontType", EmitDefaultValue=false)]
        public FontTypeEnum? FontType { get; set; }
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
        /// Initializes a new instance of the <see cref="DocumentBodyListItemProperties" /> class.
        /// </summary>
        /// <param name="BackgroundColor">The background color for the list item. The valid values in hex color code representation. For example black color - #000000.</param>
        /// <param name="Align">The align type for the list item..</param>
        /// <param name="Indentation">The indentation property for the list item. The valid values in 'em'..</param>
        /// <param name="FontSize">The font size for the list item. The valid values in 'em'..</param>
        /// <param name="FontType">The font type for the list item..</param>
        /// <param name="TextColor">The text color for the list item. The valid values in hex color code representation. For example black color - #000000.</param>
        /// <param name="UnorderedType">The type of icon for the unordered list..</param>
        /// <param name="OrderedType">The type of icon for the ordered list..</param>
        public DocumentBodyListItemProperties(string BackgroundColor = null, AlignEnum? Align = null, float? Indentation = null, FontSizeEnum? FontSize = null, FontTypeEnum? FontType = null, string TextColor = null, UnorderedTypeEnum? UnorderedType = null, OrderedTypeEnum? OrderedType = null)
        {
            this.BackgroundColor = BackgroundColor;
            this.Align = Align;
            this.Indentation = Indentation;
            this.FontSize = FontSize;
            this.FontType = FontType;
            this.TextColor = TextColor;
            this.UnorderedType = UnorderedType;
            this.OrderedType = OrderedType;
            
        }
        


        /// <summary>
        /// The background color for the list item. The valid values in hex color code representation. For example black color - #000000
        /// </summary>
        /// <value>The background color for the list item. The valid values in hex color code representation. For example black color - #000000</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }





        /// <summary>
        /// The indentation property for the list item. The valid values in 'em'.
        /// </summary>
        /// <value>The indentation property for the list item. The valid values in 'em'.</value>
        [DataMember(Name="indentation", EmitDefaultValue=false)]
        public float? Indentation { get; set; }







        /// <summary>
        /// The text color for the list item. The valid values in hex color code representation. For example black color - #000000
        /// </summary>
        /// <value>The text color for the list item. The valid values in hex color code representation. For example black color - #000000</value>
        [DataMember(Name="textColor", EmitDefaultValue=false)]
        public string TextColor { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyListItemProperties {\n");

            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  Align: ").Append(Align).Append("\n");
            sb.Append("  Indentation: ").Append(Indentation).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  FontType: ").Append(FontType).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
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
            return this.Equals(obj as DocumentBodyListItemProperties);
        }

        /// <summary>
        /// Returns true if DocumentBodyListItemProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyListItemProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyListItemProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
                ) &&
                (
                    this.Align == other.Align ||
                    this.Align != null &&
                    this.Align.Equals(other.Align)
                ) &&
                (
                    this.Indentation == other.Indentation ||
                    this.Indentation != null &&
                    this.Indentation.Equals(other.Indentation)
                ) &&
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
                ) &&
                (
                    this.FontType == other.FontType ||
                    this.FontType != null &&
                    this.FontType.Equals(other.FontType)
                ) &&
                (
                    this.TextColor == other.TextColor ||
                    this.TextColor != null &&
                    this.TextColor.Equals(other.TextColor)
                ) &&
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
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();

                if (this.Align != null)
                    hash = hash * 59 + this.Align.GetHashCode();

                if (this.Indentation != null)
                    hash = hash * 59 + this.Indentation.GetHashCode();

                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();

                if (this.FontType != null)
                    hash = hash * 59 + this.FontType.GetHashCode();

                if (this.TextColor != null)
                    hash = hash * 59 + this.TextColor.GetHashCode();

                if (this.UnorderedType != null)
                    hash = hash * 59 + this.UnorderedType.GetHashCode();

                if (this.OrderedType != null)
                    hash = hash * 59 + this.OrderedType.GetHashCode();

                return hash;
            }
        }
    }

}
