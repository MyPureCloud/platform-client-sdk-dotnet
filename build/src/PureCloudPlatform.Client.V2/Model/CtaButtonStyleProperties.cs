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
    /// CtaButtonStyleProperties
    /// </summary>
    [DataContract]
    public partial class CtaButtonStyleProperties :  IEquatable<CtaButtonStyleProperties>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Text alignment.
        /// </summary>
        /// <value>Text alignment.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TextAlignEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
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
            /// Enum Center for "Center"
            /// </summary>
            [EnumMember(Value = "Center")]
            Center
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Text alignment.
        /// </summary>
        /// <value>Text alignment.</value>
        [DataMember(Name="textAlign", EmitDefaultValue=false)]
        public TextAlignEnum? TextAlign { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CtaButtonStyleProperties" /> class.
        /// </summary>
        /// <param name="Color">Color of the text. (eg. #FFFFFF).</param>
        /// <param name="Font">Font of the text. (eg. Helvetica).</param>
        /// <param name="FontSize">Font size of the text. (eg. &#39;12&#39;).</param>
        /// <param name="TextAlign">Text alignment..</param>
        /// <param name="BackgroundColor">Background color of the CTA button. (eg. #FF0000).</param>
        public CtaButtonStyleProperties(string Color = null, string Font = null, string FontSize = null, TextAlignEnum? TextAlign = null, string BackgroundColor = null)
        {
            this.Color = Color;
            this.Font = Font;
            this.FontSize = FontSize;
            this.TextAlign = TextAlign;
            this.BackgroundColor = BackgroundColor;
            
        }
        
        
        
        /// <summary>
        /// Color of the text. (eg. #FFFFFF)
        /// </summary>
        /// <value>Color of the text. (eg. #FFFFFF)</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }
        
        
        
        /// <summary>
        /// Font of the text. (eg. Helvetica)
        /// </summary>
        /// <value>Font of the text. (eg. Helvetica)</value>
        [DataMember(Name="font", EmitDefaultValue=false)]
        public string Font { get; set; }
        
        
        
        /// <summary>
        /// Font size of the text. (eg. &#39;12&#39;)
        /// </summary>
        /// <value>Font size of the text. (eg. &#39;12&#39;)</value>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public string FontSize { get; set; }
        
        
        
        
        
        /// <summary>
        /// Background color of the CTA button. (eg. #FF0000)
        /// </summary>
        /// <value>Background color of the CTA button. (eg. #FF0000)</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CtaButtonStyleProperties {\n");
            
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  TextAlign: ").Append(TextAlign).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CtaButtonStyleProperties);
        }

        /// <summary>
        /// Returns true if CtaButtonStyleProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of CtaButtonStyleProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CtaButtonStyleProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) &&
                (
                    this.Font == other.Font ||
                    this.Font != null &&
                    this.Font.Equals(other.Font)
                ) &&
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
                ) &&
                (
                    this.TextAlign == other.TextAlign ||
                    this.TextAlign != null &&
                    this.TextAlign.Equals(other.TextAlign)
                ) &&
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
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
                
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                
                if (this.Font != null)
                    hash = hash * 59 + this.Font.GetHashCode();
                
                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();
                
                if (this.TextAlign != null)
                    hash = hash * 59 + this.TextAlign.GetHashCode();
                
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();
                
                return hash;
            }
        }
    }

}
