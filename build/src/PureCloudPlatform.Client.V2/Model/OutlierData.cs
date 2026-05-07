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
    /// OutlierData
    /// </summary>
    [DataContract]
    public partial class OutlierData :  IEquatable<OutlierData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlierData" /> class.
        /// </summary>
        /// <param name="DownloadUrls">List of URLs to fetch the result of the outliers data. This field is populated only if session state is &#39;Complete&#39; and outliers are present.</param>
        /// <param name="DownloadResultTemplate">Result will always come via downloadUrls; however the schema is included for documentation.</param>
        public OutlierData(List<string> DownloadUrls = null, OutlierResultTemplate DownloadResultTemplate = null)
        {
            this.DownloadUrls = DownloadUrls;
            this.DownloadResultTemplate = DownloadResultTemplate;
            
        }
        


        /// <summary>
        /// List of URLs to fetch the result of the outliers data. This field is populated only if session state is &#39;Complete&#39; and outliers are present
        /// </summary>
        /// <value>List of URLs to fetch the result of the outliers data. This field is populated only if session state is &#39;Complete&#39; and outliers are present</value>
        [DataMember(Name="downloadUrls", EmitDefaultValue=false)]
        public List<string> DownloadUrls { get; set; }



        /// <summary>
        /// Result will always come via downloadUrls; however the schema is included for documentation
        /// </summary>
        /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
        [DataMember(Name="downloadResultTemplate", EmitDefaultValue=false)]
        public OutlierResultTemplate DownloadResultTemplate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutlierData {\n");

            sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
            sb.Append("  DownloadResultTemplate: ").Append(DownloadResultTemplate).Append("\n");
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
            return this.Equals(obj as OutlierData);
        }

        /// <summary>
        /// Returns true if OutlierData instances are equal
        /// </summary>
        /// <param name="other">Instance of OutlierData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlierData other)
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
                    this.DownloadResultTemplate == other.DownloadResultTemplate ||
                    this.DownloadResultTemplate != null &&
                    this.DownloadResultTemplate.Equals(other.DownloadResultTemplate)
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

                if (this.DownloadResultTemplate != null)
                    hash = hash * 59 + this.DownloadResultTemplate.GetHashCode();

                return hash;
            }
        }
    }

}
