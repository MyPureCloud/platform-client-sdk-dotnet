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
    /// WorkitemSettingsResponse
    /// </summary>
    [DataContract]
    public partial class WorkitemSettingsResponse :  IEquatable<WorkitemSettingsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemSettingsResponse" /> class.
        /// </summary>
        /// <param name="Worktype">The worktype information for the workitem settings..</param>
        public WorkitemSettingsResponse(StepplansWorktypeReference Worktype = null)
        {
            this.Worktype = Worktype;
            
        }
        


        /// <summary>
        /// The worktype information for the workitem settings.
        /// </summary>
        /// <value>The worktype information for the workitem settings.</value>
        [DataMember(Name="worktype", EmitDefaultValue=false)]
        public StepplansWorktypeReference Worktype { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemSettingsResponse {\n");

            sb.Append("  Worktype: ").Append(Worktype).Append("\n");
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
            return this.Equals(obj as WorkitemSettingsResponse);
        }

        /// <summary>
        /// Returns true if WorkitemSettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemSettingsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Worktype == other.Worktype ||
                    this.Worktype != null &&
                    this.Worktype.Equals(other.Worktype)
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
                if (this.Worktype != null)
                    hash = hash * 59 + this.Worktype.GetHashCode();

                return hash;
            }
        }
    }

}
