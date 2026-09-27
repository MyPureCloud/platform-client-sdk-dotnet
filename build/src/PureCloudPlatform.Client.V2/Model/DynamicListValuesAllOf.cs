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
    /// DynamicListValuesAllOf
    /// </summary>
    [DataContract]
    public partial class DynamicListValuesAllOf :  IEquatable<DynamicListValuesAllOf>
    {
        /// <summary>
        /// Defines how matching should work at runtime. Only 'Exact' matching is supported for dynamic lists.
        /// </summary>
        /// <value>Defines how matching should work at runtime. Only 'Exact' matching is supported for dynamic lists.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MatchTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Exact for "Exact"
            /// </summary>
            [EnumMember(Value = "Exact")]
            Exact,
            
            /// <summary>
            /// Enum Semantic for "Semantic"
            /// </summary>
            [EnumMember(Value = "Semantic")]
            Semantic
        }
        /// <summary>
        /// Defines how matching should work at runtime. Only 'Exact' matching is supported for dynamic lists.
        /// </summary>
        /// <value>Defines how matching should work at runtime. Only 'Exact' matching is supported for dynamic lists.</value>
        [DataMember(Name="matchType", EmitDefaultValue=false)]
        public MatchTypeEnum? MatchType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicListValuesAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicListValuesAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicListValuesAllOf" /> class.
        /// </summary>
        /// <param name="DataActionId">The ID of the data action to invoke at runtime to retrieve list values and synonyms. (required).</param>
        /// <param name="Inputs">Array of input mappings for the data action. Maps guide variables to data action input parameters..</param>
        /// <param name="FieldMapping">FieldMapping (required).</param>
        /// <param name="MatchType">Defines how matching should work at runtime. Only &#39;Exact&#39; matching is supported for dynamic lists. (required).</param>
        public DynamicListValuesAllOf(string DataActionId = null, List<DataActionInput> Inputs = null, FieldMapping FieldMapping = null, MatchTypeEnum? MatchType = null)
        {
            this.DataActionId = DataActionId;
            this.Inputs = Inputs;
            this.FieldMapping = FieldMapping;
            this.MatchType = MatchType;
            
        }
        


        /// <summary>
        /// The ID of the data action to invoke at runtime to retrieve list values and synonyms.
        /// </summary>
        /// <value>The ID of the data action to invoke at runtime to retrieve list values and synonyms.</value>
        [DataMember(Name="dataActionId", EmitDefaultValue=false)]
        public string DataActionId { get; set; }



        /// <summary>
        /// Array of input mappings for the data action. Maps guide variables to data action input parameters.
        /// </summary>
        /// <value>Array of input mappings for the data action. Maps guide variables to data action input parameters.</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<DataActionInput> Inputs { get; set; }



        /// <summary>
        /// Gets or Sets FieldMapping
        /// </summary>
        [DataMember(Name="fieldMapping", EmitDefaultValue=false)]
        public FieldMapping FieldMapping { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicListValuesAllOf {\n");

            sb.Append("  DataActionId: ").Append(DataActionId).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  FieldMapping: ").Append(FieldMapping).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
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
            return this.Equals(obj as DynamicListValuesAllOf);
        }

        /// <summary>
        /// Returns true if DynamicListValuesAllOf instances are equal
        /// </summary>
        /// <param name="other">Instance of DynamicListValuesAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicListValuesAllOf other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DataActionId == other.DataActionId ||
                    this.DataActionId != null &&
                    this.DataActionId.Equals(other.DataActionId)
                ) &&
                (
                    this.Inputs == other.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(other.Inputs)
                ) &&
                (
                    this.FieldMapping == other.FieldMapping ||
                    this.FieldMapping != null &&
                    this.FieldMapping.Equals(other.FieldMapping)
                ) &&
                (
                    this.MatchType == other.MatchType ||
                    this.MatchType != null &&
                    this.MatchType.Equals(other.MatchType)
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
                if (this.DataActionId != null)
                    hash = hash * 59 + this.DataActionId.GetHashCode();

                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();

                if (this.FieldMapping != null)
                    hash = hash * 59 + this.FieldMapping.GetHashCode();

                if (this.MatchType != null)
                    hash = hash * 59 + this.MatchType.GetHashCode();

                return hash;
            }
        }
    }

}
