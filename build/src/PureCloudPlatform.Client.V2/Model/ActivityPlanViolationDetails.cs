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
    /// ActivityPlanViolationDetails
    /// </summary>
    [DataContract]
    public partial class ActivityPlanViolationDetails :  IEquatable<ActivityPlanViolationDetails>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanViolationDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanViolationDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanViolationDetails" /> class.
        /// </summary>
        /// <param name="Expected">The constraint value (required).</param>
        /// <param name="Actual">The actual value (required).</param>
        public ActivityPlanViolationDetails(string Expected = null, string Actual = null)
        {
            this.Expected = Expected;
            this.Actual = Actual;
            
        }
        


        /// <summary>
        /// The constraint value
        /// </summary>
        /// <value>The constraint value</value>
        [DataMember(Name="expected", EmitDefaultValue=false)]
        public string Expected { get; set; }



        /// <summary>
        /// The actual value
        /// </summary>
        /// <value>The actual value</value>
        [DataMember(Name="actual", EmitDefaultValue=false)]
        public string Actual { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanViolationDetails {\n");

            sb.Append("  Expected: ").Append(Expected).Append("\n");
            sb.Append("  Actual: ").Append(Actual).Append("\n");
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
            return this.Equals(obj as ActivityPlanViolationDetails);
        }

        /// <summary>
        /// Returns true if ActivityPlanViolationDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanViolationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanViolationDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Expected == other.Expected ||
                    this.Expected != null &&
                    this.Expected.Equals(other.Expected)
                ) &&
                (
                    this.Actual == other.Actual ||
                    this.Actual != null &&
                    this.Actual.Equals(other.Actual)
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
                if (this.Expected != null)
                    hash = hash * 59 + this.Expected.GetHashCode();

                if (this.Actual != null)
                    hash = hash * 59 + this.Actual.GetHashCode();

                return hash;
            }
        }
    }

}
