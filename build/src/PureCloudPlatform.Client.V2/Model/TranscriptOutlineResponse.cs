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
    /// TranscriptOutlineResponse
    /// </summary>
    [DataContract]
    public partial class TranscriptOutlineResponse :  IEquatable<TranscriptOutlineResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOutlineResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TranscriptOutlineResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOutlineResponse" /> class.
        /// </summary>
        /// <param name="Segments">The list of outline segments for the communication (required).</param>
        public TranscriptOutlineResponse(List<TranscriptOutlineSegment> Segments = null)
        {
            this.Segments = Segments;
            
        }
        


        /// <summary>
        /// The list of outline segments for the communication
        /// </summary>
        /// <value>The list of outline segments for the communication</value>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<TranscriptOutlineSegment> Segments { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptOutlineResponse {\n");

            sb.Append("  Segments: ").Append(Segments).Append("\n");
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
            return this.Equals(obj as TranscriptOutlineResponse);
        }

        /// <summary>
        /// Returns true if TranscriptOutlineResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptOutlineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptOutlineResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Segments == other.Segments ||
                    this.Segments != null &&
                    this.Segments.SequenceEqual(other.Segments)
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
                if (this.Segments != null)
                    hash = hash * 59 + this.Segments.GetHashCode();

                return hash;
            }
        }
    }

}
