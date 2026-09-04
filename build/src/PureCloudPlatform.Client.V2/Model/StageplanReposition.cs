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
    /// StageplanReposition
    /// </summary>
    [DataContract]
    public partial class StageplanReposition :  IEquatable<StageplanReposition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StageplanReposition" /> class.
        /// </summary>
        /// <param name="After">The ID of the Stageplan to place this Stageplan after. Omit or null to move to the front..</param>
        public StageplanReposition(string After = null)
        {
            this.After = After;
            
        }
        


        /// <summary>
        /// The ID of the Stageplan to place this Stageplan after. Omit or null to move to the front.
        /// </summary>
        /// <value>The ID of the Stageplan to place this Stageplan after. Omit or null to move to the front.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StageplanReposition {\n");

            sb.Append("  After: ").Append(After).Append("\n");
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
            return this.Equals(obj as StageplanReposition);
        }

        /// <summary>
        /// Returns true if StageplanReposition instances are equal
        /// </summary>
        /// <param name="other">Instance of StageplanReposition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StageplanReposition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
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
                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();

                return hash;
            }
        }
    }

}
