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
    /// GamificationStatus
    /// </summary>
    [DataContract]
    public partial class GamificationStatus :  IEquatable<GamificationStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationStatus" /> class.
        /// </summary>
        /// <param name="IsActive">Gamification status of the organization..</param>
        /// <param name="DateStart">Gamification start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="AutomaticUserAssignment">Automatic assignment of users to the default profile.</param>
        /// <param name="DateStartPersonalBest">Personal best aggregation starting date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        public GamificationStatus(bool? IsActive = null, String DateStart = null, bool? AutomaticUserAssignment = null, String DateStartPersonalBest = null)
        {
            this.IsActive = IsActive;
            this.DateStart = DateStart;
            this.AutomaticUserAssignment = AutomaticUserAssignment;
            this.DateStartPersonalBest = DateStartPersonalBest;
            
        }
        


        /// <summary>
        /// Gamification status of the organization.
        /// </summary>
        /// <value>Gamification status of the organization.</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }



        /// <summary>
        /// Gamification start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Gamification start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public String DateStart { get; set; }



        /// <summary>
        /// Automatic assignment of users to the default profile
        /// </summary>
        /// <value>Automatic assignment of users to the default profile</value>
        [DataMember(Name="automaticUserAssignment", EmitDefaultValue=false)]
        public bool? AutomaticUserAssignment { get; set; }



        /// <summary>
        /// Personal best aggregation starting date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Personal best aggregation starting date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStartPersonalBest", EmitDefaultValue=false)]
        public String DateStartPersonalBest { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamificationStatus {\n");

            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  AutomaticUserAssignment: ").Append(AutomaticUserAssignment).Append("\n");
            sb.Append("  DateStartPersonalBest: ").Append(DateStartPersonalBest).Append("\n");
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
            return this.Equals(obj as GamificationStatus);
        }

        /// <summary>
        /// Returns true if GamificationStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of GamificationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GamificationStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.AutomaticUserAssignment == other.AutomaticUserAssignment ||
                    this.AutomaticUserAssignment != null &&
                    this.AutomaticUserAssignment.Equals(other.AutomaticUserAssignment)
                ) &&
                (
                    this.DateStartPersonalBest == other.DateStartPersonalBest ||
                    this.DateStartPersonalBest != null &&
                    this.DateStartPersonalBest.Equals(other.DateStartPersonalBest)
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
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.AutomaticUserAssignment != null)
                    hash = hash * 59 + this.AutomaticUserAssignment.GetHashCode();

                if (this.DateStartPersonalBest != null)
                    hash = hash * 59 + this.DateStartPersonalBest.GetHashCode();

                return hash;
            }
        }
    }

}
