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
    /// AssignedAgentDetails
    /// </summary>
    [DataContract]
    public partial class AssignedAgentDetails :  IEquatable<AssignedAgentDetails>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedAgentDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssignedAgentDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedAgentDetails" /> class.
        /// </summary>
        /// <param name="Id">The ID of the agent (required).</param>
        /// <param name="EndDate">The end date of this schedule set for the agent, relative to the business unit time zone in yyyy-MM-dd format. Null denotes an ongoing schedule set. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        public AssignedAgentDetails(string Id = null, String EndDate = null)
        {
            this.Id = Id;
            this.EndDate = EndDate;
            
        }
        


        /// <summary>
        /// The ID of the agent
        /// </summary>
        /// <value>The ID of the agent</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The end date of this schedule set for the agent, relative to the business unit time zone in yyyy-MM-dd format. Null denotes an ongoing schedule set. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The end date of this schedule set for the agent, relative to the business unit time zone in yyyy-MM-dd format. Null denotes an ongoing schedule set. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public String EndDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignedAgentDetails {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(obj as AssignedAgentDetails);
        }

        /// <summary>
        /// Returns true if AssignedAgentDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of AssignedAgentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssignedAgentDetails other)
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
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                return hash;
            }
        }
    }

}
