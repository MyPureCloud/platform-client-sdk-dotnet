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
    /// AddShiftTradeJobRequest
    /// </summary>
    [DataContract]
    public partial class AddShiftTradeJobRequest :  IEquatable<AddShiftTradeJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AddShiftTradeJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddShiftTradeJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddShiftTradeJobRequest" /> class.
        /// </summary>
        /// <param name="InitiatingShift">The shift that the initiating user wants to give up in this trade (required).</param>
        /// <param name="AcceptableIntervals">Time frames when the initiating user is willing to accept a shift in exchange. Empty means giving up the shift without taking on another one.</param>
        /// <param name="Target">Optional shift trade target, can be used for example for direct user to user trade.</param>
        /// <param name="ExpirationDate">When this shift trade will expire. Date time is represented as an ISO-8601 string.</param>
        public AddShiftTradeJobRequest(InitiatingShiftRequestItem InitiatingShift = null, List<RequiredDateRange> AcceptableIntervals = null, ShiftTradeTargetRequestItem Target = null, DateTime? ExpirationDate = null)
        {
            this.InitiatingShift = InitiatingShift;
            this.AcceptableIntervals = AcceptableIntervals;
            this.Target = Target;
            this.ExpirationDate = ExpirationDate;
            
        }
        


        /// <summary>
        /// The shift that the initiating user wants to give up in this trade
        /// </summary>
        /// <value>The shift that the initiating user wants to give up in this trade</value>
        [DataMember(Name="initiatingShift", EmitDefaultValue=false)]
        public InitiatingShiftRequestItem InitiatingShift { get; set; }



        /// <summary>
        /// Time frames when the initiating user is willing to accept a shift in exchange. Empty means giving up the shift without taking on another one
        /// </summary>
        /// <value>Time frames when the initiating user is willing to accept a shift in exchange. Empty means giving up the shift without taking on another one</value>
        [DataMember(Name="acceptableIntervals", EmitDefaultValue=false)]
        public List<RequiredDateRange> AcceptableIntervals { get; set; }



        /// <summary>
        /// Optional shift trade target, can be used for example for direct user to user trade
        /// </summary>
        /// <value>Optional shift trade target, can be used for example for direct user to user trade</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public ShiftTradeTargetRequestItem Target { get; set; }



        /// <summary>
        /// When this shift trade will expire. Date time is represented as an ISO-8601 string
        /// </summary>
        /// <value>When this shift trade will expire. Date time is represented as an ISO-8601 string</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddShiftTradeJobRequest {\n");

            sb.Append("  InitiatingShift: ").Append(InitiatingShift).Append("\n");
            sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(obj as AddShiftTradeJobRequest);
        }

        /// <summary>
        /// Returns true if AddShiftTradeJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AddShiftTradeJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddShiftTradeJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.InitiatingShift == other.InitiatingShift ||
                    this.InitiatingShift != null &&
                    this.InitiatingShift.Equals(other.InitiatingShift)
                ) &&
                (
                    this.AcceptableIntervals == other.AcceptableIntervals ||
                    this.AcceptableIntervals != null &&
                    this.AcceptableIntervals.SequenceEqual(other.AcceptableIntervals)
                ) &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) &&
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
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
                if (this.InitiatingShift != null)
                    hash = hash * 59 + this.InitiatingShift.GetHashCode();

                if (this.AcceptableIntervals != null)
                    hash = hash * 59 + this.AcceptableIntervals.GetHashCode();

                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();

                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();

                return hash;
            }
        }
    }

}
