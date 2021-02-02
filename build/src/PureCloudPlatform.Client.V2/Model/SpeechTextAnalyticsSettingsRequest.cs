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
    /// SpeechTextAnalyticsSettingsRequest
    /// </summary>
    [DataContract]
    public partial class SpeechTextAnalyticsSettingsRequest :  IEquatable<SpeechTextAnalyticsSettingsRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechTextAnalyticsSettingsRequest" /> class.
        /// </summary>
        /// <param name="DefaultProgramId">Setting to choose name for the default program for topic detection.</param>
        /// <param name="ExpectedDialects">Setting to choose expected dialects.</param>
        public SpeechTextAnalyticsSettingsRequest(string DefaultProgramId = null, List<string> ExpectedDialects = null)
        {
            this.DefaultProgramId = DefaultProgramId;
            this.ExpectedDialects = ExpectedDialects;
            
        }
        
        
        
        /// <summary>
        /// Setting to choose name for the default program for topic detection
        /// </summary>
        /// <value>Setting to choose name for the default program for topic detection</value>
        [DataMember(Name="defaultProgramId", EmitDefaultValue=false)]
        public string DefaultProgramId { get; set; }
        
        
        
        /// <summary>
        /// Setting to choose expected dialects
        /// </summary>
        /// <value>Setting to choose expected dialects</value>
        [DataMember(Name="expectedDialects", EmitDefaultValue=false)]
        public List<string> ExpectedDialects { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeechTextAnalyticsSettingsRequest {\n");
            
            sb.Append("  DefaultProgramId: ").Append(DefaultProgramId).Append("\n");
            sb.Append("  ExpectedDialects: ").Append(ExpectedDialects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SpeechTextAnalyticsSettingsRequest);
        }

        /// <summary>
        /// Returns true if SpeechTextAnalyticsSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SpeechTextAnalyticsSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpeechTextAnalyticsSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DefaultProgramId == other.DefaultProgramId ||
                    this.DefaultProgramId != null &&
                    this.DefaultProgramId.Equals(other.DefaultProgramId)
                ) &&
                (
                    this.ExpectedDialects == other.ExpectedDialects ||
                    this.ExpectedDialects != null &&
                    this.ExpectedDialects.SequenceEqual(other.ExpectedDialects)
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
                
                if (this.DefaultProgramId != null)
                    hash = hash * 59 + this.DefaultProgramId.GetHashCode();
                
                if (this.ExpectedDialects != null)
                    hash = hash * 59 + this.ExpectedDialects.GetHashCode();
                
                return hash;
            }
        }
    }

}
