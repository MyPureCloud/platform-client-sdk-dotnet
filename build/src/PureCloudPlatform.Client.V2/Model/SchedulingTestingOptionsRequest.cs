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
    /// SchedulingTestingOptionsRequest
    /// </summary>
    [DataContract]
    public partial class SchedulingTestingOptionsRequest :  IEquatable<SchedulingTestingOptionsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingTestingOptionsRequest" /> class.
        /// </summary>
        /// <param name="FastScheduling">Whether to enable fast scheduling.</param>
        /// <param name="DelayScheduling">Whether to force delayed scheduling.</param>
        /// <param name="FailScheduling">Whether to force scheduling to fail.</param>
        /// <param name="PopulateWarnings">Whether to populate warnings in the generated schedule.</param>
        /// <param name="PopulateDeprecatedWarnings">Whether to populate deprecated warnings in the generated schedule.</param>
        public SchedulingTestingOptionsRequest(bool? FastScheduling = null, bool? DelayScheduling = null, bool? FailScheduling = null, bool? PopulateWarnings = null, bool? PopulateDeprecatedWarnings = null)
        {
            this.FastScheduling = FastScheduling;
            this.DelayScheduling = DelayScheduling;
            this.FailScheduling = FailScheduling;
            this.PopulateWarnings = PopulateWarnings;
            this.PopulateDeprecatedWarnings = PopulateDeprecatedWarnings;
            
        }
        


        /// <summary>
        /// Whether to enable fast scheduling
        /// </summary>
        /// <value>Whether to enable fast scheduling</value>
        [DataMember(Name="fastScheduling", EmitDefaultValue=false)]
        public bool? FastScheduling { get; set; }



        /// <summary>
        /// Whether to force delayed scheduling
        /// </summary>
        /// <value>Whether to force delayed scheduling</value>
        [DataMember(Name="delayScheduling", EmitDefaultValue=false)]
        public bool? DelayScheduling { get; set; }



        /// <summary>
        /// Whether to force scheduling to fail
        /// </summary>
        /// <value>Whether to force scheduling to fail</value>
        [DataMember(Name="failScheduling", EmitDefaultValue=false)]
        public bool? FailScheduling { get; set; }



        /// <summary>
        /// Whether to populate warnings in the generated schedule
        /// </summary>
        /// <value>Whether to populate warnings in the generated schedule</value>
        [DataMember(Name="populateWarnings", EmitDefaultValue=false)]
        public bool? PopulateWarnings { get; set; }



        /// <summary>
        /// Whether to populate deprecated warnings in the generated schedule
        /// </summary>
        /// <value>Whether to populate deprecated warnings in the generated schedule</value>
        [DataMember(Name="populateDeprecatedWarnings", EmitDefaultValue=false)]
        public bool? PopulateDeprecatedWarnings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulingTestingOptionsRequest {\n");

            sb.Append("  FastScheduling: ").Append(FastScheduling).Append("\n");
            sb.Append("  DelayScheduling: ").Append(DelayScheduling).Append("\n");
            sb.Append("  FailScheduling: ").Append(FailScheduling).Append("\n");
            sb.Append("  PopulateWarnings: ").Append(PopulateWarnings).Append("\n");
            sb.Append("  PopulateDeprecatedWarnings: ").Append(PopulateDeprecatedWarnings).Append("\n");
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
            return this.Equals(obj as SchedulingTestingOptionsRequest);
        }

        /// <summary>
        /// Returns true if SchedulingTestingOptionsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SchedulingTestingOptionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingTestingOptionsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FastScheduling == other.FastScheduling ||
                    this.FastScheduling != null &&
                    this.FastScheduling.Equals(other.FastScheduling)
                ) &&
                (
                    this.DelayScheduling == other.DelayScheduling ||
                    this.DelayScheduling != null &&
                    this.DelayScheduling.Equals(other.DelayScheduling)
                ) &&
                (
                    this.FailScheduling == other.FailScheduling ||
                    this.FailScheduling != null &&
                    this.FailScheduling.Equals(other.FailScheduling)
                ) &&
                (
                    this.PopulateWarnings == other.PopulateWarnings ||
                    this.PopulateWarnings != null &&
                    this.PopulateWarnings.Equals(other.PopulateWarnings)
                ) &&
                (
                    this.PopulateDeprecatedWarnings == other.PopulateDeprecatedWarnings ||
                    this.PopulateDeprecatedWarnings != null &&
                    this.PopulateDeprecatedWarnings.Equals(other.PopulateDeprecatedWarnings)
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
                if (this.FastScheduling != null)
                    hash = hash * 59 + this.FastScheduling.GetHashCode();

                if (this.DelayScheduling != null)
                    hash = hash * 59 + this.DelayScheduling.GetHashCode();

                if (this.FailScheduling != null)
                    hash = hash * 59 + this.FailScheduling.GetHashCode();

                if (this.PopulateWarnings != null)
                    hash = hash * 59 + this.PopulateWarnings.GetHashCode();

                if (this.PopulateDeprecatedWarnings != null)
                    hash = hash * 59 + this.PopulateDeprecatedWarnings.GetHashCode();

                return hash;
            }
        }
    }

}
