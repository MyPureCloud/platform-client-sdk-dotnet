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
    /// TranscriptOutlineSegment
    /// </summary>
    [DataContract]
    public partial class TranscriptOutlineSegment :  IEquatable<TranscriptOutlineSegment>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOutlineSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TranscriptOutlineSegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOutlineSegment" /> class.
        /// </summary>
        /// <param name="Header">The header of the outline segment. (required).</param>
        /// <param name="Description">The description of the outline segment. (required).</param>
        /// <param name="FirstPhraseStartTimeMs">The start time of the first phrase of the segment in milliseconds. (required).</param>
        /// <param name="LastPhraseStartTimeMs">The start time of the last phrase of the segment in milliseconds. (required).</param>
        public TranscriptOutlineSegment(string Header = null, string Description = null, long? FirstPhraseStartTimeMs = null, long? LastPhraseStartTimeMs = null)
        {
            this.Header = Header;
            this.Description = Description;
            this.FirstPhraseStartTimeMs = FirstPhraseStartTimeMs;
            this.LastPhraseStartTimeMs = LastPhraseStartTimeMs;
            
        }
        


        /// <summary>
        /// The header of the outline segment.
        /// </summary>
        /// <value>The header of the outline segment.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public string Header { get; set; }



        /// <summary>
        /// The description of the outline segment.
        /// </summary>
        /// <value>The description of the outline segment.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The start time of the first phrase of the segment in milliseconds.
        /// </summary>
        /// <value>The start time of the first phrase of the segment in milliseconds.</value>
        [DataMember(Name="firstPhraseStartTimeMs", EmitDefaultValue=false)]
        public long? FirstPhraseStartTimeMs { get; set; }



        /// <summary>
        /// The start time of the last phrase of the segment in milliseconds.
        /// </summary>
        /// <value>The start time of the last phrase of the segment in milliseconds.</value>
        [DataMember(Name="lastPhraseStartTimeMs", EmitDefaultValue=false)]
        public long? LastPhraseStartTimeMs { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptOutlineSegment {\n");

            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FirstPhraseStartTimeMs: ").Append(FirstPhraseStartTimeMs).Append("\n");
            sb.Append("  LastPhraseStartTimeMs: ").Append(LastPhraseStartTimeMs).Append("\n");
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
            return this.Equals(obj as TranscriptOutlineSegment);
        }

        /// <summary>
        /// Returns true if TranscriptOutlineSegment instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptOutlineSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptOutlineSegment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Header == other.Header ||
                    this.Header != null &&
                    this.Header.Equals(other.Header)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.FirstPhraseStartTimeMs == other.FirstPhraseStartTimeMs ||
                    this.FirstPhraseStartTimeMs != null &&
                    this.FirstPhraseStartTimeMs.Equals(other.FirstPhraseStartTimeMs)
                ) &&
                (
                    this.LastPhraseStartTimeMs == other.LastPhraseStartTimeMs ||
                    this.LastPhraseStartTimeMs != null &&
                    this.LastPhraseStartTimeMs.Equals(other.LastPhraseStartTimeMs)
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
                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.FirstPhraseStartTimeMs != null)
                    hash = hash * 59 + this.FirstPhraseStartTimeMs.GetHashCode();

                if (this.LastPhraseStartTimeMs != null)
                    hash = hash * 59 + this.LastPhraseStartTimeMs.GetHashCode();

                return hash;
            }
        }
    }

}
