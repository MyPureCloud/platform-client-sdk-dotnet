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
    /// CreateExternalEventsConfigurationRequest
    /// </summary>
    [DataContract]
    public partial class CreateExternalEventsConfigurationRequest :  IEquatable<CreateExternalEventsConfigurationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExternalEventsConfigurationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateExternalEventsConfigurationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExternalEventsConfigurationRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the external event configuration. (required).</param>
        /// <param name="Description">A description of the external event configuration. (required).</param>
        /// <param name="DivisionId">The division ID associated with this configuration. (required).</param>
        /// <param name="SchemaId">The dynamic schema ID that defines the structure of external events. (required).</param>
        /// <param name="Source">The source of the external events e.g. Adobe, Salesforce. This cannot be changed after creation. (required).</param>
        public CreateExternalEventsConfigurationRequest(string Name = null, string Description = null, string DivisionId = null, string SchemaId = null, string Source = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.DivisionId = DivisionId;
            this.SchemaId = SchemaId;
            this.Source = Source;
            
        }
        


        /// <summary>
        /// The name of the external event configuration.
        /// </summary>
        /// <value>The name of the external event configuration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// A description of the external event configuration.
        /// </summary>
        /// <value>A description of the external event configuration.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The division ID associated with this configuration.
        /// </summary>
        /// <value>The division ID associated with this configuration.</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// The dynamic schema ID that defines the structure of external events.
        /// </summary>
        /// <value>The dynamic schema ID that defines the structure of external events.</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public string SchemaId { get; set; }



        /// <summary>
        /// The source of the external events e.g. Adobe, Salesforce. This cannot be changed after creation.
        /// </summary>
        /// <value>The source of the external events e.g. Adobe, Salesforce. This cannot be changed after creation.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateExternalEventsConfigurationRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as CreateExternalEventsConfigurationRequest);
        }

        /// <summary>
        /// Returns true if CreateExternalEventsConfigurationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateExternalEventsConfigurationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateExternalEventsConfigurationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                return hash;
            }
        }
    }

}
