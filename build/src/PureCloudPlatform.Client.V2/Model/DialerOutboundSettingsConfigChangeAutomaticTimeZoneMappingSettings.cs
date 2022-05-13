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
    /// The settings for automatic time zone mapping
    /// </summary>
    [DataContract]
    public partial class DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings :  IEquatable<DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings" /> class.
        /// </summary>
        /// <param name="CallableWindows">The time intervals to use for automatic time zone mapping.</param>
        public DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings(List<DialerOutboundSettingsConfigChangeCallableWindow> CallableWindows = null)
        {
            this.CallableWindows = CallableWindows;
            
        }
        


        /// <summary>
        /// The time intervals to use for automatic time zone mapping
        /// </summary>
        /// <value>The time intervals to use for automatic time zone mapping</value>
        [DataMember(Name="callableWindows", EmitDefaultValue=false)]
        public List<DialerOutboundSettingsConfigChangeCallableWindow> CallableWindows { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings {\n");

            sb.Append("  CallableWindows: ").Append(CallableWindows).Append("\n");
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
            return this.Equals(obj as DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings);
        }

        /// <summary>
        /// Returns true if DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallableWindows == other.CallableWindows ||
                    this.CallableWindows != null &&
                    this.CallableWindows.SequenceEqual(other.CallableWindows)
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
                if (this.CallableWindows != null)
                    hash = hash * 59 + this.CallableWindows.GetHashCode();

                return hash;
            }
        }
    }

}
