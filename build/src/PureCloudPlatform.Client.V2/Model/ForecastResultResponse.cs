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
    /// ForecastResultResponse
    /// </summary>
    [DataContract]
    public partial class ForecastResultResponse :  IEquatable<ForecastResultResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastResultResponse" /> class.
        /// </summary>
        /// <param name="Result">The forecast result.  If null, fetch the result from the url in downloadUrl.</param>
        /// <param name="DownloadUrl">The downloadUrl to fetch the result if it is too large to be sent directly.</param>
        public ForecastResultResponse(RouteGroupList Result = null, string DownloadUrl = null)
        {
            this.Result = Result;
            this.DownloadUrl = DownloadUrl;
            
        }
        
        
        
        /// <summary>
        /// The forecast result.  If null, fetch the result from the url in downloadUrl
        /// </summary>
        /// <value>The forecast result.  If null, fetch the result from the url in downloadUrl</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public RouteGroupList Result { get; set; }
        
        
        
        /// <summary>
        /// The downloadUrl to fetch the result if it is too large to be sent directly
        /// </summary>
        /// <value>The downloadUrl to fetch the result if it is too large to be sent directly</value>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastResultResponse {\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ForecastResultResponse);
        }

        /// <summary>
        /// Returns true if ForecastResultResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastResultResponse other)
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
