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
    /// PossibleWorkShiftsForWeek
    /// </summary>
    [DataContract]
    public partial class PossibleWorkShiftsForWeek :  IEquatable<PossibleWorkShiftsForWeek>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleWorkShiftsForWeek" /> class.
        /// </summary>
        /// <param name="Id">ID of this possible weekly shift.</param>
        /// <param name="DailyPossibleShifts">Daily shifts in this possible weekly shift.</param>
        public PossibleWorkShiftsForWeek(int? Id = null, List<DailyPossibleShift> DailyPossibleShifts = null)
        {
            this.Id = Id;
            this.DailyPossibleShifts = DailyPossibleShifts;
            
        }
        


        /// <summary>
        /// ID of this possible weekly shift
        /// </summary>
        /// <value>ID of this possible weekly shift</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }



        /// <summary>
        /// Daily shifts in this possible weekly shift
        /// </summary>
        /// <value>Daily shifts in this possible weekly shift</value>
        [DataMember(Name="dailyPossibleShifts", EmitDefaultValue=false)]
        public List<DailyPossibleShift> DailyPossibleShifts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PossibleWorkShiftsForWeek {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DailyPossibleShifts: ").Append(DailyPossibleShifts).Append("\n");
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
            return this.Equals(obj as PossibleWorkShiftsForWeek);
        }

        /// <summary>
        /// Returns true if PossibleWorkShiftsForWeek instances are equal
        /// </summary>
        /// <param name="other">Instance of PossibleWorkShiftsForWeek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PossibleWorkShiftsForWeek other)
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
                    this.DailyPossibleShifts == other.DailyPossibleShifts ||
                    this.DailyPossibleShifts != null &&
                    this.DailyPossibleShifts.SequenceEqual(other.DailyPossibleShifts)
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

                if (this.DailyPossibleShifts != null)
                    hash = hash * 59 + this.DailyPossibleShifts.GetHashCode();

                return hash;
            }
        }
    }

}
