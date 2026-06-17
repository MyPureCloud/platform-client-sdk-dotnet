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
    /// ShiftSet
    /// </summary>
    [DataContract]
    public partial class ShiftSet :  IEquatable<ShiftSet>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShiftSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftSet" /> class.
        /// </summary>
        /// <param name="Id">The ID of the shift set (required).</param>
        /// <param name="Name">The name given for the shift set (required).</param>
        /// <param name="EffectiveWorkPlan">The work plan or work plan rotation used for generating the shift set (required).</param>
        /// <param name="Shifts">The scheduled shifts (required).</param>
        /// <param name="SuggestedAgentCount">The suggested agent count (required).</param>
        /// <param name="OverrideAgentCount">The override agent count. If it is null, it falls back to using the suggestedAgentCount.</param>
        public ShiftSet(string Id = null, string Name = null, ShiftSetEffectiveWorkPlan EffectiveWorkPlan = null, List<ScheduleBidScheduledShift> Shifts = null, int? SuggestedAgentCount = null, int? OverrideAgentCount = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.EffectiveWorkPlan = EffectiveWorkPlan;
            this.Shifts = Shifts;
            this.SuggestedAgentCount = SuggestedAgentCount;
            this.OverrideAgentCount = OverrideAgentCount;
            
        }
        


        /// <summary>
        /// The ID of the shift set
        /// </summary>
        /// <value>The ID of the shift set</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name given for the shift set
        /// </summary>
        /// <value>The name given for the shift set</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The work plan or work plan rotation used for generating the shift set
        /// </summary>
        /// <value>The work plan or work plan rotation used for generating the shift set</value>
        [DataMember(Name="effectiveWorkPlan", EmitDefaultValue=false)]
        public ShiftSetEffectiveWorkPlan EffectiveWorkPlan { get; set; }



        /// <summary>
        /// The scheduled shifts
        /// </summary>
        /// <value>The scheduled shifts</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<ScheduleBidScheduledShift> Shifts { get; set; }



        /// <summary>
        /// The suggested agent count
        /// </summary>
        /// <value>The suggested agent count</value>
        [DataMember(Name="suggestedAgentCount", EmitDefaultValue=false)]
        public int? SuggestedAgentCount { get; set; }



        /// <summary>
        /// The override agent count. If it is null, it falls back to using the suggestedAgentCount
        /// </summary>
        /// <value>The override agent count. If it is null, it falls back to using the suggestedAgentCount</value>
        [DataMember(Name="overrideAgentCount", EmitDefaultValue=false)]
        public int? OverrideAgentCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftSet {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EffectiveWorkPlan: ").Append(EffectiveWorkPlan).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  SuggestedAgentCount: ").Append(SuggestedAgentCount).Append("\n");
            sb.Append("  OverrideAgentCount: ").Append(OverrideAgentCount).Append("\n");
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
            return this.Equals(obj as ShiftSet);
        }

        /// <summary>
        /// Returns true if ShiftSet instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftSet other)
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
                    this.EffectiveWorkPlan == other.EffectiveWorkPlan ||
                    this.EffectiveWorkPlan != null &&
                    this.EffectiveWorkPlan.Equals(other.EffectiveWorkPlan)
                ) &&
                (
                    this.Shifts == other.Shifts ||
                    this.Shifts != null &&
                    this.Shifts.SequenceEqual(other.Shifts)
                ) &&
                (
                    this.SuggestedAgentCount == other.SuggestedAgentCount ||
                    this.SuggestedAgentCount != null &&
                    this.SuggestedAgentCount.Equals(other.SuggestedAgentCount)
                ) &&
                (
                    this.OverrideAgentCount == other.OverrideAgentCount ||
                    this.OverrideAgentCount != null &&
                    this.OverrideAgentCount.Equals(other.OverrideAgentCount)
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

                if (this.EffectiveWorkPlan != null)
                    hash = hash * 59 + this.EffectiveWorkPlan.GetHashCode();

                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();

                if (this.SuggestedAgentCount != null)
                    hash = hash * 59 + this.SuggestedAgentCount.GetHashCode();

                if (this.OverrideAgentCount != null)
                    hash = hash * 59 + this.OverrideAgentCount.GetHashCode();

                return hash;
            }
        }
    }

}
