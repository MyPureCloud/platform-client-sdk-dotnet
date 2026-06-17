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
    /// AgentEffectiveBid
    /// </summary>
    [DataContract]
    public partial class AgentEffectiveBid :  IEquatable<AgentEffectiveBid>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEffectiveBid" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentEffectiveBid() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEffectiveBid" /> class.
        /// </summary>
        /// <param name="Id">The ID of the schedule bid (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="EffectiveDate">The effective date of the bid relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="EndDate">The end date of the bid, relative to the business unit time zone in yyyy-MM-dd format. Null denotes an active schedule bid. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DownloadUrl">The download URL to fetch the list of schedule sets and the agents assigned to them (required).</param>
        /// <param name="DownloadTemplate">This field will always be null. Effective schedule sets are returned through the download URL. The schema is included here for documentation purposes.</param>
        public AgentEffectiveBid(string Id = null, string Name = null, String EffectiveDate = null, String EndDate = null, string DownloadUrl = null, AgentAssignedScheduleSetList DownloadTemplate = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.EffectiveDate = EffectiveDate;
            this.EndDate = EndDate;
            this.DownloadUrl = DownloadUrl;
            this.DownloadTemplate = DownloadTemplate;
            
        }
        


        /// <summary>
        /// The ID of the schedule bid
        /// </summary>
        /// <value>The ID of the schedule bid</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The effective date of the bid relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The effective date of the bid relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public String EffectiveDate { get; set; }



        /// <summary>
        /// The end date of the bid, relative to the business unit time zone in yyyy-MM-dd format. Null denotes an active schedule bid. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The end date of the bid, relative to the business unit time zone in yyyy-MM-dd format. Null denotes an active schedule bid. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public String EndDate { get; set; }



        /// <summary>
        /// The download URL to fetch the list of schedule sets and the agents assigned to them
        /// </summary>
        /// <value>The download URL to fetch the list of schedule sets and the agents assigned to them</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// This field will always be null. Effective schedule sets are returned through the download URL. The schema is included here for documentation purposes
        /// </summary>
        /// <value>This field will always be null. Effective schedule sets are returned through the download URL. The schema is included here for documentation purposes</value>
        [DataMember(Name="downloadTemplate", EmitDefaultValue=false)]
        public AgentAssignedScheduleSetList DownloadTemplate { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentEffectiveBid {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  DownloadTemplate: ").Append(DownloadTemplate).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as AgentEffectiveBid);
        }

        /// <summary>
        /// Returns true if AgentEffectiveBid instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentEffectiveBid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentEffectiveBid other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.DownloadTemplate == other.DownloadTemplate ||
                    this.DownloadTemplate != null &&
                    this.DownloadTemplate.Equals(other.DownloadTemplate)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.DownloadTemplate != null)
                    hash = hash * 59 + this.DownloadTemplate.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
