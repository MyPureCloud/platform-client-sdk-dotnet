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
    /// Learning module preview update response
    /// </summary>
    [DataContract]
    public partial class LearningModulePreviewUpdateResponse :  IEquatable<LearningModulePreviewUpdateResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateResponse" /> class.
        /// </summary>
        /// <param name="Id">The Learning Module id.</param>
        /// <param name="Assignment">The Assignment Preview.</param>
        public LearningModulePreviewUpdateResponse(string Id = null, LearningModulePreviewUpdateResponseAssignment Assignment = null)
        {
            this.Id = Id;
            this.Assignment = Assignment;
            
        }
        


        /// <summary>
        /// The Learning Module id
        /// </summary>
        /// <value>The Learning Module id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The Assignment Preview
        /// </summary>
        /// <value>The Assignment Preview</value>
        [DataMember(Name="assignment", EmitDefaultValue=false)]
        public LearningModulePreviewUpdateResponseAssignment Assignment { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModulePreviewUpdateResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Assignment: ").Append(Assignment).Append("\n");
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
            return this.Equals(obj as LearningModulePreviewUpdateResponse);
        }

        /// <summary>
        /// Returns true if LearningModulePreviewUpdateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModulePreviewUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModulePreviewUpdateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Assignment == other.Assignment ||
                    this.Assignment != null &&
                    this.Assignment.Equals(other.Assignment)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Assignment != null)
                    hash = hash * 59 + this.Assignment.GetHashCode();

                return hash;
            }
        }
    }

}
