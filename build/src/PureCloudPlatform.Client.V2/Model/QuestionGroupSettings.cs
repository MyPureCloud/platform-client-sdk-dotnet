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
    /// QuestionGroupSettings
    /// </summary>
    [DataContract]
    public partial class QuestionGroupSettings :  IEquatable<QuestionGroupSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionGroupSettings" /> class.
        /// </summary>
        /// <param name="QuestionGroupContextId">The context id of the question group in the form..</param>
        /// <param name="QuestionSettings">QuestionSettings.</param>
        public QuestionGroupSettings(string QuestionGroupContextId = null, List<QuestionSettings> QuestionSettings = null)
        {
            this.QuestionGroupContextId = QuestionGroupContextId;
            this.QuestionSettings = QuestionSettings;
            
        }
        


        /// <summary>
        /// The context id of the question group in the form.
        /// </summary>
        /// <value>The context id of the question group in the form.</value>
        [DataMember(Name="questionGroupContextId", EmitDefaultValue=false)]
        public string QuestionGroupContextId { get; set; }



        /// <summary>
        /// Gets or Sets QuestionSettings
        /// </summary>
        [DataMember(Name="questionSettings", EmitDefaultValue=false)]
        public List<QuestionSettings> QuestionSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionGroupSettings {\n");

            sb.Append("  QuestionGroupContextId: ").Append(QuestionGroupContextId).Append("\n");
            sb.Append("  QuestionSettings: ").Append(QuestionSettings).Append("\n");
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
            return this.Equals(obj as QuestionGroupSettings);
        }

        /// <summary>
        /// Returns true if QuestionGroupSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of QuestionGroupSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionGroupSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QuestionGroupContextId == other.QuestionGroupContextId ||
                    this.QuestionGroupContextId != null &&
                    this.QuestionGroupContextId.Equals(other.QuestionGroupContextId)
                ) &&
                (
                    this.QuestionSettings == other.QuestionSettings ||
                    this.QuestionSettings != null &&
                    this.QuestionSettings.SequenceEqual(other.QuestionSettings)
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
                if (this.QuestionGroupContextId != null)
                    hash = hash * 59 + this.QuestionGroupContextId.GetHashCode();

                if (this.QuestionSettings != null)
                    hash = hash * 59 + this.QuestionSettings.GetHashCode();

                return hash;
            }
        }
    }

}
