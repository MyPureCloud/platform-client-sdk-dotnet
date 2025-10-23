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
    /// AgentCopilotAggregationSort
    /// </summary>
    [DataContract]
    public partial class AgentCopilotAggregationSort :  IEquatable<AgentCopilotAggregationSort>
    {
        /// <summary>
        /// Name of the metric used for sorting values.
        /// </summary>
        /// <value>Name of the metric used for sorting values.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ncannedresponsesuggestions for "nCannedResponseSuggestions"
            /// </summary>
            [EnumMember(Value = "nCannedResponseSuggestions")]
            Ncannedresponsesuggestions,
            
            /// <summary>
            /// Enum Ndistinctsuggestions for "nDistinctSuggestions"
            /// </summary>
            [EnumMember(Value = "nDistinctSuggestions")]
            Ndistinctsuggestions,
            
            /// <summary>
            /// Enum Nknowledgearticlesuggestions for "nKnowledgeArticleSuggestions"
            /// </summary>
            [EnumMember(Value = "nKnowledgeArticleSuggestions")]
            Nknowledgearticlesuggestions,
            
            /// <summary>
            /// Enum Nknowledgesearchsuggestions for "nKnowledgeSearchSuggestions"
            /// </summary>
            [EnumMember(Value = "nKnowledgeSearchSuggestions")]
            Nknowledgesearchsuggestions,
            
            /// <summary>
            /// Enum Nscriptsuggestions for "nScriptSuggestions"
            /// </summary>
            [EnumMember(Value = "nScriptSuggestions")]
            Nscriptsuggestions
        }
        /// <summary>
        /// Aggregation function used for the sort metric.
        /// </summary>
        /// <value>Aggregation function used for the sort metric.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FunctionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Count for "count"
            /// </summary>
            [EnumMember(Value = "count")]
            Count,
            
            /// <summary>
            /// Enum Max for "max"
            /// </summary>
            [EnumMember(Value = "max")]
            Max,
            
            /// <summary>
            /// Enum Min for "min"
            /// </summary>
            [EnumMember(Value = "min")]
            Min,
            
            /// <summary>
            /// Enum Sum for "sum"
            /// </summary>
            [EnumMember(Value = "sum")]
            Sum
        }
        /// <summary>
        /// Name of the metric used for sorting values.
        /// </summary>
        /// <value>Name of the metric used for sorting values.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Aggregation function used for the sort metric.
        /// </summary>
        /// <value>Aggregation function used for the sort metric.</value>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public FunctionEnum? Function { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCopilotAggregationSort" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentCopilotAggregationSort() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCopilotAggregationSort" /> class.
        /// </summary>
        /// <param name="Name">Name of the metric used for sorting values. (required).</param>
        /// <param name="Function">Aggregation function used for the sort metric. (required).</param>
        public AgentCopilotAggregationSort(NameEnum? Name = null, FunctionEnum? Function = null)
        {
            this.Name = Name;
            this.Function = Function;
            
        }
        





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentCopilotAggregationSort {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
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
            return this.Equals(obj as AgentCopilotAggregationSort);
        }

        /// <summary>
        /// Returns true if AgentCopilotAggregationSort instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentCopilotAggregationSort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentCopilotAggregationSort other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Function == other.Function ||
                    this.Function != null &&
                    this.Function.Equals(other.Function)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Function != null)
                    hash = hash * 59 + this.Function.GetHashCode();

                return hash;
            }
        }
    }

}
