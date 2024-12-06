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
    /// DataIngestionRules
    /// </summary>
    [DataContract]
    public partial class DataIngestionRules :  IEquatable<DataIngestionRules>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataIngestionRules" /> class.
        /// </summary>
        /// <param name="Twitter">A list of X (formally Twitter) data ingestion rules..</param>
        /// <param name="Open">A list of Open data ingestion rules..</param>
        /// <param name="Facebook">A list of Facebook data ingestion rules..</param>
        public DataIngestionRules(List<TwitterDataIngestionRuleResponse> Twitter = null, List<OpenDataIngestionRuleResponse> Open = null, List<FacebookDataIngestionRuleResponse> Facebook = null)
        {
            this.Twitter = Twitter;
            this.Open = Open;
            this.Facebook = Facebook;
            
        }
        


        /// <summary>
        /// A list of X (formally Twitter) data ingestion rules.
        /// </summary>
        /// <value>A list of X (formally Twitter) data ingestion rules.</value>
        [DataMember(Name="twitter", EmitDefaultValue=false)]
        public List<TwitterDataIngestionRuleResponse> Twitter { get; set; }



        /// <summary>
        /// A list of Open data ingestion rules.
        /// </summary>
        /// <value>A list of Open data ingestion rules.</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public List<OpenDataIngestionRuleResponse> Open { get; set; }



        /// <summary>
        /// A list of Facebook data ingestion rules.
        /// </summary>
        /// <value>A list of Facebook data ingestion rules.</value>
        [DataMember(Name="facebook", EmitDefaultValue=false)]
        public List<FacebookDataIngestionRuleResponse> Facebook { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataIngestionRules {\n");

            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Facebook: ").Append(Facebook).Append("\n");
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
            return this.Equals(obj as DataIngestionRules);
        }

        /// <summary>
        /// Returns true if DataIngestionRules instances are equal
        /// </summary>
        /// <param name="other">Instance of DataIngestionRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataIngestionRules other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Twitter == other.Twitter ||
                    this.Twitter != null &&
                    this.Twitter.SequenceEqual(other.Twitter)
                ) &&
                (
                    this.Open == other.Open ||
                    this.Open != null &&
                    this.Open.SequenceEqual(other.Open)
                ) &&
                (
                    this.Facebook == other.Facebook ||
                    this.Facebook != null &&
                    this.Facebook.SequenceEqual(other.Facebook)
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
                if (this.Twitter != null)
                    hash = hash * 59 + this.Twitter.GetHashCode();

                if (this.Open != null)
                    hash = hash * 59 + this.Open.GetHashCode();

                if (this.Facebook != null)
                    hash = hash * 59 + this.Facebook.GetHashCode();

                return hash;
            }
        }
    }

}
