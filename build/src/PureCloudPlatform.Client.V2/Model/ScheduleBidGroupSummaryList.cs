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
    /// ScheduleBidGroupSummaryList
    /// </summary>
    [DataContract]
    public partial class ScheduleBidGroupSummaryList :  IEquatable<ScheduleBidGroupSummaryList>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidGroupSummaryList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleBidGroupSummaryList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidGroupSummaryList" /> class.
        /// </summary>
        /// <param name="ScheduleBidGroupSummaries">Schedule bid group summary (required).</param>
        public ScheduleBidGroupSummaryList(List<ScheduleBidGroupSummary> ScheduleBidGroupSummaries = null)
        {
            this.ScheduleBidGroupSummaries = ScheduleBidGroupSummaries;
            
        }
        


        /// <summary>
        /// Schedule bid group summary
        /// </summary>
        /// <value>Schedule bid group summary</value>
        [DataMember(Name="scheduleBidGroupSummaries", EmitDefaultValue=false)]
        public List<ScheduleBidGroupSummary> ScheduleBidGroupSummaries { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleBidGroupSummaryList {\n");

            sb.Append("  ScheduleBidGroupSummaries: ").Append(ScheduleBidGroupSummaries).Append("\n");
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
            return this.Equals(obj as ScheduleBidGroupSummaryList);
        }

        /// <summary>
        /// Returns true if ScheduleBidGroupSummaryList instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleBidGroupSummaryList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleBidGroupSummaryList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScheduleBidGroupSummaries == other.ScheduleBidGroupSummaries ||
                    this.ScheduleBidGroupSummaries != null &&
                    this.ScheduleBidGroupSummaries.SequenceEqual(other.ScheduleBidGroupSummaries)
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
                if (this.ScheduleBidGroupSummaries != null)
                    hash = hash * 59 + this.ScheduleBidGroupSummaries.GetHashCode();

                return hash;
            }
        }
    }

}
