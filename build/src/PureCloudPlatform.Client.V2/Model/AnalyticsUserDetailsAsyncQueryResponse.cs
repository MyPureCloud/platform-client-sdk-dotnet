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
    /// AnalyticsUserDetailsAsyncQueryResponse
    /// </summary>
    [DataContract]
    public partial class AnalyticsUserDetailsAsyncQueryResponse :  IEquatable<AnalyticsUserDetailsAsyncQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsUserDetailsAsyncQueryResponse" /> class.
        /// </summary>
        /// <param name="UserDetails">UserDetails.</param>
        /// <param name="Cursor">Optional cursor to indicate where to resume the results.</param>
        /// <param name="DataAvailabilityDate">Data available up to at least this datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public AnalyticsUserDetailsAsyncQueryResponse(List<AnalyticsUserDetail> UserDetails = null, string Cursor = null, DateTime? DataAvailabilityDate = null)
        {
            this.UserDetails = UserDetails;
            this.Cursor = Cursor;
            this.DataAvailabilityDate = DataAvailabilityDate;
            
        }
        


        /// <summary>
        /// Gets or Sets UserDetails
        /// </summary>
        [DataMember(Name="userDetails", EmitDefaultValue=false)]
        public List<AnalyticsUserDetail> UserDetails { get; set; }



        /// <summary>
        /// Optional cursor to indicate where to resume the results
        /// </summary>
        /// <value>Optional cursor to indicate where to resume the results</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }



        /// <summary>
        /// Data available up to at least this datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Data available up to at least this datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dataAvailabilityDate", EmitDefaultValue=false)]
        public DateTime? DataAvailabilityDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsUserDetailsAsyncQueryResponse {\n");

            sb.Append("  UserDetails: ").Append(UserDetails).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  DataAvailabilityDate: ").Append(DataAvailabilityDate).Append("\n");
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
            return this.Equals(obj as AnalyticsUserDetailsAsyncQueryResponse);
        }

        /// <summary>
        /// Returns true if AnalyticsUserDetailsAsyncQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsUserDetailsAsyncQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsUserDetailsAsyncQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserDetails == other.UserDetails ||
                    this.UserDetails != null &&
                    this.UserDetails.SequenceEqual(other.UserDetails)
                ) &&
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
                ) &&
                (
                    this.DataAvailabilityDate == other.DataAvailabilityDate ||
                    this.DataAvailabilityDate != null &&
                    this.DataAvailabilityDate.Equals(other.DataAvailabilityDate)
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
                if (this.UserDetails != null)
                    hash = hash * 59 + this.UserDetails.GetHashCode();

                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();

                if (this.DataAvailabilityDate != null)
                    hash = hash * 59 + this.DataAvailabilityDate.GetHashCode();

                return hash;
            }
        }
    }

}
