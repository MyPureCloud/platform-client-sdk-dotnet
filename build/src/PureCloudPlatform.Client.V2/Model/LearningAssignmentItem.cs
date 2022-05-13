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
    /// LearningAssignmentItem
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentItem :  IEquatable<LearningAssignmentItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningAssignmentItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentItem" /> class.
        /// </summary>
        /// <param name="ModuleId">The Learning Module ID associated with this assignment (required).</param>
        /// <param name="UserId">The User ID associated with this assignment (required).</param>
        public LearningAssignmentItem(string ModuleId = null, string UserId = null)
        {
            this.ModuleId = ModuleId;
            this.UserId = UserId;
            
        }
        


        /// <summary>
        /// The Learning Module ID associated with this assignment
        /// </summary>
        /// <value>The Learning Module ID associated with this assignment</value>
        [DataMember(Name="moduleId", EmitDefaultValue=false)]
        public string ModuleId { get; set; }



        /// <summary>
        /// The User ID associated with this assignment
        /// </summary>
        /// <value>The User ID associated with this assignment</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentItem {\n");

            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as LearningAssignmentItem);
        }

        /// <summary>
        /// Returns true if LearningAssignmentItem instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ModuleId == other.ModuleId ||
                    this.ModuleId != null &&
                    this.ModuleId.Equals(other.ModuleId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.ModuleId != null)
                    hash = hash * 59 + this.ModuleId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                return hash;
            }
        }
    }

}
