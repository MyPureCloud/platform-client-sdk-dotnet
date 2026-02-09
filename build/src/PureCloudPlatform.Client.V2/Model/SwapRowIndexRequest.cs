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
    /// SwapRowIndexRequest
    /// </summary>
    [DataContract]
    public partial class SwapRowIndexRequest :  IEquatable<SwapRowIndexRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SwapRowIndexRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SwapRowIndexRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SwapRowIndexRequest" /> class.
        /// </summary>
        /// <param name="SourceRowId">Unique identifier of the source row to swap (required).</param>
        /// <param name="SourceRowIndex">The current index position of the source row. Must be positive, starting from 1 and less than or equal to the size of the table (required).</param>
        /// <param name="TargetRowId">Unique identifier of the target row to swap (required).</param>
        /// <param name="TargetRowIndex">The current index position of the target row. Must be positive, starting from 1 and less than or equal to the size of the table (required).</param>
        public SwapRowIndexRequest(string SourceRowId = null, int? SourceRowIndex = null, string TargetRowId = null, int? TargetRowIndex = null)
        {
            this.SourceRowId = SourceRowId;
            this.SourceRowIndex = SourceRowIndex;
            this.TargetRowId = TargetRowId;
            this.TargetRowIndex = TargetRowIndex;
            
        }
        


        /// <summary>
        /// Unique identifier of the source row to swap
        /// </summary>
        /// <value>Unique identifier of the source row to swap</value>
        [DataMember(Name="sourceRowId", EmitDefaultValue=false)]
        public string SourceRowId { get; set; }



        /// <summary>
        /// The current index position of the source row. Must be positive, starting from 1 and less than or equal to the size of the table
        /// </summary>
        /// <value>The current index position of the source row. Must be positive, starting from 1 and less than or equal to the size of the table</value>
        [DataMember(Name="sourceRowIndex", EmitDefaultValue=false)]
        public int? SourceRowIndex { get; set; }



        /// <summary>
        /// Unique identifier of the target row to swap
        /// </summary>
        /// <value>Unique identifier of the target row to swap</value>
        [DataMember(Name="targetRowId", EmitDefaultValue=false)]
        public string TargetRowId { get; set; }



        /// <summary>
        /// The current index position of the target row. Must be positive, starting from 1 and less than or equal to the size of the table
        /// </summary>
        /// <value>The current index position of the target row. Must be positive, starting from 1 and less than or equal to the size of the table</value>
        [DataMember(Name="targetRowIndex", EmitDefaultValue=false)]
        public int? TargetRowIndex { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwapRowIndexRequest {\n");

            sb.Append("  SourceRowId: ").Append(SourceRowId).Append("\n");
            sb.Append("  SourceRowIndex: ").Append(SourceRowIndex).Append("\n");
            sb.Append("  TargetRowId: ").Append(TargetRowId).Append("\n");
            sb.Append("  TargetRowIndex: ").Append(TargetRowIndex).Append("\n");
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
            return this.Equals(obj as SwapRowIndexRequest);
        }

        /// <summary>
        /// Returns true if SwapRowIndexRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SwapRowIndexRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwapRowIndexRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceRowId == other.SourceRowId ||
                    this.SourceRowId != null &&
                    this.SourceRowId.Equals(other.SourceRowId)
                ) &&
                (
                    this.SourceRowIndex == other.SourceRowIndex ||
                    this.SourceRowIndex != null &&
                    this.SourceRowIndex.Equals(other.SourceRowIndex)
                ) &&
                (
                    this.TargetRowId == other.TargetRowId ||
                    this.TargetRowId != null &&
                    this.TargetRowId.Equals(other.TargetRowId)
                ) &&
                (
                    this.TargetRowIndex == other.TargetRowIndex ||
                    this.TargetRowIndex != null &&
                    this.TargetRowIndex.Equals(other.TargetRowIndex)
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
                if (this.SourceRowId != null)
                    hash = hash * 59 + this.SourceRowId.GetHashCode();

                if (this.SourceRowIndex != null)
                    hash = hash * 59 + this.SourceRowIndex.GetHashCode();

                if (this.TargetRowId != null)
                    hash = hash * 59 + this.TargetRowId.GetHashCode();

                if (this.TargetRowIndex != null)
                    hash = hash * 59 + this.TargetRowIndex.GetHashCode();

                return hash;
            }
        }
    }

}
