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
    /// RecordingSettings
    /// </summary>
    [DataContract]
    public partial class RecordingSettings :  IEquatable<RecordingSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingSettings" /> class.
        /// </summary>
        /// <param name="MaxSimultaneousStreams">MaxSimultaneousStreams.</param>
        public RecordingSettings(int? MaxSimultaneousStreams = null)
        {
            this.MaxSimultaneousStreams = MaxSimultaneousStreams;
        }
        
        /// <summary>
        /// Gets or Sets MaxSimultaneousStreams
        /// </summary>
        [DataMember(Name="maxSimultaneousStreams", EmitDefaultValue=false)]
        public int? MaxSimultaneousStreams { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingSettings {\n");
            sb.Append("  MaxSimultaneousStreams: ").Append(MaxSimultaneousStreams).Append("\n");
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
            return this.Equals(obj as RecordingSettings);
        }

        /// <summary>
        /// Returns true if RecordingSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MaxSimultaneousStreams == other.MaxSimultaneousStreams ||
                    this.MaxSimultaneousStreams != null &&
                    this.MaxSimultaneousStreams.Equals(other.MaxSimultaneousStreams)
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
                if (this.MaxSimultaneousStreams != null)
                    hash = hash * 59 + this.MaxSimultaneousStreams.GetHashCode();
                return hash;
            }
        }
    }

}
