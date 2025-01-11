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
    /// QuarterHourly
    /// </summary>
    [DataContract]
    public partial class QuarterHourly :  IEquatable<QuarterHourly>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuarterHourly" /> class.
        /// </summary>
        /// <param name="DownloadUrls">List of download URLs to fetch the result of quarter hour time series. This field is populated only if session state is Complete.</param>
        /// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
        public QuarterHourly(List<string> DownloadUrls = null, List<Timeseries> DownloadResult = null)
        {
            this.DownloadUrls = DownloadUrls;
            this.DownloadResult = DownloadResult;
            
        }
        


        /// <summary>
        /// List of download URLs to fetch the result of quarter hour time series. This field is populated only if session state is Complete
        /// </summary>
        /// <value>List of download URLs to fetch the result of quarter hour time series. This field is populated only if session state is Complete</value>
        [DataMember(Name="downloadUrls", EmitDefaultValue=false)]
        public List<string> DownloadUrls { get; set; }



        /// <summary>
        /// Result will always come via downloadUrls; however the schema is included for documentation
        /// </summary>
        /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
        [DataMember(Name="downloadResult", EmitDefaultValue=false)]
        public List<Timeseries> DownloadResult { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuarterHourly {\n");

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
            return this.Equals(obj as QuarterHourly);
        }

        /// <summary>
        /// Returns true if QuarterHourly instances are equal
        /// </summary>
        /// <param name="other">Instance of QuarterHourly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuarterHourly other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DownloadUrls == other.DownloadUrls ||
                    this.DownloadUrls != null &&
                    this.DownloadUrls.SequenceEqual(other.DownloadUrls)
                ) &&
                (
                    this.DownloadResult == other.DownloadResult ||
                    this.DownloadResult != null &&
                    this.DownloadResult.SequenceEqual(other.DownloadResult)
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
                if (this.DownloadUrls != null)
                    hash = hash * 59 + this.DownloadUrls.GetHashCode();

                if (this.DownloadResult != null)
                    hash = hash * 59 + this.DownloadResult.GetHashCode();

                return hash;
            }
        }
    }

}
