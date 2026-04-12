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
    /// ActivityCodeStyle
    /// </summary>
    [DataContract]
    public partial class ActivityCodeStyle :  IEquatable<ActivityCodeStyle>
    {
        /// <summary>
        /// Text color theme for the activity code
        /// </summary>
        /// <value>Text color theme for the activity code</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TextColorThemeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Dark for "Dark"
            /// </summary>
            [EnumMember(Value = "Dark")]
            Dark,
            
            /// <summary>
            /// Enum Light for "Light"
            /// </summary>
            [EnumMember(Value = "Light")]
            Light
        }
        /// <summary>
        /// Text color theme for the activity code
        /// </summary>
        /// <value>Text color theme for the activity code</value>
        [DataMember(Name="textColorTheme", EmitDefaultValue=false)]
        public TextColorThemeEnum? TextColorTheme { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCodeStyle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityCodeStyle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCodeStyle" /> class.
        /// </summary>
        /// <param name="BackgroundColor">Background color for the activity code in hex format starting with # followed by 6 hexadecimal characters (0-9, a-f, A-F) (required).</param>
        /// <param name="TextColorTheme">Text color theme for the activity code (required).</param>
        public ActivityCodeStyle(string BackgroundColor = null, TextColorThemeEnum? TextColorTheme = null)
        {
            this.BackgroundColor = BackgroundColor;
            this.TextColorTheme = TextColorTheme;
            
        }
        


        /// <summary>
        /// Background color for the activity code in hex format starting with # followed by 6 hexadecimal characters (0-9, a-f, A-F)
        /// </summary>
        /// <value>Background color for the activity code in hex format starting with # followed by 6 hexadecimal characters (0-9, a-f, A-F)</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityCodeStyle {\n");

            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  TextColorTheme: ").Append(TextColorTheme).Append("\n");
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
            return this.Equals(obj as ActivityCodeStyle);
        }

        /// <summary>
        /// Returns true if ActivityCodeStyle instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityCodeStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityCodeStyle other)
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
                    this.TextColorTheme == other.TextColorTheme ||
                    this.TextColorTheme != null &&
                    this.TextColorTheme.Equals(other.TextColorTheme)
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

                if (this.TextColorTheme != null)
                    hash = hash * 59 + this.TextColorTheme.GetHashCode();

                return hash;
            }
        }
    }

}
