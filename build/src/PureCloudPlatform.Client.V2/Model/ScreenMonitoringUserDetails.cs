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
    /// ScreenMonitoringUserDetails
    /// </summary>
    [DataContract]
    public partial class ScreenMonitoringUserDetails :  IEquatable<ScreenMonitoringUserDetails>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenMonitoringUserDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScreenMonitoringUserDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenMonitoringUserDetails" /> class.
        /// </summary>
        /// <param name="Count">Count.</param>
        /// <param name="TargetUser">The user being monitored (required).</param>
        public ScreenMonitoringUserDetails(int? Count = null, AddressableEntityRef TargetUser = null)
        {
            this.Count = Count;
            this.TargetUser = TargetUser;
            
        }
        


        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }



        /// <summary>
        /// The user being monitored
        /// </summary>
        /// <value>The user being monitored</value>
        [DataMember(Name="targetUser", EmitDefaultValue=false)]
        public AddressableEntityRef TargetUser { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenMonitoringUserDetails {\n");

            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TargetUser: ").Append(TargetUser).Append("\n");
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
            return this.Equals(obj as ScreenMonitoringUserDetails);
        }

        /// <summary>
        /// Returns true if ScreenMonitoringUserDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ScreenMonitoringUserDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenMonitoringUserDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) &&
                (
                    this.TargetUser == other.TargetUser ||
                    this.TargetUser != null &&
                    this.TargetUser.Equals(other.TargetUser)
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

                if (this.TargetUser != null)
                    hash = hash * 59 + this.TargetUser.GetHashCode();

                return hash;
            }
        }
    }

}
