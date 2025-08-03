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
    /// LongTermRequirementsServiceGoalDetail
    /// </summary>
    [DataContract]
    public partial class LongTermRequirementsServiceGoalDetail :  IEquatable<LongTermRequirementsServiceGoalDetail>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LongTermRequirementsServiceGoalDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LongTermRequirementsServiceGoalDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LongTermRequirementsServiceGoalDetail" /> class.
        /// </summary>
        /// <param name="Id">Service goal template ID (required).</param>
        /// <param name="ServiceGoals">The service goals used to generate the requirements  (required).</param>
        public LongTermRequirementsServiceGoalDetail(string Id = null, LongTermRequirementsServiceGoal ServiceGoals = null)
        {
            this.Id = Id;
            this.ServiceGoals = ServiceGoals;
            
        }
        


        /// <summary>
        /// Service goal template ID
        /// </summary>
        /// <value>Service goal template ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The service goals used to generate the requirements 
        /// </summary>
        /// <value>The service goals used to generate the requirements </value>
        [DataMember(Name="serviceGoals", EmitDefaultValue=false)]
        public LongTermRequirementsServiceGoal ServiceGoals { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LongTermRequirementsServiceGoalDetail {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceGoals: ").Append(ServiceGoals).Append("\n");
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
            return this.Equals(obj as LongTermRequirementsServiceGoalDetail);
        }

        /// <summary>
        /// Returns true if LongTermRequirementsServiceGoalDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of LongTermRequirementsServiceGoalDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LongTermRequirementsServiceGoalDetail other)
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
                    this.ServiceGoals == other.ServiceGoals ||
                    this.ServiceGoals != null &&
                    this.ServiceGoals.Equals(other.ServiceGoals)
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

                if (this.ServiceGoals != null)
                    hash = hash * 59 + this.ServiceGoals.GetHashCode();

                return hash;
            }
        }
    }

}
