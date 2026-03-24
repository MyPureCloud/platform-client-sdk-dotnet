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
    /// CaseplanCreate
    /// </summary>
    [DataContract]
    public partial class CaseplanCreate :  IEquatable<CaseplanCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseplanCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseplanCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseplanCreate" /> class.
        /// </summary>
        /// <param name="Name">The name of the Caseplan. Valid length between 3 and 256 characters. (required).</param>
        /// <param name="DefaultDueDurationInSeconds">The default due duration in seconds for Cases created from the Caseplan. Valid range is between 1 and 31536000 seconds..</param>
        /// <param name="DefaultTtlSeconds">The default TTL in seconds for Cases created from the Caseplan. Valid range is between 86400 and 31536000 seconds..</param>
        /// <param name="ReferencePrefix">The prefix of the Caseplan reference. Valid length between 2 and 8 alphanumeric characters. (required).</param>
        /// <param name="CustomerIntentId">The ID of the customer intent associated with this Caseplan. (required).</param>
        /// <param name="Description">The description of the Caseplan. Maximum length of 512 characters..</param>
        /// <param name="DefaultCaseOwnerId">The ID of the default owner of a Case created from the Caseplan..</param>
        /// <param name="DivisionId">The ID of the division the Caseplan belongs to. Use &#39;*&#39; for divisionless caseplans. (required).</param>
        /// <param name="DataSchemas">The schemas that define all data for cases from this Caseplan. The schema must be defined in the TaskManagement namespace. (required).</param>
        /// <param name="IntakeSettings">The intake format when collecting data for a case from this caseplan. There can be a maximum of 10 IntakeSettings defined for a Caseplan..</param>
        public CaseplanCreate(string Name = null, int? DefaultDueDurationInSeconds = null, int? DefaultTtlSeconds = null, string ReferencePrefix = null, string CustomerIntentId = null, string Description = null, string DefaultCaseOwnerId = null, string DivisionId = null, List<CaseplanDataSchema> DataSchemas = null, List<IntakeSetting> IntakeSettings = null)
        {
            this.Name = Name;
            this.DefaultDueDurationInSeconds = DefaultDueDurationInSeconds;
            this.DefaultTtlSeconds = DefaultTtlSeconds;
            this.ReferencePrefix = ReferencePrefix;
            this.CustomerIntentId = CustomerIntentId;
            this.Description = Description;
            this.DefaultCaseOwnerId = DefaultCaseOwnerId;
            this.DivisionId = DivisionId;
            this.DataSchemas = DataSchemas;
            this.IntakeSettings = IntakeSettings;
            
        }
        


        /// <summary>
        /// The name of the Caseplan. Valid length between 3 and 256 characters.
        /// </summary>
        /// <value>The name of the Caseplan. Valid length between 3 and 256 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The default due duration in seconds for Cases created from the Caseplan. Valid range is between 1 and 31536000 seconds.
        /// </summary>
        /// <value>The default due duration in seconds for Cases created from the Caseplan. Valid range is between 1 and 31536000 seconds.</value>
        [DataMember(Name="defaultDueDurationInSeconds", EmitDefaultValue=false)]
        public int? DefaultDueDurationInSeconds { get; set; }



        /// <summary>
        /// The default TTL in seconds for Cases created from the Caseplan. Valid range is between 86400 and 31536000 seconds.
        /// </summary>
        /// <value>The default TTL in seconds for Cases created from the Caseplan. Valid range is between 86400 and 31536000 seconds.</value>
        [DataMember(Name="defaultTtlSeconds", EmitDefaultValue=false)]
        public int? DefaultTtlSeconds { get; set; }



        /// <summary>
        /// The prefix of the Caseplan reference. Valid length between 2 and 8 alphanumeric characters.
        /// </summary>
        /// <value>The prefix of the Caseplan reference. Valid length between 2 and 8 alphanumeric characters.</value>
        [DataMember(Name="referencePrefix", EmitDefaultValue=false)]
        public string ReferencePrefix { get; set; }



        /// <summary>
        /// The ID of the customer intent associated with this Caseplan.
        /// </summary>
        /// <value>The ID of the customer intent associated with this Caseplan.</value>
        [DataMember(Name="customerIntentId", EmitDefaultValue=false)]
        public string CustomerIntentId { get; set; }



        /// <summary>
        /// The description of the Caseplan. Maximum length of 512 characters.
        /// </summary>
        /// <value>The description of the Caseplan. Maximum length of 512 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The ID of the default owner of a Case created from the Caseplan.
        /// </summary>
        /// <value>The ID of the default owner of a Case created from the Caseplan.</value>
        [DataMember(Name="defaultCaseOwnerId", EmitDefaultValue=false)]
        public string DefaultCaseOwnerId { get; set; }



        /// <summary>
        /// The ID of the division the Caseplan belongs to. Use &#39;*&#39; for divisionless caseplans.
        /// </summary>
        /// <value>The ID of the division the Caseplan belongs to. Use &#39;*&#39; for divisionless caseplans.</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// The schemas that define all data for cases from this Caseplan. The schema must be defined in the TaskManagement namespace.
        /// </summary>
        /// <value>The schemas that define all data for cases from this Caseplan. The schema must be defined in the TaskManagement namespace.</value>
        [DataMember(Name="dataSchemas", EmitDefaultValue=false)]
        public List<CaseplanDataSchema> DataSchemas { get; set; }



        /// <summary>
        /// The intake format when collecting data for a case from this caseplan. There can be a maximum of 10 IntakeSettings defined for a Caseplan.
        /// </summary>
        /// <value>The intake format when collecting data for a case from this caseplan. There can be a maximum of 10 IntakeSettings defined for a Caseplan.</value>
        [DataMember(Name="intakeSettings", EmitDefaultValue=false)]
        public List<IntakeSetting> IntakeSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseplanCreate {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultDueDurationInSeconds: ").Append(DefaultDueDurationInSeconds).Append("\n");
            sb.Append("  DefaultTtlSeconds: ").Append(DefaultTtlSeconds).Append("\n");
            sb.Append("  ReferencePrefix: ").Append(ReferencePrefix).Append("\n");
            sb.Append("  CustomerIntentId: ").Append(CustomerIntentId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultCaseOwnerId: ").Append(DefaultCaseOwnerId).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  DataSchemas: ").Append(DataSchemas).Append("\n");
            sb.Append("  IntakeSettings: ").Append(IntakeSettings).Append("\n");
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
            return this.Equals(obj as CaseplanCreate);
        }

        /// <summary>
        /// Returns true if CaseplanCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseplanCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseplanCreate other)
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
                    this.DefaultDueDurationInSeconds == other.DefaultDueDurationInSeconds ||
                    this.DefaultDueDurationInSeconds != null &&
                    this.DefaultDueDurationInSeconds.Equals(other.DefaultDueDurationInSeconds)
                ) &&
                (
                    this.DefaultTtlSeconds == other.DefaultTtlSeconds ||
                    this.DefaultTtlSeconds != null &&
                    this.DefaultTtlSeconds.Equals(other.DefaultTtlSeconds)
                ) &&
                (
                    this.ReferencePrefix == other.ReferencePrefix ||
                    this.ReferencePrefix != null &&
                    this.ReferencePrefix.Equals(other.ReferencePrefix)
                ) &&
                (
                    this.CustomerIntentId == other.CustomerIntentId ||
                    this.CustomerIntentId != null &&
                    this.CustomerIntentId.Equals(other.CustomerIntentId)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DefaultCaseOwnerId == other.DefaultCaseOwnerId ||
                    this.DefaultCaseOwnerId != null &&
                    this.DefaultCaseOwnerId.Equals(other.DefaultCaseOwnerId)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.DataSchemas == other.DataSchemas ||
                    this.DataSchemas != null &&
                    this.DataSchemas.SequenceEqual(other.DataSchemas)
                ) &&
                (
                    this.IntakeSettings == other.IntakeSettings ||
                    this.IntakeSettings != null &&
                    this.IntakeSettings.SequenceEqual(other.IntakeSettings)
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

                if (this.DefaultDueDurationInSeconds != null)
                    hash = hash * 59 + this.DefaultDueDurationInSeconds.GetHashCode();

                if (this.DefaultTtlSeconds != null)
                    hash = hash * 59 + this.DefaultTtlSeconds.GetHashCode();

                if (this.ReferencePrefix != null)
                    hash = hash * 59 + this.ReferencePrefix.GetHashCode();

                if (this.CustomerIntentId != null)
                    hash = hash * 59 + this.CustomerIntentId.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DefaultCaseOwnerId != null)
                    hash = hash * 59 + this.DefaultCaseOwnerId.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.DataSchemas != null)
                    hash = hash * 59 + this.DataSchemas.GetHashCode();

                if (this.IntakeSettings != null)
                    hash = hash * 59 + this.IntakeSettings.GetHashCode();

                return hash;
            }
        }
    }

}
