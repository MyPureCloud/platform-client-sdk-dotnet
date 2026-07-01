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
    /// QueryReformulationContext
    /// </summary>
    [DataContract]
    public partial class QueryReformulationContext :  IEquatable<QueryReformulationContext>
    {
        /// <summary>
        /// The knowledge classification result indicating whether the query is appropriate for knowledge retrieval.
        /// </summary>
        /// <value>The knowledge classification result indicating whether the query is appropriate for knowledge retrieval.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KnowledgeClassificationEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Yes for "Yes"
            /// </summary>
            [EnumMember(Value = "Yes")]
            Yes,
            
            /// <summary>
            /// Enum No for "No"
            /// </summary>
            [EnumMember(Value = "No")]
            No,
            
            /// <summary>
            /// Enum Maybe for "Maybe"
            /// </summary>
            [EnumMember(Value = "Maybe")]
            Maybe
        }
        /// <summary>
        /// The knowledge classification result indicating whether the query is appropriate for knowledge retrieval.
        /// </summary>
        /// <value>The knowledge classification result indicating whether the query is appropriate for knowledge retrieval.</value>
        [DataMember(Name="knowledgeClassification", EmitDefaultValue=false)]
        public KnowledgeClassificationEnum? KnowledgeClassification { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryReformulationContext" /> class.
        /// </summary>
        public QueryReformulationContext()
        {
            
        }
        




        /// <summary>
        /// The reformulated standalone query optimized for retrieval, if query reformulation was enabled and produced a result.
        /// </summary>
        /// <value>The reformulated standalone query optimized for retrieval, if query reformulation was enabled and produced a result.</value>
        [DataMember(Name="reformulatedQuery", EmitDefaultValue=false)]
        public string ReformulatedQuery { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryReformulationContext {\n");

            sb.Append("  KnowledgeClassification: ").Append(KnowledgeClassification).Append("\n");
            sb.Append("  ReformulatedQuery: ").Append(ReformulatedQuery).Append("\n");
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
            return this.Equals(obj as QueryReformulationContext);
        }

        /// <summary>
        /// Returns true if QueryReformulationContext instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryReformulationContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryReformulationContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.KnowledgeClassification == other.KnowledgeClassification ||
                    this.KnowledgeClassification != null &&
                    this.KnowledgeClassification.Equals(other.KnowledgeClassification)
                ) &&
                (
                    this.ReformulatedQuery == other.ReformulatedQuery ||
                    this.ReformulatedQuery != null &&
                    this.ReformulatedQuery.Equals(other.ReformulatedQuery)
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
                if (this.KnowledgeClassification != null)
                    hash = hash * 59 + this.KnowledgeClassification.GetHashCode();

                if (this.ReformulatedQuery != null)
                    hash = hash * 59 + this.ReformulatedQuery.GetHashCode();

                return hash;
            }
        }
    }

}
