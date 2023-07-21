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
    /// SpeechTextAnalyticsSettingsResponse
    /// </summary>
    [DataContract]
    public partial class SpeechTextAnalyticsSettingsResponse :  IEquatable<SpeechTextAnalyticsSettingsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechTextAnalyticsSettingsResponse" /> class.
        /// </summary>
        /// <param name="DefaultProgram">Setting to choose name for the default program for topic detection.</param>
        /// <param name="ExpectedDialects">Setting to choose expected dialects.</param>
        /// <param name="TextAnalyticsEnabled">Setting to enable/disable text analytics.</param>
        public SpeechTextAnalyticsSettingsResponse(AddressableEntityRef DefaultProgram = null, List<string> ExpectedDialects = null, bool? TextAnalyticsEnabled = null)
        {
            this.DefaultProgram = DefaultProgram;
            this.ExpectedDialects = ExpectedDialects;
            this.TextAnalyticsEnabled = TextAnalyticsEnabled;
            
        }
        


        /// <summary>
        /// Setting to choose name for the default program for topic detection
        /// </summary>
        /// <value>Setting to choose name for the default program for topic detection</value>
        [DataMember(Name="defaultProgram", EmitDefaultValue=false)]
        public AddressableEntityRef DefaultProgram { get; set; }



        /// <summary>
        /// Setting to choose expected dialects
        /// </summary>
        /// <value>Setting to choose expected dialects</value>
        [DataMember(Name="expectedDialects", EmitDefaultValue=false)]
        public List<string> ExpectedDialects { get; set; }



        /// <summary>
        /// Setting to enable/disable text analytics
        /// </summary>
        /// <value>Setting to enable/disable text analytics</value>
        [DataMember(Name="textAnalyticsEnabled", EmitDefaultValue=false)]
        public bool? TextAnalyticsEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeechTextAnalyticsSettingsResponse {\n");

            sb.Append("  DefaultProgram: ").Append(DefaultProgram).Append("\n");
            sb.Append("  ExpectedDialects: ").Append(ExpectedDialects).Append("\n");
            sb.Append("  TextAnalyticsEnabled: ").Append(TextAnalyticsEnabled).Append("\n");
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
            return this.Equals(obj as SpeechTextAnalyticsSettingsResponse);
        }

        /// <summary>
        /// Returns true if SpeechTextAnalyticsSettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SpeechTextAnalyticsSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpeechTextAnalyticsSettingsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DefaultProgram == other.DefaultProgram ||
                    this.DefaultProgram != null &&
                    this.DefaultProgram.Equals(other.DefaultProgram)
                ) &&
                (
                    this.ExpectedDialects == other.ExpectedDialects ||
                    this.ExpectedDialects != null &&
                    this.ExpectedDialects.SequenceEqual(other.ExpectedDialects)
                ) &&
                (
                    this.TextAnalyticsEnabled == other.TextAnalyticsEnabled ||
                    this.TextAnalyticsEnabled != null &&
                    this.TextAnalyticsEnabled.Equals(other.TextAnalyticsEnabled)
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
                if (this.DefaultProgram != null)
                    hash = hash * 59 + this.DefaultProgram.GetHashCode();

                if (this.ExpectedDialects != null)
                    hash = hash * 59 + this.ExpectedDialects.GetHashCode();

                if (this.TextAnalyticsEnabled != null)
                    hash = hash * 59 + this.TextAnalyticsEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
