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
    /// POST request body for fetching the current user&#39;s schedule over a given range
    /// </summary>
    [DataContract]
    public partial class CurrentUserScheduleRequestBody :  IEquatable<CurrentUserScheduleRequestBody>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserScheduleRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrentUserScheduleRequestBody() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserScheduleRequestBody" /> class.
        /// </summary>
        /// <param name="StartDate">Beginning of the range of schedules to fetch, in ISO-8601 format (required).</param>
        /// <param name="EndDate">End of the range of schedules to fetch, in ISO-8601 format (required).</param>
        /// <param name="LoadFullWeeks">Whether to load the full week&#39;s schedule (for the current user) of any week overlapping the start/end date query parameters, defaults to false.</param>
        public CurrentUserScheduleRequestBody(DateTime? StartDate = null, DateTime? EndDate = null, bool? LoadFullWeeks = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.LoadFullWeeks = LoadFullWeeks;
            
        }
        
        
        
        /// <summary>
        /// Beginning of the range of schedules to fetch, in ISO-8601 format
        /// </summary>
        /// <value>Beginning of the range of schedules to fetch, in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// End of the range of schedules to fetch, in ISO-8601 format
        /// </summary>
        /// <value>End of the range of schedules to fetch, in ISO-8601 format</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        
        
        
        /// <summary>
        /// Whether to load the full week&#39;s schedule (for the current user) of any week overlapping the start/end date query parameters, defaults to false
        /// </summary>
        /// <value>Whether to load the full week&#39;s schedule (for the current user) of any week overlapping the start/end date query parameters, defaults to false</value>
        [DataMember(Name="loadFullWeeks", EmitDefaultValue=false)]
        public bool? LoadFullWeeks { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentUserScheduleRequestBody {\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  LoadFullWeeks: ").Append(LoadFullWeeks).Append("\n");
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
            return this.Equals(obj as CurrentUserScheduleRequestBody);
        }

        /// <summary>
        /// Returns true if CurrentUserScheduleRequestBody instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrentUserScheduleRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentUserScheduleRequestBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.LoadFullWeeks == other.LoadFullWeeks ||
                    this.LoadFullWeeks != null &&
                    this.LoadFullWeeks.Equals(other.LoadFullWeeks)
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
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.LoadFullWeeks != null)
                    hash = hash * 59 + this.LoadFullWeeks.GetHashCode();
                
                return hash;
            }
        }
    }

}
