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
    /// WorkitemTerminate
    /// </summary>
    [DataContract]
    public partial class WorkitemTerminate :  IEquatable<WorkitemTerminate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemTerminate" /> class.
        /// </summary>
        /// <param name="StatusId">The ID of the status the workitem should be updated to when terminating. The status must be a &#39;Closed&#39; category status..</param>
        public WorkitemTerminate(string StatusId = null)
        {
            this.StatusId = StatusId;
            
        }
        


        /// <summary>
        /// The ID of the status the workitem should be updated to when terminating. The status must be a &#39;Closed&#39; category status.
        /// </summary>
        /// <value>The ID of the status the workitem should be updated to when terminating. The status must be a &#39;Closed&#39; category status.</value>
        [DataMember(Name="statusId", EmitDefaultValue=false)]
        public string StatusId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemTerminate {\n");

            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
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
            return this.Equals(obj as WorkitemTerminate);
        }

        /// <summary>
        /// Returns true if WorkitemTerminate instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemTerminate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemTerminate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StatusId == other.StatusId ||
                    this.StatusId != null &&
                    this.StatusId.Equals(other.StatusId)
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
                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();

                return hash;
            }
        }
    }

}
