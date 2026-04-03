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
    /// ExternalEventsResponse
    /// </summary>
    [DataContract]
    public partial class ExternalEventsResponse :  IEquatable<ExternalEventsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEventsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalEventsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEventsResponse" /> class.
        /// </summary>
        /// <param name="UnprocessedEntities">List of events that failed processing. (required).</param>
        public ExternalEventsResponse(List<UnprocessedExternalEvent> UnprocessedEntities = null)
        {
            this.UnprocessedEntities = UnprocessedEntities;
            
        }
        


        /// <summary>
        /// List of events that failed processing.
        /// </summary>
        /// <value>List of events that failed processing.</value>
        [DataMember(Name="unprocessedEntities", EmitDefaultValue=false)]
        public List<UnprocessedExternalEvent> UnprocessedEntities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalEventsResponse {\n");

            sb.Append("  UnprocessedEntities: ").Append(UnprocessedEntities).Append("\n");
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
            return this.Equals(obj as ExternalEventsResponse);
        }

        /// <summary>
        /// Returns true if ExternalEventsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalEventsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalEventsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UnprocessedEntities == other.UnprocessedEntities ||
                    this.UnprocessedEntities != null &&
                    this.UnprocessedEntities.SequenceEqual(other.UnprocessedEntities)
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
                if (this.UnprocessedEntities != null)
                    hash = hash * 59 + this.UnprocessedEntities.GetHashCode();

                return hash;
            }
        }
    }

}
