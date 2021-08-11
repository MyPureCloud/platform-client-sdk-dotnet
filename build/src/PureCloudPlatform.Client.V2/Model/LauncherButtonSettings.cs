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
    /// The settings for the launcher button
    /// </summary>
    [DataContract]
    public partial class LauncherButtonSettings :  IEquatable<LauncherButtonSettings>
    {
        
        
        /// <summary>
        /// The visibility settings for the button
        /// </summary>
        /// <value>The visibility settings for the button</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum On for "On"
            /// </summary>
            [EnumMember(Value = "On")]
            On,
            
            /// <summary>
            /// Enum Off for "Off"
            /// </summary>
            [EnumMember(Value = "Off")]
            Off,
            
            /// <summary>
            /// Enum Ondemand for "OnDemand"
            /// </summary>
            [EnumMember(Value = "OnDemand")]
            Ondemand
        }
        
        
        
        
        
        /// <summary>
        /// The visibility settings for the button
        /// </summary>
        /// <value>The visibility settings for the button</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public VisibilityEnum? Visibility { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LauncherButtonSettings" /> class.
        /// </summary>
        /// <param name="Visibility">The visibility settings for the button.</param>
        public LauncherButtonSettings(VisibilityEnum? Visibility = null)
        {
            this.Visibility = Visibility;
            
        }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LauncherButtonSettings {\n");
            
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(obj as LauncherButtonSettings);
        }

        /// <summary>
        /// Returns true if LauncherButtonSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of LauncherButtonSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LauncherButtonSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Visibility == other.Visibility ||
                    this.Visibility != null &&
                    this.Visibility.Equals(other.Visibility)
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
                
                if (this.Visibility != null)
                    hash = hash * 59 + this.Visibility.GetHashCode();
                
                return hash;
            }
        }
    }

}
