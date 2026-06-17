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
    /// ShiftSetEffectiveWorkPlan
    /// </summary>
    [DataContract]
    public partial class ShiftSetEffectiveWorkPlan :  IEquatable<ShiftSetEffectiveWorkPlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftSetEffectiveWorkPlan" /> class.
        /// </summary>
        /// <param name="WorkPlanId">The ID of the work plan.</param>
        /// <param name="WorkPlanRotationId">The ID of the work plan rotation.</param>
        /// <param name="PositionInRotation">The position in rotation.</param>
        public ShiftSetEffectiveWorkPlan(string WorkPlanId = null, string WorkPlanRotationId = null, int? PositionInRotation = null)
        {
            this.WorkPlanId = WorkPlanId;
            this.WorkPlanRotationId = WorkPlanRotationId;
            this.PositionInRotation = PositionInRotation;
            
        }
        


        /// <summary>
        /// The ID of the work plan
        /// </summary>
        /// <value>The ID of the work plan</value>
        [DataMember(Name="workPlanId", EmitDefaultValue=false)]
        public string WorkPlanId { get; set; }



        /// <summary>
        /// The ID of the work plan rotation
        /// </summary>
        /// <value>The ID of the work plan rotation</value>
        [DataMember(Name="workPlanRotationId", EmitDefaultValue=false)]
        public string WorkPlanRotationId { get; set; }



        /// <summary>
        /// The position in rotation
        /// </summary>
        /// <value>The position in rotation</value>
        [DataMember(Name="positionInRotation", EmitDefaultValue=false)]
        public int? PositionInRotation { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftSetEffectiveWorkPlan {\n");

            sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
            sb.Append("  WorkPlanRotationId: ").Append(WorkPlanRotationId).Append("\n");
            sb.Append("  PositionInRotation: ").Append(PositionInRotation).Append("\n");
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
            return this.Equals(obj as ShiftSetEffectiveWorkPlan);
        }

        /// <summary>
        /// Returns true if ShiftSetEffectiveWorkPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftSetEffectiveWorkPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftSetEffectiveWorkPlan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WorkPlanId == other.WorkPlanId ||
                    this.WorkPlanId != null &&
                    this.WorkPlanId.Equals(other.WorkPlanId)
                ) &&
                (
                    this.WorkPlanRotationId == other.WorkPlanRotationId ||
                    this.WorkPlanRotationId != null &&
                    this.WorkPlanRotationId.Equals(other.WorkPlanRotationId)
                ) &&
                (
                    this.PositionInRotation == other.PositionInRotation ||
                    this.PositionInRotation != null &&
                    this.PositionInRotation.Equals(other.PositionInRotation)
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
                if (this.WorkPlanId != null)
                    hash = hash * 59 + this.WorkPlanId.GetHashCode();

                if (this.WorkPlanRotationId != null)
                    hash = hash * 59 + this.WorkPlanRotationId.GetHashCode();

                if (this.PositionInRotation != null)
                    hash = hash * 59 + this.PositionInRotation.GetHashCode();

                return hash;
            }
        }
    }

}
