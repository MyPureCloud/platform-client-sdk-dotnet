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
    /// PhoneChangeTopicLineStatus
    /// </summary>
    [DataContract]
    public partial class PhoneChangeTopicLineStatus :  IEquatable<PhoneChangeTopicLineStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneChangeTopicLineStatus" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Reachable">Reachable.</param>
        /// <param name="AddressOfRecord">AddressOfRecord.</param>
        /// <param name="ContactAddresses">ContactAddresses.</param>
        /// <param name="ReachableStateTime">ReachableStateTime.</param>
        public PhoneChangeTopicLineStatus(string Id = null, bool? Reachable = null, string AddressOfRecord = null, List<string> ContactAddresses = null, DateTime? ReachableStateTime = null)
        {
            this.Id = Id;
            this.Reachable = Reachable;
            this.AddressOfRecord = AddressOfRecord;
            this.ContactAddresses = ContactAddresses;
            this.ReachableStateTime = ReachableStateTime;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Reachable
        /// </summary>
        [DataMember(Name="reachable", EmitDefaultValue=false)]
        public bool? Reachable { get; set; }



        /// <summary>
        /// Gets or Sets AddressOfRecord
        /// </summary>
        [DataMember(Name="addressOfRecord", EmitDefaultValue=false)]
        public string AddressOfRecord { get; set; }



        /// <summary>
        /// Gets or Sets ContactAddresses
        /// </summary>
        [DataMember(Name="contactAddresses", EmitDefaultValue=false)]
        public List<string> ContactAddresses { get; set; }



        /// <summary>
        /// Gets or Sets ReachableStateTime
        /// </summary>
        [DataMember(Name="reachableStateTime", EmitDefaultValue=false)]
        public DateTime? ReachableStateTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneChangeTopicLineStatus {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reachable: ").Append(Reachable).Append("\n");
            sb.Append("  AddressOfRecord: ").Append(AddressOfRecord).Append("\n");
            sb.Append("  ContactAddresses: ").Append(ContactAddresses).Append("\n");
            sb.Append("  ReachableStateTime: ").Append(ReachableStateTime).Append("\n");
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
            return this.Equals(obj as PhoneChangeTopicLineStatus);
        }

        /// <summary>
        /// Returns true if PhoneChangeTopicLineStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneChangeTopicLineStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneChangeTopicLineStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Reachable == other.Reachable ||
                    this.Reachable != null &&
                    this.Reachable.Equals(other.Reachable)
                ) &&
                (
                    this.AddressOfRecord == other.AddressOfRecord ||
                    this.AddressOfRecord != null &&
                    this.AddressOfRecord.Equals(other.AddressOfRecord)
                ) &&
                (
                    this.ContactAddresses == other.ContactAddresses ||
                    this.ContactAddresses != null &&
                    this.ContactAddresses.SequenceEqual(other.ContactAddresses)
                ) &&
                (
                    this.ReachableStateTime == other.ReachableStateTime ||
                    this.ReachableStateTime != null &&
                    this.ReachableStateTime.Equals(other.ReachableStateTime)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Reachable != null)
                    hash = hash * 59 + this.Reachable.GetHashCode();

                if (this.AddressOfRecord != null)
                    hash = hash * 59 + this.AddressOfRecord.GetHashCode();

                if (this.ContactAddresses != null)
                    hash = hash * 59 + this.ContactAddresses.GetHashCode();

                if (this.ReachableStateTime != null)
                    hash = hash * 59 + this.ReachableStateTime.GetHashCode();

                return hash;
            }
        }
    }

}
