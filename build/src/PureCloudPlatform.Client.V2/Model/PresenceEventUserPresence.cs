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
    /// PresenceEventUserPresence
    /// </summary>
    [DataContract]
    public partial class PresenceEventUserPresence :  IEquatable<PresenceEventUserPresence>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceEventUserPresence" /> class.
        /// </summary>
        /// <param name="Source">Source.</param>
        /// <param name="PresenceDefinition">PresenceDefinition.</param>
        /// <param name="Primary">Primary.</param>
        /// <param name="Message">Message.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        /// <param name="FuturePresenceDefinition">FuturePresenceDefinition.</param>
        public PresenceEventUserPresence(string Source = null, PresenceEventOrganizationPresence PresenceDefinition = null, bool? Primary = null, string Message = null, DateTime? ModifiedDate = null, PresenceEventOrganizationPresence FuturePresenceDefinition = null)
        {
            this.Source = Source;
            this.PresenceDefinition = PresenceDefinition;
            this.Primary = Primary;
            this.Message = Message;
            this.ModifiedDate = ModifiedDate;
            this.FuturePresenceDefinition = FuturePresenceDefinition;
            
        }
        


        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }



        /// <summary>
        /// Gets or Sets PresenceDefinition
        /// </summary>
        [DataMember(Name="presenceDefinition", EmitDefaultValue=false)]
        public PresenceEventOrganizationPresence PresenceDefinition { get; set; }



        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }



        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }



        /// <summary>
        /// Gets or Sets FuturePresenceDefinition
        /// </summary>
        [DataMember(Name="futurePresenceDefinition", EmitDefaultValue=false)]
        public PresenceEventOrganizationPresence FuturePresenceDefinition { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PresenceEventUserPresence {\n");

            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  FuturePresenceDefinition: ").Append(FuturePresenceDefinition).Append("\n");
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
            return this.Equals(obj as PresenceEventUserPresence);
        }

        /// <summary>
        /// Returns true if PresenceEventUserPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of PresenceEventUserPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenceEventUserPresence other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.PresenceDefinition == other.PresenceDefinition ||
                    this.PresenceDefinition != null &&
                    this.PresenceDefinition.Equals(other.PresenceDefinition)
                ) &&
                (
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.FuturePresenceDefinition == other.FuturePresenceDefinition ||
                    this.FuturePresenceDefinition != null &&
                    this.FuturePresenceDefinition.Equals(other.FuturePresenceDefinition)
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
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.PresenceDefinition != null)
                    hash = hash * 59 + this.PresenceDefinition.GetHashCode();

                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();

                if (this.FuturePresenceDefinition != null)
                    hash = hash * 59 + this.FuturePresenceDefinition.GetHashCode();

                return hash;
            }
        }
    }

}
