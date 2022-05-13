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
    /// FaxSummary
    /// </summary>
    [DataContract]
    public partial class FaxSummary :  IEquatable<FaxSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaxSummary" /> class.
        /// </summary>
        /// <param name="ReadCount">ReadCount.</param>
        /// <param name="UnreadCount">UnreadCount.</param>
        /// <param name="TotalCount">TotalCount.</param>
        public FaxSummary(int? ReadCount = null, int? UnreadCount = null, int? TotalCount = null)
        {
            this.ReadCount = ReadCount;
            this.UnreadCount = UnreadCount;
            this.TotalCount = TotalCount;
            
        }
        


        /// <summary>
        /// Gets or Sets ReadCount
        /// </summary>
        [DataMember(Name="readCount", EmitDefaultValue=false)]
        public int? ReadCount { get; set; }



        /// <summary>
        /// Gets or Sets UnreadCount
        /// </summary>
        [DataMember(Name="unreadCount", EmitDefaultValue=false)]
        public int? UnreadCount { get; set; }



        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaxSummary {\n");

            sb.Append("  ReadCount: ").Append(ReadCount).Append("\n");
            sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(obj as FaxSummary);
        }

        /// <summary>
        /// Returns true if FaxSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of FaxSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaxSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ReadCount == other.ReadCount ||
                    this.ReadCount != null &&
                    this.ReadCount.Equals(other.ReadCount)
                ) &&
                (
                    this.UnreadCount == other.UnreadCount ||
                    this.UnreadCount != null &&
                    this.UnreadCount.Equals(other.UnreadCount)
                ) &&
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
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
                if (this.ReadCount != null)
                    hash = hash * 59 + this.ReadCount.GetHashCode();

                if (this.UnreadCount != null)
                    hash = hash * 59 + this.UnreadCount.GetHashCode();

                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();

                return hash;
            }
        }
    }

}
