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
    /// WfmAgentHistoricalAdherenceResponse
    /// </summary>
    [DataContract]
    public partial class WfmAgentHistoricalAdherenceResponse :  IEquatable<WfmAgentHistoricalAdherenceResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAgentHistoricalAdherenceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmAgentHistoricalAdherenceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmAgentHistoricalAdherenceResponse" /> class.
        /// </summary>
        /// <param name="Job">A reference to the job that was started by the request (required).</param>
        /// <param name="DownloadUrls">The url list to GET the results of the agent adherence query. This field is populated only if query state is Complete.</param>
        /// <param name="Result">Results will come via downloadUrls, however it may come inline if small enough.</param>
        public WfmAgentHistoricalAdherenceResponse(WfmAgentHistoricalAdherenceJobReference Job = null, List<string> DownloadUrls = null, WfmAgentHistoricalAdherenceResult Result = null)
        {
            this.Job = Job;
            this.DownloadUrls = DownloadUrls;
            this.Result = Result;
            
        }
        


        /// <summary>
        /// A reference to the job that was started by the request
        /// </summary>
        /// <value>A reference to the job that was started by the request</value>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public WfmAgentHistoricalAdherenceJobReference Job { get; set; }



        /// <summary>
        /// The url list to GET the results of the agent adherence query. This field is populated only if query state is Complete
        /// </summary>
        /// <value>The url list to GET the results of the agent adherence query. This field is populated only if query state is Complete</value>
        [DataMember(Name="downloadUrls", EmitDefaultValue=false)]
        public List<string> DownloadUrls { get; set; }



        /// <summary>
        /// Results will come via downloadUrls, however it may come inline if small enough
        /// </summary>
        /// <value>Results will come via downloadUrls, however it may come inline if small enough</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public WfmAgentHistoricalAdherenceResult Result { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmAgentHistoricalAdherenceResponse {\n");

            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as WfmAgentHistoricalAdherenceResponse);
        }

        /// <summary>
        /// Returns true if WfmAgentHistoricalAdherenceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmAgentHistoricalAdherenceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmAgentHistoricalAdherenceResponse other)
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
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                return hash;
            }
        }
    }

}
