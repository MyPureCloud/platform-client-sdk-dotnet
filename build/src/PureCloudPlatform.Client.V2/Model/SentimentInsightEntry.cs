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
    /// SentimentInsightEntry
    /// </summary>
    [DataContract]
    public partial class SentimentInsightEntry :  IEquatable<SentimentInsightEntry>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentInsightEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SentimentInsightEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentInsightEntry" /> class.
        /// </summary>
        /// <param name="Title">The title given to the insight (required).</param>
        /// <param name="Description">A short description of the insight (required).</param>
        public SentimentInsightEntry(string Title = null, string Description = null)
        {
            this.Title = Title;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// The title given to the insight
        /// </summary>
        /// <value>The title given to the insight</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// A short description of the insight
        /// </summary>
        /// <value>A short description of the insight</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SentimentInsightEntry {\n");

            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as SentimentInsightEntry);
        }

        /// <summary>
        /// Returns true if SentimentInsightEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of SentimentInsightEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentimentInsightEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                return hash;
            }
        }
    }

}
