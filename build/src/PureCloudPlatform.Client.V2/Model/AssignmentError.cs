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
    /// AssignmentError
    /// </summary>
    [DataContract]
    public partial class AssignmentError :  IEquatable<AssignmentError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentError" /> class.
        /// </summary>
        /// <param name="User">A user that is failed to be removed from the performance profile.</param>
        /// <param name="Message">Error message from membership assignment.</param>
        public AssignmentError(UserReference User = null, string Message = null)
        {
            this.User = User;
            this.Message = Message;
            
        }
        


        /// <summary>
        /// A user that is failed to be removed from the performance profile
        /// </summary>
        /// <value>A user that is failed to be removed from the performance profile</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// Error message from membership assignment
        /// </summary>
        /// <value>Error message from membership assignment</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignmentError {\n");

            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as AssignmentError);
        }

        /// <summary>
        /// Returns true if AssignmentError instances are equal
        /// </summary>
        /// <param name="other">Instance of AssignmentError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssignmentError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                return hash;
            }
        }
    }

}
