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
    /// SearchSort
    /// </summary>
    [DataContract]
    public partial class SearchSort :  IEquatable<SearchSort>
    {
        
        
        /// <summary>
        /// The sort order for results
        /// </summary>
        /// <value>The sort order for results</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SortOrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Asc for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            Desc,
            
            /// <summary>
            /// Enum Score for "SCORE"
            /// </summary>
            [EnumMember(Value = "SCORE")]
            Score
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// The sort order for results
        /// </summary>
        /// <value>The sort order for results</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSort" /> class.
        /// </summary>
        /// <param name="SortOrder">The sort order for results.</param>
        /// <param name="SortBy">The field in the resource that you want to sort the results by.</param>
        public SearchSort(SortOrderEnum? SortOrder = null, string SortBy = null)
        {
            this.SortOrder = SortOrder;
            this.SortBy = SortBy;
            
        }
        
        
        
        
        
        /// <summary>
        /// The field in the resource that you want to sort the results by
        /// </summary>
        /// <value>The field in the resource that you want to sort the results by</value>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public string SortBy { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchSort {\n");
            
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
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
            return this.Equals(obj as SearchSort);
        }

        /// <summary>
        /// Returns true if SearchSort instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchSort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchSort other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
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
                
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                
                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();
                
                return hash;
            }
        }
    }

}
