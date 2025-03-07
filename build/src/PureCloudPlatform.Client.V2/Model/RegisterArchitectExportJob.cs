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
    /// RegisterArchitectExportJob
    /// </summary>
    [DataContract]
    public partial class RegisterArchitectExportJob :  IEquatable<RegisterArchitectExportJob>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterArchitectExportJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterArchitectExportJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterArchitectExportJob" /> class.
        /// </summary>
        /// <param name="Flows">A list of the flows to be exported. (required).</param>
        public RegisterArchitectExportJob(List<ExportDetails> Flows = null)
        {
            this.Flows = Flows;
            
        }
        


        /// <summary>
        /// A list of the flows to be exported.
        /// </summary>
        /// <value>A list of the flows to be exported.</value>
        [DataMember(Name="flows", EmitDefaultValue=false)]
        public List<ExportDetails> Flows { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterArchitectExportJob {\n");

            sb.Append("  Flows: ").Append(Flows).Append("\n");
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
            return this.Equals(obj as RegisterArchitectExportJob);
        }

        /// <summary>
        /// Returns true if RegisterArchitectExportJob instances are equal
        /// </summary>
        /// <param name="other">Instance of RegisterArchitectExportJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterArchitectExportJob other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Flows == other.Flows ||
                    this.Flows != null &&
                    this.Flows.SequenceEqual(other.Flows)
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
                if (this.Flows != null)
                    hash = hash * 59 + this.Flows.GetHashCode();

                return hash;
            }
        }
    }

}
