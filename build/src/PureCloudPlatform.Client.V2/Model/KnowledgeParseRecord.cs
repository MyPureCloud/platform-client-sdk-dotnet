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
    /// KnowledgeParseRecord
    /// </summary>
    [DataContract]
    public partial class KnowledgeParseRecord :  IEquatable<KnowledgeParseRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeParseRecord" /> class.
        /// </summary>
        /// <param name="Id">Unique id for the parsed data..</param>
        /// <param name="Title">Parsed article title..</param>
        /// <param name="Body">Parsed article content..</param>
        public KnowledgeParseRecord(string Id = null, string Title = null, DocumentBody Body = null)
        {
            this.Id = Id;
            this.Title = Title;
            this.Body = Body;
            
        }
        


        /// <summary>
        /// Unique id for the parsed data.
        /// </summary>
        /// <value>Unique id for the parsed data.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Parsed article title.
        /// </summary>
        /// <value>Parsed article title.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Parsed article content.
        /// </summary>
        /// <value>Parsed article content.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public DocumentBody Body { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeParseRecord {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(obj as KnowledgeParseRecord);
        }

        /// <summary>
        /// Returns true if KnowledgeParseRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeParseRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeParseRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                return hash;
            }
        }
    }

}
