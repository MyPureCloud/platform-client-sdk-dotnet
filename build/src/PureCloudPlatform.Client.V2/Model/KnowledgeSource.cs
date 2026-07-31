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
    /// KnowledgeSource
    /// </summary>
    [DataContract]
    public partial class KnowledgeSource :  IEquatable<KnowledgeSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSource" /> class.
        /// </summary>
        /// <param name="SourceName">The name of the knowledge source..</param>
        /// <param name="Text">The retrieved source text content..</param>
        /// <param name="Url">URL of the source document..</param>
        /// <param name="Confidence">Confidence score for this knowledge source..</param>
        public KnowledgeSource(string SourceName = null, string Text = null, string Url = null, double? Confidence = null)
        {
            this.SourceName = SourceName;
            this.Text = Text;
            this.Url = Url;
            this.Confidence = Confidence;
            
        }
        


        /// <summary>
        /// The name of the knowledge source.
        /// </summary>
        /// <value>The name of the knowledge source.</value>
        [DataMember(Name="sourceName", EmitDefaultValue=false)]
        public string SourceName { get; set; }



        /// <summary>
        /// The retrieved source text content.
        /// </summary>
        /// <value>The retrieved source text content.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// URL of the source document.
        /// </summary>
        /// <value>URL of the source document.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Confidence score for this knowledge source.
        /// </summary>
        /// <value>Confidence score for this knowledge source.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeSource {\n");

            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
            return this.Equals(obj as KnowledgeSource);
        }

        /// <summary>
        /// Returns true if KnowledgeSource instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceName == other.SourceName ||
                    this.SourceName != null &&
                    this.SourceName.Equals(other.SourceName)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
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
                if (this.SourceName != null)
                    hash = hash * 59 + this.SourceName.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                return hash;
            }
        }
    }

}
