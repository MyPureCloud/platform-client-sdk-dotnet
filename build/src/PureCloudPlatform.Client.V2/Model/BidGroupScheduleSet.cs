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
    /// BidGroupScheduleSet
    /// </summary>
    [DataContract]
    public partial class BidGroupScheduleSet :  IEquatable<BidGroupScheduleSet>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BidGroupScheduleSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BidGroupScheduleSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BidGroupScheduleSet" /> class.
        /// </summary>
        /// <param name="ShiftSets">The shift sets that will be used for schedule generation (required).</param>
        public BidGroupScheduleSet(List<ShiftSet> ShiftSets = null)
        {
            this.ShiftSets = ShiftSets;
            
        }
        


        /// <summary>
        /// The shift sets that will be used for schedule generation
        /// </summary>
        /// <value>The shift sets that will be used for schedule generation</value>
        [DataMember(Name="shiftSets", EmitDefaultValue=false)]
        public List<ShiftSet> ShiftSets { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BidGroupScheduleSet {\n");

            sb.Append("  ShiftSets: ").Append(ShiftSets).Append("\n");
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
            return this.Equals(obj as BidGroupScheduleSet);
        }

        /// <summary>
        /// Returns true if BidGroupScheduleSet instances are equal
        /// </summary>
        /// <param name="other">Instance of BidGroupScheduleSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BidGroupScheduleSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ShiftSets == other.ShiftSets ||
                    this.ShiftSets != null &&
                    this.ShiftSets.SequenceEqual(other.ShiftSets)
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
                if (this.ShiftSets != null)
                    hash = hash * 59 + this.ShiftSets.GetHashCode();

                return hash;
            }
        }
    }

}
