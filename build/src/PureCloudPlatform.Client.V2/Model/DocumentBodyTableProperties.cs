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
    /// DocumentBodyTableProperties
    /// </summary>
    [DataContract]
    public partial class DocumentBodyTableProperties :  IEquatable<DocumentBodyTableProperties>
    {
        /// <summary>
        /// The alignment for the table.
        /// </summary>
        /// <value>The alignment for the table.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlignmentEnum
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
            Right
        }
        /// <summary>
        /// The border style for the table.
        /// </summary>
        /// <value>The border style for the table.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BorderStyleEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Solid for "Solid"
            /// </summary>
            [EnumMember(Value = "Solid")]
            Solid,
            
            /// <summary>
            /// Enum Dotted for "Dotted"
            /// </summary>
            [EnumMember(Value = "Dotted")]
            Dotted,
            
            /// <summary>
            /// Enum Dashed for "Dashed"
            /// </summary>
            [EnumMember(Value = "Dashed")]
            Dashed,
            
            /// <summary>
            /// Enum Double for "Double"
            /// </summary>
            [EnumMember(Value = "Double")]
            Double,
            
            /// <summary>
            /// Enum Groove for "Groove"
            /// </summary>
            [EnumMember(Value = "Groove")]
            Groove,
            
            /// <summary>
            /// Enum Ridge for "Ridge"
            /// </summary>
            [EnumMember(Value = "Ridge")]
            Ridge,
            
            /// <summary>
            /// Enum Inset for "Inset"
            /// </summary>
            [EnumMember(Value = "Inset")]
            Inset,
            
            /// <summary>
            /// Enum Outset for "Outset"
            /// </summary>
            [EnumMember(Value = "Outset")]
            Outset,
            
            /// <summary>
            /// Enum Hidden for "Hidden"
            /// </summary>
            [EnumMember(Value = "Hidden")]
            Hidden,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        /// <summary>
        /// The alignment for the table.
        /// </summary>
        /// <value>The alignment for the table.</value>
        [DataMember(Name="alignment", EmitDefaultValue=false)]
        public AlignmentEnum? Alignment { get; set; }
        /// <summary>
        /// The border style for the table.
        /// </summary>
        /// <value>The border style for the table.</value>
        [DataMember(Name="borderStyle", EmitDefaultValue=false)]
        public BorderStyleEnum? BorderStyle { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyTableProperties" /> class.
        /// </summary>
        /// <param name="Width">The width of the table converted to em unit..</param>
        /// <param name="Height">The height for the table..</param>
        /// <param name="CellSpacing">The cell spacing for the table. The valid values in &#39;em&#39;..</param>
        /// <param name="CellPadding">The cell padding for the table. The valid values in &#39;em&#39;..</param>
        /// <param name="BorderWidth">The border width for the table. The valid values in &#39;em&#39;.</param>
        /// <param name="Alignment">The alignment for the table..</param>
        /// <param name="BorderStyle">The border style for the table..</param>
        /// <param name="BorderColor">The border color for the table. The valid values in hex color code representation. For example black color - #000000.</param>
        /// <param name="BackgroundColor">The background color for the table. The valid values in hex color code representation. For example black color - #000000.</param>
        /// <param name="Caption">The caption for the table. The valid values in hex color code representation. For example black color - #000000.</param>
        public DocumentBodyTableProperties(float? Width = null, float? Height = null, float? CellSpacing = null, float? CellPadding = null, float? BorderWidth = null, AlignmentEnum? Alignment = null, BorderStyleEnum? BorderStyle = null, string BorderColor = null, string BackgroundColor = null, DocumentBodyTableCaptionBlock Caption = null)
        {
            this.Width = Width;
            this.Height = Height;
            this.CellSpacing = CellSpacing;
            this.CellPadding = CellPadding;
            this.BorderWidth = BorderWidth;
            this.Alignment = Alignment;
            this.BorderStyle = BorderStyle;
            this.BorderColor = BorderColor;
            this.BackgroundColor = BackgroundColor;
            this.Caption = Caption;
            
        }
        


        /// <summary>
        /// The width of the table converted to em unit.
        /// </summary>
        /// <value>The width of the table converted to em unit.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public float? Width { get; set; }



        /// <summary>
        /// The height for the table.
        /// </summary>
        /// <value>The height for the table.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public float? Height { get; set; }



        /// <summary>
        /// The cell spacing for the table. The valid values in &#39;em&#39;.
        /// </summary>
        /// <value>The cell spacing for the table. The valid values in &#39;em&#39;.</value>
        [DataMember(Name="cellSpacing", EmitDefaultValue=false)]
        public float? CellSpacing { get; set; }



        /// <summary>
        /// The cell padding for the table. The valid values in &#39;em&#39;.
        /// </summary>
        /// <value>The cell padding for the table. The valid values in &#39;em&#39;.</value>
        [DataMember(Name="cellPadding", EmitDefaultValue=false)]
        public float? CellPadding { get; set; }



        /// <summary>
        /// The border width for the table. The valid values in &#39;em&#39;
        /// </summary>
        /// <value>The border width for the table. The valid values in &#39;em&#39;</value>
        [DataMember(Name="borderWidth", EmitDefaultValue=false)]
        public float? BorderWidth { get; set; }







        /// <summary>
        /// The border color for the table. The valid values in hex color code representation. For example black color - #000000
        /// </summary>
        /// <value>The border color for the table. The valid values in hex color code representation. For example black color - #000000</value>
        [DataMember(Name="borderColor", EmitDefaultValue=false)]
        public string BorderColor { get; set; }



        /// <summary>
        /// The background color for the table. The valid values in hex color code representation. For example black color - #000000
        /// </summary>
        /// <value>The background color for the table. The valid values in hex color code representation. For example black color - #000000</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }



        /// <summary>
        /// The caption for the table. The valid values in hex color code representation. For example black color - #000000
        /// </summary>
        /// <value>The caption for the table. The valid values in hex color code representation. For example black color - #000000</value>
        [DataMember(Name="caption", EmitDefaultValue=false)]
        public DocumentBodyTableCaptionBlock Caption { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyTableProperties {\n");

            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  CellSpacing: ").Append(CellSpacing).Append("\n");
            sb.Append("  CellPadding: ").Append(CellPadding).Append("\n");
            sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
            sb.Append("  Alignment: ").Append(Alignment).Append("\n");
            sb.Append("  BorderStyle: ").Append(BorderStyle).Append("\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
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
            return this.Equals(obj as DocumentBodyTableProperties);
        }

        /// <summary>
        /// Returns true if DocumentBodyTableProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyTableProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyTableProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) &&
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) &&
                (
                    this.CellSpacing == other.CellSpacing ||
                    this.CellSpacing != null &&
                    this.CellSpacing.Equals(other.CellSpacing)
                ) &&
                (
                    this.CellPadding == other.CellPadding ||
                    this.CellPadding != null &&
                    this.CellPadding.Equals(other.CellPadding)
                ) &&
                (
                    this.BorderWidth == other.BorderWidth ||
                    this.BorderWidth != null &&
                    this.BorderWidth.Equals(other.BorderWidth)
                ) &&
                (
                    this.Alignment == other.Alignment ||
                    this.Alignment != null &&
                    this.Alignment.Equals(other.Alignment)
                ) &&
                (
                    this.BorderStyle == other.BorderStyle ||
                    this.BorderStyle != null &&
                    this.BorderStyle.Equals(other.BorderStyle)
                ) &&
                (
                    this.BorderColor == other.BorderColor ||
                    this.BorderColor != null &&
                    this.BorderColor.Equals(other.BorderColor)
                ) &&
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
                ) &&
                (
                    this.Caption == other.Caption ||
                    this.Caption != null &&
                    this.Caption.Equals(other.Caption)
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
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();

                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();

                if (this.CellSpacing != null)
                    hash = hash * 59 + this.CellSpacing.GetHashCode();

                if (this.CellPadding != null)
                    hash = hash * 59 + this.CellPadding.GetHashCode();

                if (this.BorderWidth != null)
                    hash = hash * 59 + this.BorderWidth.GetHashCode();

                if (this.Alignment != null)
                    hash = hash * 59 + this.Alignment.GetHashCode();

                if (this.BorderStyle != null)
                    hash = hash * 59 + this.BorderStyle.GetHashCode();

                if (this.BorderColor != null)
                    hash = hash * 59 + this.BorderColor.GetHashCode();

                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();

                if (this.Caption != null)
                    hash = hash * 59 + this.Caption.GetHashCode();

                return hash;
            }
        }
    }

}
