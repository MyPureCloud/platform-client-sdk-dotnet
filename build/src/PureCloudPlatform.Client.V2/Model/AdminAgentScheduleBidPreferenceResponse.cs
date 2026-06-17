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
    /// AdminAgentScheduleBidPreferenceResponse
    /// </summary>
    [DataContract]
    public partial class AdminAgentScheduleBidPreferenceResponse :  IEquatable<AdminAgentScheduleBidPreferenceResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAgentScheduleBidPreferenceResponse" /> class.
        /// </summary>
        /// <param name="Result">The agents&#39; schedule set preferences.</param>
        /// <param name="DownloadUrl">URL to retrieve results when the response contains a large dataset. If provided, the downloaded data will follow the same schema as the result..</param>
        public AdminAgentScheduleBidPreferenceResponse(AdminAgentScheduleSetPreferences Result = null, string DownloadUrl = null)
        {
            this.Result = Result;
            this.DownloadUrl = DownloadUrl;
            
        }
        


        /// <summary>
        /// The agents&#39; schedule set preferences
        /// </summary>
        /// <value>The agents&#39; schedule set preferences</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public AdminAgentScheduleSetPreferences Result { get; set; }



        /// <summary>
        /// URL to retrieve results when the response contains a large dataset. If provided, the downloaded data will follow the same schema as the result.
        /// </summary>
        /// <value>URL to retrieve results when the response contains a large dataset. If provided, the downloaded data will follow the same schema as the result.</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminAgentScheduleBidPreferenceResponse {\n");

            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
            return this.Equals(obj as AdminAgentScheduleBidPreferenceResponse);
        }

        /// <summary>
        /// Returns true if AdminAgentScheduleBidPreferenceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminAgentScheduleBidPreferenceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminAgentScheduleBidPreferenceResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
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
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                return hash;
            }
        }
    }

}
