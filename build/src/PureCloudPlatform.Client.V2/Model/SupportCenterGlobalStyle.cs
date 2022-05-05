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
    /// SupportCenterGlobalStyle
    /// </summary>
    [DataContract]
    public partial class SupportCenterGlobalStyle :  IEquatable<SupportCenterGlobalStyle>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterGlobalStyle" /> class.
        /// </summary>
        /// <param name="BackgroundColor">Global background color, in hexadecimal format, eg #ffffff.</param>
        /// <param name="PrimaryColor">Global primary color, in hexadecimal format, eg #ffffff.</param>
        /// <param name="PrimaryColorDark">Global dark primary color, in hexadecimal format, eg #ffffff.</param>
        /// <param name="PrimaryColorLight">Global light primary color, in hexadecimal format, eg #ffffff.</param>
        /// <param name="TextColor">Global text color, in hexadecimal format, eg #ffffff.</param>
        /// <param name="FontFamily">Global font family.</param>
        public SupportCenterGlobalStyle(string BackgroundColor = null, string PrimaryColor = null, string PrimaryColorDark = null, string PrimaryColorLight = null, string TextColor = null, string FontFamily = null)
        {
            this.BackgroundColor = BackgroundColor;
            this.PrimaryColor = PrimaryColor;
            this.PrimaryColorDark = PrimaryColorDark;
            this.PrimaryColorLight = PrimaryColorLight;
            this.TextColor = TextColor;
            this.FontFamily = FontFamily;
            
        }
        
        
        
        /// <summary>
        /// Global background color, in hexadecimal format, eg #ffffff
        /// </summary>
        /// <value>Global background color, in hexadecimal format, eg #ffffff</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }
        
        
        
        /// <summary>
        /// Global primary color, in hexadecimal format, eg #ffffff
        /// </summary>
        /// <value>Global primary color, in hexadecimal format, eg #ffffff</value>
        [DataMember(Name="primaryColor", EmitDefaultValue=false)]
        public string PrimaryColor { get; set; }
        
        
        
        /// <summary>
        /// Global dark primary color, in hexadecimal format, eg #ffffff
        /// </summary>
        /// <value>Global dark primary color, in hexadecimal format, eg #ffffff</value>
        [DataMember(Name="primaryColorDark", EmitDefaultValue=false)]
        public string PrimaryColorDark { get; set; }
        
        
        
        /// <summary>
        /// Global light primary color, in hexadecimal format, eg #ffffff
        /// </summary>
        /// <value>Global light primary color, in hexadecimal format, eg #ffffff</value>
        [DataMember(Name="primaryColorLight", EmitDefaultValue=false)]
        public string PrimaryColorLight { get; set; }
        
        
        
        /// <summary>
        /// Global text color, in hexadecimal format, eg #ffffff
        /// </summary>
        /// <value>Global text color, in hexadecimal format, eg #ffffff</value>
        [DataMember(Name="textColor", EmitDefaultValue=false)]
        public string TextColor { get; set; }
        
        
        
        /// <summary>
        /// Global font family
        /// </summary>
        /// <value>Global font family</value>
        [DataMember(Name="fontFamily", EmitDefaultValue=false)]
        public string FontFamily { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterGlobalStyle {\n");
            
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  PrimaryColor: ").Append(PrimaryColor).Append("\n");
            sb.Append("  PrimaryColorDark: ").Append(PrimaryColorDark).Append("\n");
            sb.Append("  PrimaryColorLight: ").Append(PrimaryColorLight).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
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
            return this.Equals(obj as SupportCenterGlobalStyle);
        }

        /// <summary>
        /// Returns true if SupportCenterGlobalStyle instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterGlobalStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterGlobalStyle other)
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
                    this.PrimaryColor == other.PrimaryColor ||
                    this.PrimaryColor != null &&
                    this.PrimaryColor.Equals(other.PrimaryColor)
                ) &&
                (
                    this.PrimaryColorDark == other.PrimaryColorDark ||
                    this.PrimaryColorDark != null &&
                    this.PrimaryColorDark.Equals(other.PrimaryColorDark)
                ) &&
                (
                    this.PrimaryColorLight == other.PrimaryColorLight ||
                    this.PrimaryColorLight != null &&
                    this.PrimaryColorLight.Equals(other.PrimaryColorLight)
                ) &&
                (
                    this.TextColor == other.TextColor ||
                    this.TextColor != null &&
                    this.TextColor.Equals(other.TextColor)
                ) &&
                (
                    this.FontFamily == other.FontFamily ||
                    this.FontFamily != null &&
                    this.FontFamily.Equals(other.FontFamily)
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
                
                if (this.PrimaryColor != null)
                    hash = hash * 59 + this.PrimaryColor.GetHashCode();
                
                if (this.PrimaryColorDark != null)
                    hash = hash * 59 + this.PrimaryColorDark.GetHashCode();
                
                if (this.PrimaryColorLight != null)
                    hash = hash * 59 + this.PrimaryColorLight.GetHashCode();
                
                if (this.TextColor != null)
                    hash = hash * 59 + this.TextColor.GetHashCode();
                
                if (this.FontFamily != null)
                    hash = hash * 59 + this.FontFamily.GetHashCode();
                
                return hash;
            }
        }
    }

}
