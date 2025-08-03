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
    /// CapacityPlanResponse
    /// </summary>
    [DataContract]
    public partial class CapacityPlanResponse :  IEquatable<CapacityPlanResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description of the capacity plan.</param>
        /// <param name="Forecast">The selected forecast for this capacity plan. Null when main forecast is used in the future.</param>
        /// <param name="StartBusinessUnitDate">The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="EndBusinessUnitDate">The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="FullTimeEquivalentWeeklyHours">The weekly hours used to calculate full time equivalent agents (required).</param>
        /// <param name="Metadata">The metadata of this capacity plan (required).</param>
        public CapacityPlanResponse(string Name = null, string Description = null, BuShortTermForecastReference Forecast = null, String StartBusinessUnitDate = null, String EndBusinessUnitDate = null, double? FullTimeEquivalentWeeklyHours = null, CapacityPlanMetadata Metadata = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Forecast = Forecast;
            this.StartBusinessUnitDate = StartBusinessUnitDate;
            this.EndBusinessUnitDate = EndBusinessUnitDate;
            this.FullTimeEquivalentWeeklyHours = FullTimeEquivalentWeeklyHours;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Description of the capacity plan
        /// </summary>
        /// <value>Description of the capacity plan</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The selected forecast for this capacity plan. Null when main forecast is used in the future
        /// </summary>
        /// <value>The selected forecast for this capacity plan. Null when main forecast is used in the future</value>
        [DataMember(Name="forecast", EmitDefaultValue=false)]
        public BuShortTermForecastReference Forecast { get; set; }



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
        /// The weekly hours used to calculate full time equivalent agents
        /// </summary>
        /// <value>The weekly hours used to calculate full time equivalent agents</value>
        [DataMember(Name="fullTimeEquivalentWeeklyHours", EmitDefaultValue=false)]
        public double? FullTimeEquivalentWeeklyHours { get; set; }



        /// <summary>
        /// The metadata of this capacity plan
        /// </summary>
        /// <value>The metadata of this capacity plan</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public CapacityPlanMetadata Metadata { get; set; }



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
            sb.Append("class CapacityPlanResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Forecast: ").Append(Forecast).Append("\n");
            sb.Append("  StartBusinessUnitDate: ").Append(StartBusinessUnitDate).Append("\n");
            sb.Append("  EndBusinessUnitDate: ").Append(EndBusinessUnitDate).Append("\n");
            sb.Append("  FullTimeEquivalentWeeklyHours: ").Append(FullTimeEquivalentWeeklyHours).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as CapacityPlanResponse);
        }

        /// <summary>
        /// Returns true if CapacityPlanResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanResponse other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Forecast == other.Forecast ||
                    this.Forecast != null &&
                    this.Forecast.Equals(other.Forecast)
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
                    this.FullTimeEquivalentWeeklyHours == other.FullTimeEquivalentWeeklyHours ||
                    this.FullTimeEquivalentWeeklyHours != null &&
                    this.FullTimeEquivalentWeeklyHours.Equals(other.FullTimeEquivalentWeeklyHours)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Forecast != null)
                    hash = hash * 59 + this.Forecast.GetHashCode();

                if (this.StartBusinessUnitDate != null)
                    hash = hash * 59 + this.StartBusinessUnitDate.GetHashCode();

                if (this.EndBusinessUnitDate != null)
                    hash = hash * 59 + this.EndBusinessUnitDate.GetHashCode();

                if (this.FullTimeEquivalentWeeklyHours != null)
                    hash = hash * 59 + this.FullTimeEquivalentWeeklyHours.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
