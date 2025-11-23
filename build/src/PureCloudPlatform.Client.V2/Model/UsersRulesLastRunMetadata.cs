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
    /// UsersRulesLastRunMetadata
    /// </summary>
    [DataContract]
    public partial class UsersRulesLastRunMetadata :  IEquatable<UsersRulesLastRunMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRulesLastRunMetadata" /> class.
        /// </summary>
        /// <param name="Id">The id of the run.</param>
        /// <param name="CreatedDate">The date/time the rule was run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreatedBy">The user that started the run.</param>
        /// <param name="ResultCount">The number of users returned by the run.</param>
        public UsersRulesLastRunMetadata(string Id = null, DateTime? CreatedDate = null, UserReference CreatedBy = null, long? ResultCount = null)
        {
            this.Id = Id;
            this.CreatedDate = CreatedDate;
            this.CreatedBy = CreatedBy;
            this.ResultCount = ResultCount;
            
        }
        


        /// <summary>
        /// The id of the run
        /// </summary>
        /// <value>The id of the run</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The date/time the rule was run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date/time the rule was run. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }



        /// <summary>
        /// The user that started the run
        /// </summary>
        /// <value>The user that started the run</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; set; }



        /// <summary>
        /// The number of users returned by the run
        /// </summary>
        /// <value>The number of users returned by the run</value>
        [DataMember(Name="resultCount", EmitDefaultValue=false)]
        public long? ResultCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersRulesLastRunMetadata {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ResultCount: ").Append(ResultCount).Append("\n");
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
            return this.Equals(obj as UsersRulesLastRunMetadata);
        }

        /// <summary>
        /// Returns true if UsersRulesLastRunMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of UsersRulesLastRunMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersRulesLastRunMetadata other)
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
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ResultCount == other.ResultCount ||
                    this.ResultCount != null &&
                    this.ResultCount.Equals(other.ResultCount)
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

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.ResultCount != null)
                    hash = hash * 59 + this.ResultCount.GetHashCode();

                return hash;
            }
        }
    }

}
