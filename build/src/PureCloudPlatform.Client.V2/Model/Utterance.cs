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
    /// Utterance
    /// </summary>
    [DataContract]
    public partial class Utterance :  IEquatable<Utterance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Utterance" /> class.
        /// </summary>
        /// <param name="UtteranceText">Utterance text.</param>
        public Utterance(string UtteranceText = null)
        {
            this.UtteranceText = UtteranceText;
            
        }
        


        /// <summary>
        /// Utterance text
        /// </summary>
        /// <value>Utterance text</value>
        [DataMember(Name="utteranceText", EmitDefaultValue=false)]
        public string UtteranceText { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Utterance {\n");

            sb.Append("  UtteranceText: ").Append(UtteranceText).Append("\n");
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
            return this.Equals(obj as Utterance);
        }

        /// <summary>
        /// Returns true if Utterance instances are equal
        /// </summary>
        /// <param name="other">Instance of Utterance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Utterance other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UtteranceText == other.UtteranceText ||
                    this.UtteranceText != null &&
                    this.UtteranceText.Equals(other.UtteranceText)
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
                if (this.UtteranceText != null)
                    hash = hash * 59 + this.UtteranceText.GetHashCode();

                return hash;
            }
        }
    }

}
