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
    /// UpdateUnavailableTime
    /// </summary>
    [DataContract]
    public partial class UpdateUnavailableTime :  IEquatable<UpdateUnavailableTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUnavailableTime" /> class.
        /// </summary>
        /// <param name="Id">The ID of the unavailable time span. Should be specified to update or delete an existing unavailable time span or set to null when creating a new one.</param>
        /// <param name="TimeSpan">Exact date, time and length of the unavailability time in granularity of minutes. Must be specified when creating a new unavailable time span.</param>
        /// <param name="Notes">Comments explaining the unavailability time span.</param>
        /// <param name="Delete">Whether the unavailable time should be deleted.</param>
        public UpdateUnavailableTime(string Id = null, UnavailableTimesTimeSpan TimeSpan = null, string Notes = null, bool? Delete = null)
        {
            this.Id = Id;
            this.TimeSpan = TimeSpan;
            this.Notes = Notes;
            this.Delete = Delete;
            
        }
        


        /// <summary>
        /// The ID of the unavailable time span. Should be specified to update or delete an existing unavailable time span or set to null when creating a new one
        /// </summary>
        /// <value>The ID of the unavailable time span. Should be specified to update or delete an existing unavailable time span or set to null when creating a new one</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Exact date, time and length of the unavailability time in granularity of minutes. Must be specified when creating a new unavailable time span
        /// </summary>
        /// <value>Exact date, time and length of the unavailability time in granularity of minutes. Must be specified when creating a new unavailable time span</value>
        [DataMember(Name="timeSpan", EmitDefaultValue=false)]
        public UnavailableTimesTimeSpan TimeSpan { get; set; }



        /// <summary>
        /// Comments explaining the unavailability time span
        /// </summary>
        /// <value>Comments explaining the unavailability time span</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// Whether the unavailable time should be deleted
        /// </summary>
        /// <value>Whether the unavailable time should be deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUnavailableTime {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TimeSpan: ").Append(TimeSpan).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
            return this.Equals(obj as UpdateUnavailableTime);
        }

        /// <summary>
        /// Returns true if UpdateUnavailableTime instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateUnavailableTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUnavailableTime other)
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
                    this.TimeSpan == other.TimeSpan ||
                    this.TimeSpan != null &&
                    this.TimeSpan.Equals(other.TimeSpan)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
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

                if (this.TimeSpan != null)
                    hash = hash * 59 + this.TimeSpan.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();

                return hash;
            }
        }
    }

}
