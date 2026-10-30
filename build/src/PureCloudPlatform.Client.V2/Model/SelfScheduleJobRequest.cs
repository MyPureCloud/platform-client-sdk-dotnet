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
    /// SelfScheduleJobRequest
    /// </summary>
    [DataContract]
    public partial class SelfScheduleJobRequest :  IEquatable<SelfScheduleJobRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelfScheduleJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfScheduleJobRequest" /> class.
        /// </summary>
        /// <param name="ActivityMoves">Activities based on the offer that the user wants to move (required).</param>
        public SelfScheduleJobRequest(List<SelfScheduleActivityMoveRequestItem> ActivityMoves = null)
        {
            this.ActivityMoves = ActivityMoves;
            
        }
        


        /// <summary>
        /// Activities based on the offer that the user wants to move
        /// </summary>
        /// <value>Activities based on the offer that the user wants to move</value>
        [DataMember(Name="activityMoves", EmitDefaultValue=false)]
        public List<SelfScheduleActivityMoveRequestItem> ActivityMoves { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelfScheduleJobRequest {\n");

            sb.Append("  ActivityMoves: ").Append(ActivityMoves).Append("\n");
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
            return this.Equals(obj as SelfScheduleJobRequest);
        }

        /// <summary>
        /// Returns true if SelfScheduleJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SelfScheduleJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelfScheduleJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActivityMoves == other.ActivityMoves ||
                    this.ActivityMoves != null &&
                    this.ActivityMoves.SequenceEqual(other.ActivityMoves)
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
                if (this.ActivityMoves != null)
                    hash = hash * 59 + this.ActivityMoves.GetHashCode();

                return hash;
            }
        }
    }

}
