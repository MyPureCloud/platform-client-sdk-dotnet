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
    /// ExternalEvent
    /// </summary>
    [DataContract]
    public partial class ExternalEvent :  IEquatable<ExternalEvent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEvent" /> class.
        /// </summary>
        /// <param name="Id">The ID of the event. (required).</param>
        /// <param name="DateCreated">Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Identifiers">The identifiers of the contact the event is for. (required).</param>
        /// <param name="Attributes">The event attributes. (required).</param>
        public ExternalEvent(string Id = null, DateTime? DateCreated = null, ExternalEventIdentifiers Identifiers = null, Dictionary<string, Object> Attributes = null)
        {
            this.Id = Id;
            this.DateCreated = DateCreated;
            this.Identifiers = Identifiers;
            this.Attributes = Attributes;
            
        }
        


        /// <summary>
        /// The ID of the event.
        /// </summary>
        /// <value>The ID of the event.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The identifiers of the contact the event is for.
        /// </summary>
        /// <value>The identifiers of the contact the event is for.</value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public ExternalEventIdentifiers Identifiers { get; set; }



        /// <summary>
        /// The event attributes.
        /// </summary>
        /// <value>The event attributes.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> Attributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalEvent {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as ExternalEvent);
        }

        /// <summary>
        /// Returns true if ExternalEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalEvent other)
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
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.Identifiers == other.Identifiers ||
                    this.Identifiers != null &&
                    this.Identifiers.Equals(other.Identifiers)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
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

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.Identifiers != null)
                    hash = hash * 59 + this.Identifiers.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                return hash;
            }
        }
    }

}
