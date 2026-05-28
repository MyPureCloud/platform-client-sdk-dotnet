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
    /// A validation error found in the expression
    /// </summary>
    [DataContract]
    public partial class SkillExpressionValidationError :  IEquatable<SkillExpressionValidationError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillExpressionValidationError" /> class.
        /// </summary>
        /// <param name="Code">Error code.</param>
        /// <param name="Message">Human-readable error message.</param>
        /// <param name="Position">Position in the expression where the error occurred (null if not applicable).</param>
        public SkillExpressionValidationError(string Code = null, string Message = null, int? Position = null)
        {
            this.Code = Code;
            this.Message = Message;
            this.Position = Position;
            
        }
        


        /// <summary>
        /// Error code
        /// </summary>
        /// <value>Error code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Human-readable error message
        /// </summary>
        /// <value>Human-readable error message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Position in the expression where the error occurred (null if not applicable)
        /// </summary>
        /// <value>Position in the expression where the error occurred (null if not applicable)</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillExpressionValidationError {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(obj as SkillExpressionValidationError);
        }

        /// <summary>
        /// Returns true if SkillExpressionValidationError instances are equal
        /// </summary>
        /// <param name="other">Instance of SkillExpressionValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkillExpressionValidationError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();

                return hash;
            }
        }
    }

}
