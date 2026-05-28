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
    /// Result of skill expression validation
    /// </summary>
    [DataContract]
    public partial class SkillExpressionValidationResult :  IEquatable<SkillExpressionValidationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillExpressionValidationResult" /> class.
        /// </summary>
        /// <param name="Valid">Whether the expression is valid.</param>
        /// <param name="Expression">Normalized SpEL expression (null if validation failed).</param>
        /// <param name="Skills">List of skill references extracted from the expression (empty if no skills found and/or invalid expression).</param>
        /// <param name="Errors">List of validation errors (empty if valid).</param>
        /// <param name="Hint">Optional hint message (e.g., if expression is non-optimal or system is near capacity).</param>
        public SkillExpressionValidationResult(bool? Valid = null, string Expression = null, List<SkillReference> Skills = null, List<SkillExpressionValidationError> Errors = null, string Hint = null)
        {
            this.Valid = Valid;
            this.Expression = Expression;
            this.Skills = Skills;
            this.Errors = Errors;
            this.Hint = Hint;
            
        }
        


        /// <summary>
        /// Whether the expression is valid
        /// </summary>
        /// <value>Whether the expression is valid</value>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool? Valid { get; set; }



        /// <summary>
        /// Normalized SpEL expression (null if validation failed)
        /// </summary>
        /// <value>Normalized SpEL expression (null if validation failed)</value>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public string Expression { get; set; }



        /// <summary>
        /// List of skill references extracted from the expression (empty if no skills found and/or invalid expression)
        /// </summary>
        /// <value>List of skill references extracted from the expression (empty if no skills found and/or invalid expression)</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<SkillReference> Skills { get; set; }



        /// <summary>
        /// List of validation errors (empty if valid)
        /// </summary>
        /// <value>List of validation errors (empty if valid)</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<SkillExpressionValidationError> Errors { get; set; }



        /// <summary>
        /// Optional hint message (e.g., if expression is non-optimal or system is near capacity)
        /// </summary>
        /// <value>Optional hint message (e.g., if expression is non-optimal or system is near capacity)</value>
        [DataMember(Name="hint", EmitDefaultValue=false)]
        public string Hint { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillExpressionValidationResult {\n");

            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Hint: ").Append(Hint).Append("\n");
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
            return this.Equals(obj as SkillExpressionValidationResult);
        }

        /// <summary>
        /// Returns true if SkillExpressionValidationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of SkillExpressionValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkillExpressionValidationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Valid == other.Valid ||
                    this.Valid != null &&
                    this.Valid.Equals(other.Valid)
                ) &&
                (
                    this.Expression == other.Expression ||
                    this.Expression != null &&
                    this.Expression.Equals(other.Expression)
                ) &&
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) &&
                (
                    this.Hint == other.Hint ||
                    this.Hint != null &&
                    this.Hint.Equals(other.Hint)
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
                if (this.Valid != null)
                    hash = hash * 59 + this.Valid.GetHashCode();

                if (this.Expression != null)
                    hash = hash * 59 + this.Expression.GetHashCode();

                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                if (this.Hint != null)
                    hash = hash * 59 + this.Hint.GetHashCode();

                return hash;
            }
        }
    }

}
