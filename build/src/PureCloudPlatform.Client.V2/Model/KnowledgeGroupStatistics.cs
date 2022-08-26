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
    /// KnowledgeGroupStatistics
    /// </summary>
    [DataContract]
    public partial class KnowledgeGroupStatistics :  IEquatable<KnowledgeGroupStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeGroupStatistics" /> class.
        /// </summary>
        /// <param name="UnlinkedPhraseCount">Knowledge Group unique phrase count.</param>
        /// <param name="UnlinkedPhraseHitCount">Knowledge Group unlinked phrases hit count.</param>
        /// <param name="TotalPhraseHitCount">Total number of phrase hit counts of an unanswered group.</param>
        public KnowledgeGroupStatistics(int? UnlinkedPhraseCount = null, int? UnlinkedPhraseHitCount = null, int? TotalPhraseHitCount = null)
        {
            this.UnlinkedPhraseCount = UnlinkedPhraseCount;
            this.UnlinkedPhraseHitCount = UnlinkedPhraseHitCount;
            this.TotalPhraseHitCount = TotalPhraseHitCount;
            
        }
        


        /// <summary>
        /// Knowledge Group unique phrase count
        /// </summary>
        /// <value>Knowledge Group unique phrase count</value>
        [DataMember(Name="unlinkedPhraseCount", EmitDefaultValue=false)]
        public int? UnlinkedPhraseCount { get; set; }



        /// <summary>
        /// Knowledge Group unlinked phrases hit count
        /// </summary>
        /// <value>Knowledge Group unlinked phrases hit count</value>
        [DataMember(Name="unlinkedPhraseHitCount", EmitDefaultValue=false)]
        public int? UnlinkedPhraseHitCount { get; set; }



        /// <summary>
        /// Total number of phrase hit counts of an unanswered group
        /// </summary>
        /// <value>Total number of phrase hit counts of an unanswered group</value>
        [DataMember(Name="totalPhraseHitCount", EmitDefaultValue=false)]
        public int? TotalPhraseHitCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeGroupStatistics {\n");

            sb.Append("  UnlinkedPhraseCount: ").Append(UnlinkedPhraseCount).Append("\n");
            sb.Append("  UnlinkedPhraseHitCount: ").Append(UnlinkedPhraseHitCount).Append("\n");
            sb.Append("  TotalPhraseHitCount: ").Append(TotalPhraseHitCount).Append("\n");
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
            return this.Equals(obj as KnowledgeGroupStatistics);
        }

        /// <summary>
        /// Returns true if KnowledgeGroupStatistics instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeGroupStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeGroupStatistics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UnlinkedPhraseCount == other.UnlinkedPhraseCount ||
                    this.UnlinkedPhraseCount != null &&
                    this.UnlinkedPhraseCount.Equals(other.UnlinkedPhraseCount)
                ) &&
                (
                    this.UnlinkedPhraseHitCount == other.UnlinkedPhraseHitCount ||
                    this.UnlinkedPhraseHitCount != null &&
                    this.UnlinkedPhraseHitCount.Equals(other.UnlinkedPhraseHitCount)
                ) &&
                (
                    this.TotalPhraseHitCount == other.TotalPhraseHitCount ||
                    this.TotalPhraseHitCount != null &&
                    this.TotalPhraseHitCount.Equals(other.TotalPhraseHitCount)
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
                if (this.UnlinkedPhraseCount != null)
                    hash = hash * 59 + this.UnlinkedPhraseCount.GetHashCode();

                if (this.UnlinkedPhraseHitCount != null)
                    hash = hash * 59 + this.UnlinkedPhraseHitCount.GetHashCode();

                if (this.TotalPhraseHitCount != null)
                    hash = hash * 59 + this.TotalPhraseHitCount.GetHashCode();

                return hash;
            }
        }
    }

}
