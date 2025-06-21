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
    /// GeneratedGuideContent
    /// </summary>
    [DataContract]
    public partial class GeneratedGuideContent :  IEquatable<GeneratedGuideContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedGuideContent" /> class.
        /// </summary>
        public GeneratedGuideContent()
        {
            
        }
        


        /// <summary>
        /// The generated instruction content, which can be used when creating a guide version.
        /// </summary>
        /// <value>The generated instruction content, which can be used when creating a guide version.</value>
        [DataMember(Name="instruction", EmitDefaultValue=false)]
        public string Instruction { get; private set; }



        /// <summary>
        /// The generated variables content, which can be used when creating a guide version.
        /// </summary>
        /// <value>The generated variables content, which can be used when creating a guide version.</value>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<Variable> Variables { get; private set; }



        /// <summary>
        /// The generated resources content, which can be used when creating a guide version.
        /// </summary>
        /// <value>The generated resources content, which can be used when creating a guide version.</value>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public GuideVersionResources Resources { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneratedGuideContent {\n");

            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(obj as GeneratedGuideContent);
        }

        /// <summary>
        /// Returns true if GeneratedGuideContent instances are equal
        /// </summary>
        /// <param name="other">Instance of GeneratedGuideContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneratedGuideContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Instruction == other.Instruction ||
                    this.Instruction != null &&
                    this.Instruction.Equals(other.Instruction)
                ) &&
                (
                    this.Variables == other.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(other.Variables)
                ) &&
                (
                    this.Resources == other.Resources ||
                    this.Resources != null &&
                    this.Resources.Equals(other.Resources)
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
                if (this.Instruction != null)
                    hash = hash * 59 + this.Instruction.GetHashCode();

                if (this.Variables != null)
                    hash = hash * 59 + this.Variables.GetHashCode();

                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();

                return hash;
            }
        }
    }

}
