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
    /// SupportCenterStyleSetting
    /// </summary>
    [DataContract]
    public partial class SupportCenterStyleSetting :  IEquatable<SupportCenterStyleSetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterStyleSetting" /> class.
        /// </summary>
        /// <param name="HeroStyle">Support center hero customizations.</param>
        /// <param name="GlobalStyle">Support center global customizations.</param>
        public SupportCenterStyleSetting(SupportCenterHeroStyle HeroStyle = null, SupportCenterGlobalStyle GlobalStyle = null)
        {
            this.HeroStyle = HeroStyle;
            this.GlobalStyle = GlobalStyle;
            
        }
        


        /// <summary>
        /// Support center hero customizations
        /// </summary>
        /// <value>Support center hero customizations</value>
        [DataMember(Name="heroStyle", EmitDefaultValue=false)]
        public SupportCenterHeroStyle HeroStyle { get; set; }



        /// <summary>
        /// Support center global customizations
        /// </summary>
        /// <value>Support center global customizations</value>
        [DataMember(Name="globalStyle", EmitDefaultValue=false)]
        public SupportCenterGlobalStyle GlobalStyle { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterStyleSetting {\n");

            sb.Append("  HeroStyle: ").Append(HeroStyle).Append("\n");
            sb.Append("  GlobalStyle: ").Append(GlobalStyle).Append("\n");
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
            return this.Equals(obj as SupportCenterStyleSetting);
        }

        /// <summary>
        /// Returns true if SupportCenterStyleSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterStyleSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterStyleSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.HeroStyle == other.HeroStyle ||
                    this.HeroStyle != null &&
                    this.HeroStyle.Equals(other.HeroStyle)
                ) &&
                (
                    this.GlobalStyle == other.GlobalStyle ||
                    this.GlobalStyle != null &&
                    this.GlobalStyle.Equals(other.GlobalStyle)
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
                if (this.HeroStyle != null)
                    hash = hash * 59 + this.HeroStyle.GetHashCode();

                if (this.GlobalStyle != null)
                    hash = hash * 59 + this.GlobalStyle.GetHashCode();

                return hash;
            }
        }
    }

}
