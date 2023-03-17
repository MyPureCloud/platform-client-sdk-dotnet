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
    /// RestorePresenceSettings
    /// </summary>
    [DataContract]
    public partial class RestorePresenceSettings :  IEquatable<RestorePresenceSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePresenceSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestorePresenceSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestorePresenceSettings" /> class.
        /// </summary>
        /// <param name="Enabled">Whether the restore presence feature is enabled (required).</param>
        /// <param name="RestoreTimeMilliseconds">How many milliseconds the presence will be restored within (required).</param>
        /// <param name="RestoreOnQueueEnabled">Whether the ON_QUEUE presence will be restored (required).</param>
        public RestorePresenceSettings(bool? Enabled = null, long? RestoreTimeMilliseconds = null, bool? RestoreOnQueueEnabled = null)
        {
            this.Enabled = Enabled;
            this.RestoreTimeMilliseconds = RestoreTimeMilliseconds;
            this.RestoreOnQueueEnabled = RestoreOnQueueEnabled;
            
        }
        


        /// <summary>
        /// Whether the restore presence feature is enabled
        /// </summary>
        /// <value>Whether the restore presence feature is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// How many milliseconds the presence will be restored within
        /// </summary>
        /// <value>How many milliseconds the presence will be restored within</value>
        [DataMember(Name="restoreTimeMilliseconds", EmitDefaultValue=false)]
        public long? RestoreTimeMilliseconds { get; set; }



        /// <summary>
        /// Whether the ON_QUEUE presence will be restored
        /// </summary>
        /// <value>Whether the ON_QUEUE presence will be restored</value>
        [DataMember(Name="restoreOnQueueEnabled", EmitDefaultValue=false)]
        public bool? RestoreOnQueueEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestorePresenceSettings {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  RestoreTimeMilliseconds: ").Append(RestoreTimeMilliseconds).Append("\n");
            sb.Append("  RestoreOnQueueEnabled: ").Append(RestoreOnQueueEnabled).Append("\n");
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
            return this.Equals(obj as RestorePresenceSettings);
        }

        /// <summary>
        /// Returns true if RestorePresenceSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of RestorePresenceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestorePresenceSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.RestoreTimeMilliseconds == other.RestoreTimeMilliseconds ||
                    this.RestoreTimeMilliseconds != null &&
                    this.RestoreTimeMilliseconds.Equals(other.RestoreTimeMilliseconds)
                ) &&
                (
                    this.RestoreOnQueueEnabled == other.RestoreOnQueueEnabled ||
                    this.RestoreOnQueueEnabled != null &&
                    this.RestoreOnQueueEnabled.Equals(other.RestoreOnQueueEnabled)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.RestoreTimeMilliseconds != null)
                    hash = hash * 59 + this.RestoreTimeMilliseconds.GetHashCode();

                if (this.RestoreOnQueueEnabled != null)
                    hash = hash * 59 + this.RestoreOnQueueEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
