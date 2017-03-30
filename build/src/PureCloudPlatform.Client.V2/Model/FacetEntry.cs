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
    /// FacetEntry
    /// </summary>
    [DataContract]
    public partial class FacetEntry :  IEquatable<FacetEntry>
    {
        /// <summary>
        /// Gets or Sets TermType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TermTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Term for "TERM"
            /// </summary>
            [EnumMember(Value = "TERM")]
            Term,
            
            /// <summary>
            /// Enum Numberrange for "NUMBERRANGE"
            /// </summary>
            [EnumMember(Value = "NUMBERRANGE")]
            Numberrange,
            
            /// <summary>
            /// Enum Numberhistogram for "NUMBERHISTOGRAM"
            /// </summary>
            [EnumMember(Value = "NUMBERHISTOGRAM")]
            Numberhistogram,
            
            /// <summary>
            /// Enum Daterange for "DATERANGE"
            /// </summary>
            [EnumMember(Value = "DATERANGE")]
            Daterange,
            
            /// <summary>
            /// Enum Datehistogram for "DATEHISTOGRAM"
            /// </summary>
            [EnumMember(Value = "DATEHISTOGRAM")]
            Datehistogram,
            
            /// <summary>
            /// Enum Id for "ID"
            /// </summary>
            [EnumMember(Value = "ID")]
            Id
        }
        /// <summary>
        /// Gets or Sets TermType
        /// </summary>
        [DataMember(Name="termType", EmitDefaultValue=false)]
        public TermTypeEnum? TermType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FacetEntry" /> class.
        /// </summary>
        /// <param name="Attribute">Attribute.</param>
        /// <param name="Statistics">Statistics.</param>
        /// <param name="Other">Other.</param>
        /// <param name="Total">Total.</param>
        /// <param name="Missing">Missing.</param>
        /// <param name="TermCount">TermCount.</param>
        /// <param name="TermType">TermType.</param>
        /// <param name="Terms">Terms.</param>
        public FacetEntry(TermAttribute Attribute = null, FacetStatistics Statistics = null, long? Other = null, long? Total = null, long? Missing = null, int? TermCount = null, TermTypeEnum? TermType = null, List<FacetTerm> Terms = null)
        {
            this.Attribute = Attribute;
            this.Statistics = Statistics;
            this.Other = Other;
            this.Total = Total;
            this.Missing = Missing;
            this.TermCount = TermCount;
            this.TermType = TermType;
            this.Terms = Terms;
        }
        
        /// <summary>
        /// Gets or Sets Attribute
        /// </summary>
        [DataMember(Name="attribute", EmitDefaultValue=false)]
        public TermAttribute Attribute { get; set; }
        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public FacetStatistics Statistics { get; set; }
        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public long? Other { get; set; }
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }
        /// <summary>
        /// Gets or Sets Missing
        /// </summary>
        [DataMember(Name="missing", EmitDefaultValue=false)]
        public long? Missing { get; set; }
        /// <summary>
        /// Gets or Sets TermCount
        /// </summary>
        [DataMember(Name="termCount", EmitDefaultValue=false)]
        public int? TermCount { get; set; }
        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public List<FacetTerm> Terms { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacetEntry {\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Missing: ").Append(Missing).Append("\n");
            sb.Append("  TermCount: ").Append(TermCount).Append("\n");
            sb.Append("  TermType: ").Append(TermType).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
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
            return this.Equals(obj as FacetEntry);
        }

        /// <summary>
        /// Returns true if FacetEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of FacetEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacetEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Attribute == other.Attribute ||
                    this.Attribute != null &&
                    this.Attribute.Equals(other.Attribute)
                ) &&
                (
                    this.Statistics == other.Statistics ||
                    this.Statistics != null &&
                    this.Statistics.Equals(other.Statistics)
                ) &&
                (
                    this.Other == other.Other ||
                    this.Other != null &&
                    this.Other.Equals(other.Other)
                ) &&
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) &&
                (
                    this.Missing == other.Missing ||
                    this.Missing != null &&
                    this.Missing.Equals(other.Missing)
                ) &&
                (
                    this.TermCount == other.TermCount ||
                    this.TermCount != null &&
                    this.TermCount.Equals(other.TermCount)
                ) &&
                (
                    this.TermType == other.TermType ||
                    this.TermType != null &&
                    this.TermType.Equals(other.TermType)
                ) &&
                (
                    this.Terms == other.Terms ||
                    this.Terms != null &&
                    this.Terms.SequenceEqual(other.Terms)
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
                if (this.Attribute != null)
                    hash = hash * 59 + this.Attribute.GetHashCode();
                if (this.Statistics != null)
                    hash = hash * 59 + this.Statistics.GetHashCode();
                if (this.Other != null)
                    hash = hash * 59 + this.Other.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.Missing != null)
                    hash = hash * 59 + this.Missing.GetHashCode();
                if (this.TermCount != null)
                    hash = hash * 59 + this.TermCount.GetHashCode();
                if (this.TermType != null)
                    hash = hash * 59 + this.TermType.GetHashCode();
                if (this.Terms != null)
                    hash = hash * 59 + this.Terms.GetHashCode();
                return hash;
            }
        }
    }

}
