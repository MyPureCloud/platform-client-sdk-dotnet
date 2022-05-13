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
    /// Learning module users query request model
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentUserQuery :  IEquatable<LearningAssignmentUserQuery>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentUserQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningAssignmentUserQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentUserQuery" /> class.
        /// </summary>
        /// <param name="Rule">Learning module rule object (required).</param>
        /// <param name="SearchTerm">The user name to be searched for.</param>
        public LearningAssignmentUserQuery(LearningModuleRule Rule = null, string SearchTerm = null)
        {
            this.Rule = Rule;
            this.SearchTerm = SearchTerm;
            
        }
        


        /// <summary>
        /// Learning module rule object
        /// </summary>
        /// <value>Learning module rule object</value>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public LearningModuleRule Rule { get; set; }



        /// <summary>
        /// The user name to be searched for
        /// </summary>
        /// <value>The user name to be searched for</value>
        [DataMember(Name="searchTerm", EmitDefaultValue=false)]
        public string SearchTerm { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentUserQuery {\n");

            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  SearchTerm: ").Append(SearchTerm).Append("\n");
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
            return this.Equals(obj as LearningAssignmentUserQuery);
        }

        /// <summary>
        /// Returns true if LearningAssignmentUserQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentUserQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentUserQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Rule == other.Rule ||
                    this.Rule != null &&
                    this.Rule.Equals(other.Rule)
                ) &&
                (
                    this.SearchTerm == other.SearchTerm ||
                    this.SearchTerm != null &&
                    this.SearchTerm.Equals(other.SearchTerm)
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
                if (this.Rule != null)
                    hash = hash * 59 + this.Rule.GetHashCode();

                if (this.SearchTerm != null)
                    hash = hash * 59 + this.SearchTerm.GetHashCode();

                return hash;
            }
        }
    }

}
