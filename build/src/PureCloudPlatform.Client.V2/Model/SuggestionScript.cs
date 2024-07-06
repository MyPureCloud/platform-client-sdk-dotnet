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
    /// SuggestionScript
    /// </summary>
    [DataContract]
    public partial class SuggestionScript :  IEquatable<SuggestionScript>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionScript" /> class.
        /// </summary>
        public SuggestionScript()
        {
            
        }
        


        /// <summary>
        /// The suggested script.
        /// </summary>
        /// <value>The suggested script.</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public AddressableEntityRef Script { get; private set; }



        /// <summary>
        /// The page of the script.
        /// </summary>
        /// <value>The page of the script.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public AddressableEntityRef Page { get; private set; }



        /// <summary>
        /// The payload for the script.
        /// </summary>
        /// <value>The payload for the script.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, string> Data { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuggestionScript {\n");

            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as SuggestionScript);
        }

        /// <summary>
        /// Returns true if SuggestionScript instances are equal
        /// </summary>
        /// <param name="other">Instance of SuggestionScript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuggestionScript other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Script == other.Script ||
                    this.Script != null &&
                    this.Script.Equals(other.Script)
                ) &&
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                if (this.Script != null)
                    hash = hash * 59 + this.Script.GetHashCode();

                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();

                return hash;
            }
        }
    }

}
