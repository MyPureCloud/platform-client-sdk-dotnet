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
    /// RegisterArchitectJobRequest
    /// </summary>
    [DataContract]
    public partial class RegisterArchitectJobRequest :  IEquatable<RegisterArchitectJobRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterArchitectJobRequest" /> class.
        /// </summary>
        /// <param name="CreateStubs">If true, flow stubs will be created for any dependencies during the job..</param>
        public RegisterArchitectJobRequest(bool? CreateStubs = null)
        {
            this.CreateStubs = CreateStubs;
            
        }
        


        /// <summary>
        /// If true, flow stubs will be created for any dependencies during the job.
        /// </summary>
        /// <value>If true, flow stubs will be created for any dependencies during the job.</value>
        [DataMember(Name="createStubs", EmitDefaultValue=false)]
        public bool? CreateStubs { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterArchitectJobRequest {\n");

            sb.Append("  CreateStubs: ").Append(CreateStubs).Append("\n");
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
            return this.Equals(obj as RegisterArchitectJobRequest);
        }

        /// <summary>
        /// Returns true if RegisterArchitectJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RegisterArchitectJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterArchitectJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CreateStubs == other.CreateStubs ||
                    this.CreateStubs != null &&
                    this.CreateStubs.Equals(other.CreateStubs)
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
                if (this.CreateStubs != null)
                    hash = hash * 59 + this.CreateStubs.GetHashCode();

                return hash;
            }
        }
    }

}
