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
    /// ChecklistInferenceJobCreationResponse
    /// </summary>
    [DataContract]
    public partial class ChecklistInferenceJobCreationResponse :  IEquatable<ChecklistInferenceJobCreationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistInferenceJobCreationResponse" /> class.
        /// </summary>
        /// <param name="JobId">ID of the inference job..</param>
        /// <param name="Message">Message with reason in case an inference job is not created..</param>
        public ChecklistInferenceJobCreationResponse(string JobId = null, string Message = null)
        {
            this.JobId = JobId;
            this.Message = Message;
            
        }
        


        /// <summary>
        /// ID of the inference job.
        /// </summary>
        /// <value>ID of the inference job.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }



        /// <summary>
        /// Message with reason in case an inference job is not created.
        /// </summary>
        /// <value>Message with reason in case an inference job is not created.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChecklistInferenceJobCreationResponse {\n");

            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as ChecklistInferenceJobCreationResponse);
        }

        /// <summary>
        /// Returns true if ChecklistInferenceJobCreationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ChecklistInferenceJobCreationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChecklistInferenceJobCreationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                return hash;
            }
        }
    }

}
