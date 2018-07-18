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
    /// Request body for importing a short term forecast
    /// </summary>
    [DataContract]
    public partial class ImportShortTermForecastRequest :  IEquatable<ImportShortTermForecastRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportShortTermForecastRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportShortTermForecastRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportShortTermForecastRequest" /> class.
        /// </summary>
        /// <param name="FileName">The file name, if applicable, this data was extracted from (display purposes only).</param>
        /// <param name="Description">Description for the imported forecast.  Pass an empty string for no description (required).</param>
        /// <param name="RouteGroupList">The raw data to import (required).</param>
        /// <param name="PartialUploadIds">IDs of partial uploads to include in this imported forecast.  Only relevant for large forecasts.</param>
        public ImportShortTermForecastRequest(string FileName = null, string Description = null, RouteGroupList RouteGroupList = null, List<string> PartialUploadIds = null)
        {
            this.FileName = FileName;
            this.Description = Description;
            this.RouteGroupList = RouteGroupList;
            this.PartialUploadIds = PartialUploadIds;
            
        }
        
        
        
        /// <summary>
        /// The file name, if applicable, this data was extracted from (display purposes only)
        /// </summary>
        /// <value>The file name, if applicable, this data was extracted from (display purposes only)</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }
        
        
        
        /// <summary>
        /// Description for the imported forecast.  Pass an empty string for no description
        /// </summary>
        /// <value>Description for the imported forecast.  Pass an empty string for no description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The raw data to import
        /// </summary>
        /// <value>The raw data to import</value>
        [DataMember(Name="routeGroupList", EmitDefaultValue=false)]
        public RouteGroupList RouteGroupList { get; set; }
        
        
        
        /// <summary>
        /// IDs of partial uploads to include in this imported forecast.  Only relevant for large forecasts
        /// </summary>
        /// <value>IDs of partial uploads to include in this imported forecast.  Only relevant for large forecasts</value>
        [DataMember(Name="partialUploadIds", EmitDefaultValue=false)]
        public List<string> PartialUploadIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportShortTermForecastRequest {\n");
            
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RouteGroupList: ").Append(RouteGroupList).Append("\n");
            sb.Append("  PartialUploadIds: ").Append(PartialUploadIds).Append("\n");
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
            return this.Equals(obj as ImportShortTermForecastRequest);
        }

        /// <summary>
        /// Returns true if ImportShortTermForecastRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportShortTermForecastRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportShortTermForecastRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.RouteGroupList == other.RouteGroupList ||
                    this.RouteGroupList != null &&
                    this.RouteGroupList.Equals(other.RouteGroupList)
                ) &&
                (
                    this.PartialUploadIds == other.PartialUploadIds ||
                    this.PartialUploadIds != null &&
                    this.PartialUploadIds.SequenceEqual(other.PartialUploadIds)
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
                
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.RouteGroupList != null)
                    hash = hash * 59 + this.RouteGroupList.GetHashCode();
                
                if (this.PartialUploadIds != null)
                    hash = hash * 59 + this.PartialUploadIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
