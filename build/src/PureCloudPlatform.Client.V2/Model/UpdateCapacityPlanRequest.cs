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
    /// UpdateCapacityPlanRequest
    /// </summary>
    [DataContract]
    public partial class UpdateCapacityPlanRequest :  IEquatable<UpdateCapacityPlanRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCapacityPlanRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateCapacityPlanRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCapacityPlanRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the capacity plan.</param>
        /// <param name="Description">Description of the capacity plan.</param>
        /// <param name="StartBusinessUnitDate">The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="EndBusinessUnitDate">The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="Forecast">The selected forecast for this capacity plan.</param>
        /// <param name="FullTimeEquivalentWeeklyHours">The weekly hours used to calculate full time equivalent agents.</param>
        /// <param name="UseLatestPlanningGroupStaffingGroupAssociation">Whether to use latest staffing group to planning group association.</param>
        /// <param name="Metadata">The metadata of this capacity plan (required).</param>
        public UpdateCapacityPlanRequest(string Name = null, string Description = null, String StartBusinessUnitDate = null, String EndBusinessUnitDate = null, ValueWrapperBuShortTermForecastReference Forecast = null, double? FullTimeEquivalentWeeklyHours = null, bool? UseLatestPlanningGroupStaffingGroupAssociation = null, CapacityPlanMetadata Metadata = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.StartBusinessUnitDate = StartBusinessUnitDate;
            this.EndBusinessUnitDate = EndBusinessUnitDate;
            this.Forecast = Forecast;
            this.FullTimeEquivalentWeeklyHours = FullTimeEquivalentWeeklyHours;
            this.UseLatestPlanningGroupStaffingGroupAssociation = UseLatestPlanningGroupStaffingGroupAssociation;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The name of the capacity plan
        /// </summary>
        /// <value>The name of the capacity plan</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Description of the capacity plan
        /// </summary>
        /// <value>Description of the capacity plan</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="startBusinessUnitDate", EmitDefaultValue=false)]
        public String StartBusinessUnitDate { get; set; }



        /// <summary>
        /// The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="endBusinessUnitDate", EmitDefaultValue=false)]
        public String EndBusinessUnitDate { get; set; }



        /// <summary>
        /// The selected forecast for this capacity plan
        /// </summary>
        /// <value>The selected forecast for this capacity plan</value>
        [DataMember(Name="forecast", EmitDefaultValue=false)]
        public ValueWrapperBuShortTermForecastReference Forecast { get; set; }



        /// <summary>
        /// The weekly hours used to calculate full time equivalent agents
        /// </summary>
        /// <value>The weekly hours used to calculate full time equivalent agents</value>
        [DataMember(Name="fullTimeEquivalentWeeklyHours", EmitDefaultValue=false)]
        public double? FullTimeEquivalentWeeklyHours { get; set; }



        /// <summary>
        /// Whether to use latest staffing group to planning group association
        /// </summary>
        /// <value>Whether to use latest staffing group to planning group association</value>
        [DataMember(Name="useLatestPlanningGroupStaffingGroupAssociation", EmitDefaultValue=false)]
        public bool? UseLatestPlanningGroupStaffingGroupAssociation { get; set; }



        /// <summary>
        /// The metadata of this capacity plan
        /// </summary>
        /// <value>The metadata of this capacity plan</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public CapacityPlanMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCapacityPlanRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StartBusinessUnitDate: ").Append(StartBusinessUnitDate).Append("\n");
            sb.Append("  EndBusinessUnitDate: ").Append(EndBusinessUnitDate).Append("\n");
            sb.Append("  Forecast: ").Append(Forecast).Append("\n");
            sb.Append("  FullTimeEquivalentWeeklyHours: ").Append(FullTimeEquivalentWeeklyHours).Append("\n");
            sb.Append("  UseLatestPlanningGroupStaffingGroupAssociation: ").Append(UseLatestPlanningGroupStaffingGroupAssociation).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as UpdateCapacityPlanRequest);
        }

        /// <summary>
        /// Returns true if UpdateCapacityPlanRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCapacityPlanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCapacityPlanRequest other)
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
                    this.StartBusinessUnitDate == other.StartBusinessUnitDate ||
                    this.StartBusinessUnitDate != null &&
                    this.StartBusinessUnitDate.Equals(other.StartBusinessUnitDate)
                ) &&
                (
                    this.EndBusinessUnitDate == other.EndBusinessUnitDate ||
                    this.EndBusinessUnitDate != null &&
                    this.EndBusinessUnitDate.Equals(other.EndBusinessUnitDate)
                ) &&
                (
                    this.Forecast == other.Forecast ||
                    this.Forecast != null &&
                    this.Forecast.Equals(other.Forecast)
                ) &&
                (
                    this.FullTimeEquivalentWeeklyHours == other.FullTimeEquivalentWeeklyHours ||
                    this.FullTimeEquivalentWeeklyHours != null &&
                    this.FullTimeEquivalentWeeklyHours.Equals(other.FullTimeEquivalentWeeklyHours)
                ) &&
                (
                    this.UseLatestPlanningGroupStaffingGroupAssociation == other.UseLatestPlanningGroupStaffingGroupAssociation ||
                    this.UseLatestPlanningGroupStaffingGroupAssociation != null &&
                    this.UseLatestPlanningGroupStaffingGroupAssociation.Equals(other.UseLatestPlanningGroupStaffingGroupAssociation)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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

                if (this.StartBusinessUnitDate != null)
                    hash = hash * 59 + this.StartBusinessUnitDate.GetHashCode();

                if (this.EndBusinessUnitDate != null)
                    hash = hash * 59 + this.EndBusinessUnitDate.GetHashCode();

                if (this.Forecast != null)
                    hash = hash * 59 + this.Forecast.GetHashCode();

                if (this.FullTimeEquivalentWeeklyHours != null)
                    hash = hash * 59 + this.FullTimeEquivalentWeeklyHours.GetHashCode();

                if (this.UseLatestPlanningGroupStaffingGroupAssociation != null)
                    hash = hash * 59 + this.UseLatestPlanningGroupStaffingGroupAssociation.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
