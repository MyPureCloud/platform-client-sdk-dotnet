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
    /// V2ExternalEventsContactExternalEventBody
    /// </summary>
    [DataContract]
    public partial class V2ExternalEventsContactExternalEventBody :  IEquatable<V2ExternalEventsContactExternalEventBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ExternalEventsContactExternalEventBody" /> class.
        /// </summary>
        /// <param name="ExternalContactId">ExternalContactId.</param>
        /// <param name="SchemaId">SchemaId.</param>
        /// <param name="EventId">EventId.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="Source">Source.</param>
        /// <param name="DivisionId">DivisionId.</param>
        /// <param name="Attributes">Attributes.</param>
        public V2ExternalEventsContactExternalEventBody(Guid? ExternalContactId = null, Guid? SchemaId = null, Guid? EventId = null, DateTime? CreatedDate = null, string Source = null, string DivisionId = null, Dictionary<string, Object> Attributes = null)
        {
            this.ExternalContactId = ExternalContactId;
            this.SchemaId = SchemaId;
            this.EventId = EventId;
            this.CreatedDate = CreatedDate;
            this.Source = Source;
            this.DivisionId = DivisionId;
            this.Attributes = Attributes;
            
        }
        


        /// <summary>
        /// Gets or Sets ExternalContactId
        /// </summary>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public Guid? ExternalContactId { get; set; }



        /// <summary>
        /// Gets or Sets SchemaId
        /// </summary>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public Guid? SchemaId { get; set; }



        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public Guid? EventId { get; set; }



        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }



        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }



        /// <summary>
        /// Gets or Sets DivisionId
        /// </summary>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> Attributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ExternalEventsContactExternalEventBody {\n");

            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
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
            return this.Equals(obj as V2ExternalEventsContactExternalEventBody);
        }

        /// <summary>
        /// Returns true if V2ExternalEventsContactExternalEventBody instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ExternalEventsContactExternalEventBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ExternalEventsContactExternalEventBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
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
                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                return hash;
            }
        }
    }

}
