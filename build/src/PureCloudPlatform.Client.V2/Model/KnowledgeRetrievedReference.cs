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
    /// KnowledgeRetrievedReference
    /// </summary>
    [DataContract]
    public partial class KnowledgeRetrievedReference :  IEquatable<KnowledgeRetrievedReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeRetrievedReference" /> class.
        /// </summary>
        /// <param name="Confidence">The confidence associated with retrieved reference respect to a search query..</param>
        /// <param name="Text">The matching text for search query..</param>
        /// <param name="FileName">The file name from which reference is retrieved.</param>
        /// <param name="Url">The url of the file..</param>
        public KnowledgeRetrievedReference(double? Confidence = null, string Text = null, string FileName = null, string Url = null)
        {
            this.Confidence = Confidence;
            this.Text = Text;
            this.FileName = FileName;
            this.Url = Url;
            
        }
        


        /// <summary>
        /// The confidence associated with retrieved reference respect to a search query.
        /// </summary>
        /// <value>The confidence associated with retrieved reference respect to a search query.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }



        /// <summary>
        /// The matching text for search query.
        /// </summary>
        /// <value>The matching text for search query.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// The file name from which reference is retrieved
        /// </summary>
        /// <value>The file name from which reference is retrieved</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }



        /// <summary>
        /// The url of the file.
        /// </summary>
        /// <value>The url of the file.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeRetrievedReference {\n");

            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as KnowledgeRetrievedReference);
        }

        /// <summary>
        /// Returns true if KnowledgeRetrievedReference instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeRetrievedReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeRetrievedReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                return hash;
            }
        }
    }

}
