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
    /// GoogleBusinessProfileDataIngestionRuleRequest
    /// </summary>
    [DataContract]
    public partial class GoogleBusinessProfileDataIngestionRuleRequest :  IEquatable<GoogleBusinessProfileDataIngestionRuleRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleBusinessProfileDataIngestionRuleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GoogleBusinessProfileDataIngestionRuleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleBusinessProfileDataIngestionRuleRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the data ingestion rule. (required).</param>
        /// <param name="Description">A description of the data ingestion rule..</param>
        /// <param name="IntegrationId">The Integration Id from which to ingest public social posts. This entity is created using the /conversations/messaging/integrations/open/extensions/googlebusinessprofile resource (required).</param>
        /// <param name="ExternalSource">The external source associated with this data ingestion rule, which will be used when performing identity resolution (required).</param>
        public GoogleBusinessProfileDataIngestionRuleRequest(string Name = null, string Description = null, string IntegrationId = null, DomainEntityRef ExternalSource = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.IntegrationId = IntegrationId;
            this.ExternalSource = ExternalSource;
            
        }
        


        /// <summary>
        /// The name of the data ingestion rule.
        /// </summary>
        /// <value>The name of the data ingestion rule.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// A description of the data ingestion rule.
        /// </summary>
        /// <value>A description of the data ingestion rule.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The Integration Id from which to ingest public social posts. This entity is created using the /conversations/messaging/integrations/open/extensions/googlebusinessprofile resource
        /// </summary>
        /// <value>The Integration Id from which to ingest public social posts. This entity is created using the /conversations/messaging/integrations/open/extensions/googlebusinessprofile resource</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }



        /// <summary>
        /// The external source associated with this data ingestion rule, which will be used when performing identity resolution
        /// </summary>
        /// <value>The external source associated with this data ingestion rule, which will be used when performing identity resolution</value>
        [DataMember(Name="externalSource", EmitDefaultValue=false)]
        public DomainEntityRef ExternalSource { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleBusinessProfileDataIngestionRuleRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
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
            return this.Equals(obj as GoogleBusinessProfileDataIngestionRuleRequest);
        }

        /// <summary>
        /// Returns true if GoogleBusinessProfileDataIngestionRuleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GoogleBusinessProfileDataIngestionRuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleBusinessProfileDataIngestionRuleRequest other)
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
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.ExternalSource == other.ExternalSource ||
                    this.ExternalSource != null &&
                    this.ExternalSource.Equals(other.ExternalSource)
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

                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();

                if (this.ExternalSource != null)
                    hash = hash * 59 + this.ExternalSource.GetHashCode();

                return hash;
            }
        }
    }

}
