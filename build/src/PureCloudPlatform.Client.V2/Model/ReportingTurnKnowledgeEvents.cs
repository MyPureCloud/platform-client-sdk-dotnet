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
    /// ReportingTurnKnowledgeEvents
    /// </summary>
    [DataContract]
    public partial class ReportingTurnKnowledgeEvents :  IEquatable<ReportingTurnKnowledgeEvents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTurnKnowledgeEvents" /> class.
        /// </summary>
        /// <param name="Search">The knowledge search data captured during this reporting turn..</param>
        /// <param name="Feedback">The knowledge feedback data captured during this reporting turn..</param>
        public ReportingTurnKnowledgeEvents(List<ReportingTurnKnowledgeSearchEvent> Search = null, List<ReportingTurnKnowledgeFeedbackEvent> Feedback = null)
        {
            this.Search = Search;
            this.Feedback = Feedback;
            
        }
        


        /// <summary>
        /// The knowledge search data captured during this reporting turn.
        /// </summary>
        /// <value>The knowledge search data captured during this reporting turn.</value>
        [DataMember(Name="search", EmitDefaultValue=false)]
        public List<ReportingTurnKnowledgeSearchEvent> Search { get; set; }



        /// <summary>
        /// The knowledge feedback data captured during this reporting turn.
        /// </summary>
        /// <value>The knowledge feedback data captured during this reporting turn.</value>
        [DataMember(Name="feedback", EmitDefaultValue=false)]
        public List<ReportingTurnKnowledgeFeedbackEvent> Feedback { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTurnKnowledgeEvents {\n");

            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
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
            return this.Equals(obj as ReportingTurnKnowledgeEvents);
        }

        /// <summary>
        /// Returns true if ReportingTurnKnowledgeEvents instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingTurnKnowledgeEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTurnKnowledgeEvents other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Search == other.Search ||
                    this.Search != null &&
                    this.Search.SequenceEqual(other.Search)
                ) &&
                (
                    this.Feedback == other.Feedback ||
                    this.Feedback != null &&
                    this.Feedback.SequenceEqual(other.Feedback)
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
                if (this.Search != null)
                    hash = hash * 59 + this.Search.GetHashCode();

                if (this.Feedback != null)
                    hash = hash * 59 + this.Feedback.GetHashCode();

                return hash;
            }
        }
    }

}
