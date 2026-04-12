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
    /// IntakeSettingsUpdate
    /// </summary>
    [DataContract]
    public partial class IntakeSettingsUpdate :  IEquatable<IntakeSettingsUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntakeSettingsUpdate" /> class.
        /// </summary>
        /// <param name="IntakeSettings">The intake settings for the Caseplan..</param>
        public IntakeSettingsUpdate(List<IntakeSetting> IntakeSettings = null)
        {
            this.IntakeSettings = IntakeSettings;
            
        }
        


        /// <summary>
        /// The intake settings for the Caseplan.
        /// </summary>
        /// <value>The intake settings for the Caseplan.</value>
        [DataMember(Name="intakeSettings", EmitDefaultValue=false)]
        public List<IntakeSetting> IntakeSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntakeSettingsUpdate {\n");

            sb.Append("  IntakeSettings: ").Append(IntakeSettings).Append("\n");
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
            return this.Equals(obj as IntakeSettingsUpdate);
        }

        /// <summary>
        /// Returns true if IntakeSettingsUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of IntakeSettingsUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntakeSettingsUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IntakeSettings == other.IntakeSettings ||
                    this.IntakeSettings != null &&
                    this.IntakeSettings.SequenceEqual(other.IntakeSettings)
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
                if (this.IntakeSettings != null)
                    hash = hash * 59 + this.IntakeSettings.GetHashCode();

                return hash;
            }
        }
    }

}
