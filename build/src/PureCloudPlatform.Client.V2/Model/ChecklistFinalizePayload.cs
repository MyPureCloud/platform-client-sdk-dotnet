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
    /// ChecklistFinalizePayload
    /// </summary>
    [DataContract]
    public partial class ChecklistFinalizePayload :  IEquatable<ChecklistFinalizePayload>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistFinalizePayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChecklistFinalizePayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistFinalizePayload" /> class.
        /// </summary>
        /// <param name="ExitReason">Exit reason provided at the time of finalizing the checklist. (required).</param>
        public ChecklistFinalizePayload(string ExitReason = null)
        {
            this.ExitReason = ExitReason;
            
        }
        


        /// <summary>
        /// Exit reason provided at the time of finalizing the checklist.
        /// </summary>
        /// <value>Exit reason provided at the time of finalizing the checklist.</value>
        [DataMember(Name="exitReason", EmitDefaultValue=false)]
        public string ExitReason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChecklistFinalizePayload {\n");

            sb.Append("  ExitReason: ").Append(ExitReason).Append("\n");
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
            return this.Equals(obj as ChecklistFinalizePayload);
        }

        /// <summary>
        /// Returns true if ChecklistFinalizePayload instances are equal
        /// </summary>
        /// <param name="other">Instance of ChecklistFinalizePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChecklistFinalizePayload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExitReason == other.ExitReason ||
                    this.ExitReason != null &&
                    this.ExitReason.Equals(other.ExitReason)
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
                if (this.ExitReason != null)
                    hash = hash * 59 + this.ExitReason.GetHashCode();

                return hash;
            }
        }
    }

}
