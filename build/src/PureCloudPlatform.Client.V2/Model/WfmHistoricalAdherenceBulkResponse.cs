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
    /// WfmHistoricalAdherenceBulkResponse
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceBulkResponse :  IEquatable<WfmHistoricalAdherenceBulkResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkResponse" /> class.
        /// </summary>
        /// <param name="Job">A reference to the job that was started by the request.</param>
        /// <param name="DownloadUrls">The uri list to GET the results of the Historical Adherence query. This field is populated only if query state is Complete.</param>
        /// <param name="DownloadResult">Results will always come via downloadUrls; however the schema is included for documentation.</param>
        public WfmHistoricalAdherenceBulkResponse(WfmHistoricalAdherenceBulkJobReference Job = null, List<string> DownloadUrls = null, WfmHistoricalAdherenceBulkResult DownloadResult = null)
        {
            this.Job = Job;
            this.DownloadUrls = DownloadUrls;
            this.DownloadResult = DownloadResult;
            
        }
        


        /// <summary>
        /// A reference to the job that was started by the request
        /// </summary>
        /// <value>A reference to the job that was started by the request</value>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public WfmHistoricalAdherenceBulkJobReference Job { get; set; }



        /// <summary>
        /// The uri list to GET the results of the Historical Adherence query. This field is populated only if query state is Complete
        /// </summary>
        /// <value>The uri list to GET the results of the Historical Adherence query. This field is populated only if query state is Complete</value>
        [DataMember(Name="downloadUrls", EmitDefaultValue=false)]
        public List<string> DownloadUrls { get; set; }



        /// <summary>
        /// Results will always come via downloadUrls; however the schema is included for documentation
        /// </summary>
        /// <value>Results will always come via downloadUrls; however the schema is included for documentation</value>
        [DataMember(Name="downloadResult", EmitDefaultValue=false)]
        public WfmHistoricalAdherenceBulkResult DownloadResult { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceBulkResponse {\n");

            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
            sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceBulkResponse);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceBulkResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceBulkResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceBulkResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Job == other.Job ||
                    this.Job != null &&
                    this.Job.Equals(other.Job)
                ) &&
                (
                    this.DownloadUrls == other.DownloadUrls ||
                    this.DownloadUrls != null &&
                    this.DownloadUrls.SequenceEqual(other.DownloadUrls)
                ) &&
                (
                    this.DownloadResult == other.DownloadResult ||
                    this.DownloadResult != null &&
                    this.DownloadResult.Equals(other.DownloadResult)
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
                if (this.Job != null)
                    hash = hash * 59 + this.Job.GetHashCode();

                if (this.DownloadUrls != null)
                    hash = hash * 59 + this.DownloadUrls.GetHashCode();

                if (this.DownloadResult != null)
                    hash = hash * 59 + this.DownloadResult.GetHashCode();

                return hash;
            }
        }
    }

}
