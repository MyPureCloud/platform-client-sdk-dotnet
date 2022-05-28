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
    /// ExtendedWrapup
    /// </summary>
    [DataContract]
    public partial class ExtendedWrapup :  IEquatable<ExtendedWrapup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedWrapup" /> class.
        /// </summary>
        /// <param name="Code">The user configured wrap up code id..</param>
        /// <param name="Name">The user configured wrap up code name..</param>
        /// <param name="Notes">Text entered by the agent to describe the call or disposition..</param>
        /// <param name="Tags">List of tags selected by the agent to describe the call or disposition..</param>
        /// <param name="DurationSeconds">The length of time in seconds that the agent spent doing after call work..</param>
        /// <param name="EndTime">The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Provisional">Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later..</param>
        /// <param name="DisableEndTimeUpdates">Prevent updates to wrapup end time when set to true..</param>
        public ExtendedWrapup(string Code = null, string Name = null, string Notes = null, List<string> Tags = null, int? DurationSeconds = null, DateTime? EndTime = null, bool? Provisional = null, bool? DisableEndTimeUpdates = null)
        {
            this.Code = Code;
            this.Name = Name;
            this.Notes = Notes;
            this.Tags = Tags;
            this.DurationSeconds = DurationSeconds;
            this.EndTime = EndTime;
            this.Provisional = Provisional;
            this.DisableEndTimeUpdates = DisableEndTimeUpdates;
            
        }
        


        /// <summary>
        /// The user configured wrap up code id.
        /// </summary>
        /// <value>The user configured wrap up code id.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// The user configured wrap up code name.
        /// </summary>
        /// <value>The user configured wrap up code name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Text entered by the agent to describe the call or disposition.
        /// </summary>
        /// <value>Text entered by the agent to describe the call or disposition.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// List of tags selected by the agent to describe the call or disposition.
        /// </summary>
        /// <value>List of tags selected by the agent to describe the call or disposition.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// The length of time in seconds that the agent spent doing after call work.
        /// </summary>
        /// <value>The length of time in seconds that the agent spent doing after call work.</value>
        [DataMember(Name="durationSeconds", EmitDefaultValue=false)]
        public int? DurationSeconds { get; set; }



        /// <summary>
        /// The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }



        /// <summary>
        /// Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later.
        /// </summary>
        /// <value>Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later.</value>
        [DataMember(Name="provisional", EmitDefaultValue=false)]
        public bool? Provisional { get; set; }



        /// <summary>
        /// Prevent updates to wrapup end time when set to true.
        /// </summary>
        /// <value>Prevent updates to wrapup end time when set to true.</value>
        [DataMember(Name="disableEndTimeUpdates", EmitDefaultValue=false)]
        public bool? DisableEndTimeUpdates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendedWrapup {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Provisional: ").Append(Provisional).Append("\n");
            sb.Append("  DisableEndTimeUpdates: ").Append(DisableEndTimeUpdates).Append("\n");
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
            return this.Equals(obj as ExtendedWrapup);
        }

        /// <summary>
        /// Returns true if ExtendedWrapup instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtendedWrapup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendedWrapup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.DurationSeconds == other.DurationSeconds ||
                    this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(other.DurationSeconds)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.Provisional == other.Provisional ||
                    this.Provisional != null &&
                    this.Provisional.Equals(other.Provisional)
                ) &&
                (
                    this.DisableEndTimeUpdates == other.DisableEndTimeUpdates ||
                    this.DisableEndTimeUpdates != null &&
                    this.DisableEndTimeUpdates.Equals(other.DisableEndTimeUpdates)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.DurationSeconds != null)
                    hash = hash * 59 + this.DurationSeconds.GetHashCode();

                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();

                if (this.Provisional != null)
                    hash = hash * 59 + this.Provisional.GetHashCode();

                if (this.DisableEndTimeUpdates != null)
                    hash = hash * 59 + this.DisableEndTimeUpdates.GetHashCode();

                return hash;
            }
        }
    }

}
