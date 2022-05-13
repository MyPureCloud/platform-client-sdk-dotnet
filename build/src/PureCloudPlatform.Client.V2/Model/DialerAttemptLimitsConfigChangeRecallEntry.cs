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
    /// DialerAttemptLimitsConfigChangeRecallEntry
    /// </summary>
    [DataContract]
    public partial class DialerAttemptLimitsConfigChangeRecallEntry :  IEquatable<DialerAttemptLimitsConfigChangeRecallEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAttemptLimitsConfigChangeRecallEntry" /> class.
        /// </summary>
        /// <param name="NbrAttempts">The number of recall attempts to make.</param>
        /// <param name="MinutesBetweenAttempts">How long to wait between recall attempts.</param>
        public DialerAttemptLimitsConfigChangeRecallEntry(int? NbrAttempts = null, int? MinutesBetweenAttempts = null)
        {
            this.NbrAttempts = NbrAttempts;
            this.MinutesBetweenAttempts = MinutesBetweenAttempts;
            
        }
        


        /// <summary>
        /// The number of recall attempts to make
        /// </summary>
        /// <value>The number of recall attempts to make</value>
        [DataMember(Name="nbrAttempts", EmitDefaultValue=false)]
        public int? NbrAttempts { get; set; }



        /// <summary>
        /// How long to wait between recall attempts
        /// </summary>
        /// <value>How long to wait between recall attempts</value>
        [DataMember(Name="minutesBetweenAttempts", EmitDefaultValue=false)]
        public int? MinutesBetweenAttempts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerAttemptLimitsConfigChangeRecallEntry {\n");

            sb.Append("  NbrAttempts: ").Append(NbrAttempts).Append("\n");
            sb.Append("  MinutesBetweenAttempts: ").Append(MinutesBetweenAttempts).Append("\n");
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
            return this.Equals(obj as DialerAttemptLimitsConfigChangeRecallEntry);
        }

        /// <summary>
        /// Returns true if DialerAttemptLimitsConfigChangeRecallEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerAttemptLimitsConfigChangeRecallEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerAttemptLimitsConfigChangeRecallEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NbrAttempts == other.NbrAttempts ||
                    this.NbrAttempts != null &&
                    this.NbrAttempts.Equals(other.NbrAttempts)
                ) &&
                (
                    this.MinutesBetweenAttempts == other.MinutesBetweenAttempts ||
                    this.MinutesBetweenAttempts != null &&
                    this.MinutesBetweenAttempts.Equals(other.MinutesBetweenAttempts)
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
                if (this.NbrAttempts != null)
                    hash = hash * 59 + this.NbrAttempts.GetHashCode();

                if (this.MinutesBetweenAttempts != null)
                    hash = hash * 59 + this.MinutesBetweenAttempts.GetHashCode();

                return hash;
            }
        }
    }

}
