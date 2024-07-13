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
    /// GroupSettings
    /// </summary>
    [DataContract]
    public partial class GroupSettings :  IEquatable<GroupSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSettings" /> class.
        /// </summary>
        /// <param name="MinimumGroupSize">The minimum size of a group for a session.</param>
        /// <param name="MaximumGroupSize">The maximum size of a group for a session.</param>
        /// <param name="MaximumTotalSessions">The maximum total number of sessions.</param>
        /// <param name="MaximumConcurrentSessions">The maximum number of sessions that can be scheduled concurrently.</param>
        public GroupSettings(int? MinimumGroupSize = null, int? MaximumGroupSize = null, int? MaximumTotalSessions = null, int? MaximumConcurrentSessions = null)
        {
            this.MinimumGroupSize = MinimumGroupSize;
            this.MaximumGroupSize = MaximumGroupSize;
            this.MaximumTotalSessions = MaximumTotalSessions;
            this.MaximumConcurrentSessions = MaximumConcurrentSessions;
            
        }
        


        /// <summary>
        /// The minimum size of a group for a session
        /// </summary>
        /// <value>The minimum size of a group for a session</value>
        [DataMember(Name="minimumGroupSize", EmitDefaultValue=false)]
        public int? MinimumGroupSize { get; set; }



        /// <summary>
        /// The maximum size of a group for a session
        /// </summary>
        /// <value>The maximum size of a group for a session</value>
        [DataMember(Name="maximumGroupSize", EmitDefaultValue=false)]
        public int? MaximumGroupSize { get; set; }



        /// <summary>
        /// The maximum total number of sessions
        /// </summary>
        /// <value>The maximum total number of sessions</value>
        [DataMember(Name="maximumTotalSessions", EmitDefaultValue=false)]
        public int? MaximumTotalSessions { get; set; }



        /// <summary>
        /// The maximum number of sessions that can be scheduled concurrently
        /// </summary>
        /// <value>The maximum number of sessions that can be scheduled concurrently</value>
        [DataMember(Name="maximumConcurrentSessions", EmitDefaultValue=false)]
        public int? MaximumConcurrentSessions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSettings {\n");

            sb.Append("  MinimumGroupSize: ").Append(MinimumGroupSize).Append("\n");
            sb.Append("  MaximumGroupSize: ").Append(MaximumGroupSize).Append("\n");
            sb.Append("  MaximumTotalSessions: ").Append(MaximumTotalSessions).Append("\n");
            sb.Append("  MaximumConcurrentSessions: ").Append(MaximumConcurrentSessions).Append("\n");
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
            return this.Equals(obj as GroupSettings);
        }

        /// <summary>
        /// Returns true if GroupSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MinimumGroupSize == other.MinimumGroupSize ||
                    this.MinimumGroupSize != null &&
                    this.MinimumGroupSize.Equals(other.MinimumGroupSize)
                ) &&
                (
                    this.MaximumGroupSize == other.MaximumGroupSize ||
                    this.MaximumGroupSize != null &&
                    this.MaximumGroupSize.Equals(other.MaximumGroupSize)
                ) &&
                (
                    this.MaximumTotalSessions == other.MaximumTotalSessions ||
                    this.MaximumTotalSessions != null &&
                    this.MaximumTotalSessions.Equals(other.MaximumTotalSessions)
                ) &&
                (
                    this.MaximumConcurrentSessions == other.MaximumConcurrentSessions ||
                    this.MaximumConcurrentSessions != null &&
                    this.MaximumConcurrentSessions.Equals(other.MaximumConcurrentSessions)
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
                if (this.MinimumGroupSize != null)
                    hash = hash * 59 + this.MinimumGroupSize.GetHashCode();

                if (this.MaximumGroupSize != null)
                    hash = hash * 59 + this.MaximumGroupSize.GetHashCode();

                if (this.MaximumTotalSessions != null)
                    hash = hash * 59 + this.MaximumTotalSessions.GetHashCode();

                if (this.MaximumConcurrentSessions != null)
                    hash = hash * 59 + this.MaximumConcurrentSessions.GetHashCode();

                return hash;
            }
        }
    }

}
