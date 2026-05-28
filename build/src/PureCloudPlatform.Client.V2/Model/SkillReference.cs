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
    /// A skill reference extracted from the expression
    /// </summary>
    [DataContract]
    public partial class SkillReference :  IEquatable<SkillReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillReference" /> class.
        /// </summary>
        /// <param name="Id">Skill UUID.</param>
        /// <param name="Name">Skill name.</param>
        /// <param name="IsLanguageSkill">Whether this is a language skill.</param>
        public SkillReference(string Id = null, string Name = null, bool? IsLanguageSkill = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.IsLanguageSkill = IsLanguageSkill;
            
        }
        


        /// <summary>
        /// Skill UUID
        /// </summary>
        /// <value>Skill UUID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Skill name
        /// </summary>
        /// <value>Skill name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Whether this is a language skill
        /// </summary>
        /// <value>Whether this is a language skill</value>
        [DataMember(Name="isLanguageSkill", EmitDefaultValue=false)]
        public bool? IsLanguageSkill { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsLanguageSkill: ").Append(IsLanguageSkill).Append("\n");
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
            return this.Equals(obj as SkillReference);
        }

        /// <summary>
        /// Returns true if SkillReference instances are equal
        /// </summary>
        /// <param name="other">Instance of SkillReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkillReference other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.IsLanguageSkill == other.IsLanguageSkill ||
                    this.IsLanguageSkill != null &&
                    this.IsLanguageSkill.Equals(other.IsLanguageSkill)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.IsLanguageSkill != null)
                    hash = hash * 59 + this.IsLanguageSkill.GetHashCode();

                return hash;
            }
        }
    }

}
