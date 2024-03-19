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
    /// ScreenRecordingActiveSessions
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingActiveSessions :  IEquatable<ScreenRecordingActiveSessions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingActiveSessions" /> class.
        /// </summary>
        /// <param name="Count">Current concurrent active screen recordings count for organization.</param>
        public ScreenRecordingActiveSessions(int? Count = null)
        {
            this.Count = Count;
            
        }
        


        /// <summary>
        /// Current concurrent active screen recordings count for organization
        /// </summary>
        /// <value>Current concurrent active screen recordings count for organization</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingActiveSessions {\n");

            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as ScreenRecordingActiveSessions);
        }

        /// <summary>
        /// Returns true if ScreenRecordingActiveSessions instances are equal
        /// </summary>
        /// <param name="other">Instance of ScreenRecordingActiveSessions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingActiveSessions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
