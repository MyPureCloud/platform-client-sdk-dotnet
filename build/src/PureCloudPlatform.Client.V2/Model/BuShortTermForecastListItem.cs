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
    /// BuShortTermForecastListItem
    /// </summary>
    [DataContract]
    public partial class BuShortTermForecastListItem :  IEquatable<BuShortTermForecastListItem>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The method by which this forecast was created
        /// </summary>
        /// <value>The method by which this forecast was created</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CreationMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Import for "Import"
            /// </summary>
            [EnumMember(Value = "Import")]
            Import,
            
            /// <summary>
            /// Enum Importedhistoricalweightedaverage for "ImportedHistoricalWeightedAverage"
            /// </summary>
            [EnumMember(Value = "ImportedHistoricalWeightedAverage")]
            Importedhistoricalweightedaverage,
            
            /// <summary>
            /// Enum Historicalweightedaverage for "HistoricalWeightedAverage"
            /// </summary>
            [EnumMember(Value = "HistoricalWeightedAverage")]
            Historicalweightedaverage,
            
            /// <summary>
            /// Enum Advanced for "Advanced"
            /// </summary>
            [EnumMember(Value = "Advanced")]
            Advanced
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The method by which this forecast was created
        /// </summary>
        /// <value>The method by which this forecast was created</value>
        [DataMember(Name="creationMethod", EmitDefaultValue=false)]
        public CreationMethodEnum? CreationMethod { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuShortTermForecastListItem" /> class.
        /// </summary>
        /// <param name="WeekDate">The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="WeekCount">The number of weeks this forecast covers.</param>
        /// <param name="CreationMethod">The method by which this forecast was created.</param>
        /// <param name="Description">The description of this forecast.</param>
        /// <param name="Metadata">Metadata for this forecast.</param>
        public BuShortTermForecastListItem(String WeekDate = null, int? WeekCount = null, CreationMethodEnum? CreationMethod = null, string Description = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.WeekDate = WeekDate;
            this.WeekCount = WeekCount;
            this.CreationMethod = CreationMethod;
            this.Description = Description;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }
        
        
        
        /// <summary>
        /// The number of weeks this forecast covers
        /// </summary>
        /// <value>The number of weeks this forecast covers</value>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }
        
        
        
        
        
        /// <summary>
        /// The description of this forecast
        /// </summary>
        /// <value>The description of this forecast</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Whether this forecast contains modifications on legacy metrics
        /// </summary>
        /// <value>Whether this forecast contains modifications on legacy metrics</value>
        [DataMember(Name="legacy", EmitDefaultValue=false)]
        public bool? Legacy { get; private set; }
        
        
        
        /// <summary>
        /// Metadata for this forecast
        /// </summary>
        /// <value>Metadata for this forecast</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        
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
            sb.Append("class BuShortTermForecastListItem {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
            sb.Append("  CreationMethod: ").Append(CreationMethod).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Legacy: ").Append(Legacy).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as BuShortTermForecastListItem);
        }

        /// <summary>
        /// Returns true if BuShortTermForecastListItem instances are equal
        /// </summary>
        /// <param name="other">Instance of BuShortTermForecastListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuShortTermForecastListItem other)
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
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
                ) &&
                (
                    this.CreationMethod == other.CreationMethod ||
                    this.CreationMethod != null &&
                    this.CreationMethod.Equals(other.CreationMethod)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Legacy == other.Legacy ||
                    this.Legacy != null &&
                    this.Legacy.Equals(other.Legacy)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();
                
                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();
                
                if (this.CreationMethod != null)
                    hash = hash * 59 + this.CreationMethod.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Legacy != null)
                    hash = hash * 59 + this.Legacy.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
