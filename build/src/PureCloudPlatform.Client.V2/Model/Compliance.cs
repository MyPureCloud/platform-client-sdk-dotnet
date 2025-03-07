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
    /// Compliance
    /// </summary>
    [DataContract]
    public partial class Compliance :  IEquatable<Compliance>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Compliance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Compliance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Compliance" /> class.
        /// </summary>
        /// <param name="StopSettings">List of configurations for &#39;StopSettings&#39; compliance (required).</param>
        /// <param name="OptInSettings">List of configurations for &#39;OptInSettings&#39; compliance (required).</param>
        /// <param name="HelpSettings">List of configurations for &#39;HelpSettings&#39; compliance (required).</param>
        public Compliance(List<StopSettings> StopSettings = null, List<OptInSettings> OptInSettings = null, List<HelpSettings> HelpSettings = null)
        {
            this.StopSettings = StopSettings;
            this.OptInSettings = OptInSettings;
            this.HelpSettings = HelpSettings;
            
        }
        


        /// <summary>
        /// List of configurations for &#39;StopSettings&#39; compliance
        /// </summary>
        /// <value>List of configurations for &#39;StopSettings&#39; compliance</value>
        [DataMember(Name="stopSettings", EmitDefaultValue=false)]
        public List<StopSettings> StopSettings { get; set; }



        /// <summary>
        /// List of configurations for &#39;OptInSettings&#39; compliance
        /// </summary>
        /// <value>List of configurations for &#39;OptInSettings&#39; compliance</value>
        [DataMember(Name="optInSettings", EmitDefaultValue=false)]
        public List<OptInSettings> OptInSettings { get; set; }



        /// <summary>
        /// List of configurations for &#39;HelpSettings&#39; compliance
        /// </summary>
        /// <value>List of configurations for &#39;HelpSettings&#39; compliance</value>
        [DataMember(Name="helpSettings", EmitDefaultValue=false)]
        public List<HelpSettings> HelpSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Compliance {\n");

            sb.Append("  StopSettings: ").Append(StopSettings).Append("\n");
            sb.Append("  OptInSettings: ").Append(OptInSettings).Append("\n");
            sb.Append("  HelpSettings: ").Append(HelpSettings).Append("\n");
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
            return this.Equals(obj as Compliance);
        }

        /// <summary>
        /// Returns true if Compliance instances are equal
        /// </summary>
        /// <param name="other">Instance of Compliance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Compliance other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StopSettings == other.StopSettings ||
                    this.StopSettings != null &&
                    this.StopSettings.SequenceEqual(other.StopSettings)
                ) &&
                (
                    this.OptInSettings == other.OptInSettings ||
                    this.OptInSettings != null &&
                    this.OptInSettings.SequenceEqual(other.OptInSettings)
                ) &&
                (
                    this.HelpSettings == other.HelpSettings ||
                    this.HelpSettings != null &&
                    this.HelpSettings.SequenceEqual(other.HelpSettings)
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
                if (this.StopSettings != null)
                    hash = hash * 59 + this.StopSettings.GetHashCode();

                if (this.OptInSettings != null)
                    hash = hash * 59 + this.OptInSettings.GetHashCode();

                if (this.HelpSettings != null)
                    hash = hash * 59 + this.HelpSettings.GetHashCode();

                return hash;
            }
        }
    }

}
