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
    /// ContestUserRank
    /// </summary>
    [DataContract]
    public partial class ContestUserRank :  IEquatable<ContestUserRank>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestUserRank" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Rank">The user&#39;s rank in contest, a lower rank is better (1 is the best).</param>
        /// <param name="Score">The user&#39;s contest score.</param>
        public ContestUserRank(string Id = null, int? Rank = null, double? Score = null)
        {
            this.Id = Id;
            this.Rank = Rank;
            this.Score = Score;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The user&#39;s rank in contest, a lower rank is better (1 is the best)
        /// </summary>
        /// <value>The user&#39;s rank in contest, a lower rank is better (1 is the best)</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }



        /// <summary>
        /// The user&#39;s contest score
        /// </summary>
        /// <value>The user&#39;s contest score</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestUserRank {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ContestUserRank);
        }

        /// <summary>
        /// Returns true if ContestUserRank instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestUserRank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestUserRank other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
                ) &&
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();

                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
