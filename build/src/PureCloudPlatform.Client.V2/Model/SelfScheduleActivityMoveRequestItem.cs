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
    /// SelfScheduleActivityMoveRequestItem
    /// </summary>
    [DataContract]
    public partial class SelfScheduleActivityMoveRequestItem :  IEquatable<SelfScheduleActivityMoveRequestItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleActivityMoveRequestItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelfScheduleActivityMoveRequestItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleActivityMoveRequestItem" /> class.
        /// </summary>
        /// <param name="OfferJobId">The ID of the self-schedule offers job (required).</param>
        /// <param name="ReferenceKey">Unique identifier from the offer for an activity whose start time the user wants to change (required).</param>
        /// <param name="NewDate">The new date/time for the activity in ISO-8601 format (required).</param>
        public SelfScheduleActivityMoveRequestItem(string OfferJobId = null, string ReferenceKey = null, DateTime? NewDate = null)
        {
            this.OfferJobId = OfferJobId;
            this.ReferenceKey = ReferenceKey;
            this.NewDate = NewDate;
            
        }
        


        /// <summary>
        /// The ID of the self-schedule offers job
        /// </summary>
        /// <value>The ID of the self-schedule offers job</value>
        [DataMember(Name="offerJobId", EmitDefaultValue=false)]
        public string OfferJobId { get; set; }



        /// <summary>
        /// Unique identifier from the offer for an activity whose start time the user wants to change
        /// </summary>
        /// <value>Unique identifier from the offer for an activity whose start time the user wants to change</value>
        [DataMember(Name="referenceKey", EmitDefaultValue=false)]
        public string ReferenceKey { get; set; }



        /// <summary>
        /// The new date/time for the activity in ISO-8601 format
        /// </summary>
        /// <value>The new date/time for the activity in ISO-8601 format</value>
        [DataMember(Name="newDate", EmitDefaultValue=false)]
        public DateTime? NewDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelfScheduleActivityMoveRequestItem {\n");

            sb.Append("  OfferJobId: ").Append(OfferJobId).Append("\n");
            sb.Append("  ReferenceKey: ").Append(ReferenceKey).Append("\n");
            sb.Append("  NewDate: ").Append(NewDate).Append("\n");
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
            return this.Equals(obj as SelfScheduleActivityMoveRequestItem);
        }

        /// <summary>
        /// Returns true if SelfScheduleActivityMoveRequestItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SelfScheduleActivityMoveRequestItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelfScheduleActivityMoveRequestItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OfferJobId == other.OfferJobId ||
                    this.OfferJobId != null &&
                    this.OfferJobId.Equals(other.OfferJobId)
                ) &&
                (
                    this.ReferenceKey == other.ReferenceKey ||
                    this.ReferenceKey != null &&
                    this.ReferenceKey.Equals(other.ReferenceKey)
                ) &&
                (
                    this.NewDate == other.NewDate ||
                    this.NewDate != null &&
                    this.NewDate.Equals(other.NewDate)
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
                if (this.OfferJobId != null)
                    hash = hash * 59 + this.OfferJobId.GetHashCode();

                if (this.ReferenceKey != null)
                    hash = hash * 59 + this.ReferenceKey.GetHashCode();

                if (this.NewDate != null)
                    hash = hash * 59 + this.NewDate.GetHashCode();

                return hash;
            }
        }
    }

}
