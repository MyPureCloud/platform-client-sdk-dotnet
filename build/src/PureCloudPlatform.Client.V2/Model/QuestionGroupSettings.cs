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
        /// <param name="QuestionGroupIndex">This field represents the location of the Question Group in the form. Note: Indexes are zero-based.</param>
        /// <param name="QuestionSettings">QuestionSettings.</param>
        public QuestionGroupSettings(int? QuestionGroupIndex = null, List<QuestionSettings> QuestionSettings = null)
        {
            this.QuestionGroupIndex = QuestionGroupIndex;
            this.QuestionSettings = QuestionSettings;
            
        }
        


        /// <summary>
        /// This field represents the location of the Question Group in the form. Note: Indexes are zero-based
        /// </summary>
        /// <value>This field represents the location of the Question Group in the form. Note: Indexes are zero-based</value>
        [DataMember(Name="questionGroupIndex", EmitDefaultValue=false)]
        public int? QuestionGroupIndex { get; set; }



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

            sb.Append("  QuestionGroupIndex: ").Append(QuestionGroupIndex).Append("\n");
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
                    this.QuestionGroupIndex == other.QuestionGroupIndex ||
                    this.QuestionGroupIndex != null &&
                    this.QuestionGroupIndex.Equals(other.QuestionGroupIndex)
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
                if (this.QuestionGroupIndex != null)
                    hash = hash * 59 + this.QuestionGroupIndex.GetHashCode();

                if (this.QuestionSettings != null)
                    hash = hash * 59 + this.QuestionSettings.GetHashCode();

                return hash;
            }
        }
    }

}
