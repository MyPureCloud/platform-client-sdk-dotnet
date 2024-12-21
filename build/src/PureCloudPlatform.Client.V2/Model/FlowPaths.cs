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
    /// FlowPaths
    /// </summary>
    [DataContract]
    public partial class FlowPaths :  IEquatable<FlowPaths>
    {
        /// <summary>
        /// Category (use case) of the paths within a given domain.
        /// </summary>
        /// <value>Category (use case) of the paths within a given domain.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Abandoned for "Abandoned"
            /// </summary>
            [EnumMember(Value = "Abandoned")]
            Abandoned,
            
            /// <summary>
            /// Enum Agentescalation for "AgentEscalation"
            /// </summary>
            [EnumMember(Value = "AgentEscalation")]
            Agentescalation,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Disconnect for "Disconnect"
            /// </summary>
            [EnumMember(Value = "Disconnect")]
            Disconnect,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Recognitionfailure for "RecognitionFailure"
            /// </summary>
            [EnumMember(Value = "RecognitionFailure")]
            Recognitionfailure,
            
            /// <summary>
            /// Enum Transfer for "Transfer"
            /// </summary>
            [EnumMember(Value = "Transfer")]
            Transfer
        }
        /// <summary>
        /// Category (use case) of the paths within a given domain.
        /// </summary>
        /// <value>Category (use case) of the paths within a given domain.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowPaths" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowPaths() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowPaths" /> class.
        /// </summary>
        /// <param name="Category">Category (use case) of the paths within a given domain. (required).</param>
        /// <param name="DateStart">Start date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateEnd">End date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Elements">Unique element identifiers and their corresponding elements in the trie data structure representing the paths. (required).</param>
        public FlowPaths(CategoryEnum? Category = null, DateTime? DateStart = null, DateTime? DateEnd = null, Dictionary<string, FlowPathsElement> Elements = null)
        {
            this.Category = Category;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.Elements = Elements;
            
        }
        




        /// <summary>
        /// Start date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// End date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>End date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }



        /// <summary>
        /// Unique element identifiers and their corresponding elements in the trie data structure representing the paths.
        /// </summary>
        /// <value>Unique element identifiers and their corresponding elements in the trie data structure representing the paths.</value>
        [DataMember(Name="elements", EmitDefaultValue=false)]
        public Dictionary<string, FlowPathsElement> Elements { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowPaths {\n");

            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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
            return this.Equals(obj as FlowPaths);
        }

        /// <summary>
        /// Returns true if FlowPaths instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowPaths to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowPaths other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.Elements == other.Elements ||
                    this.Elements != null &&
                    this.Elements.SequenceEqual(other.Elements)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                if (this.Elements != null)
                    hash = hash * 59 + this.Elements.GetHashCode();

                return hash;
            }
        }
    }

}
