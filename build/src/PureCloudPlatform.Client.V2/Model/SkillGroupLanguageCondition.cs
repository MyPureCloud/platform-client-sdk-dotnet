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
    /// SkillGroupLanguageCondition
    /// </summary>
    [DataContract]
    public partial class SkillGroupLanguageCondition :  IEquatable<SkillGroupLanguageCondition>
    {
        /// <summary>
        /// Comparator that will be applied to the proficiency
        /// </summary>
        /// <value>Comparator that will be applied to the proficiency</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ComparatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Equalto for "EqualTo"
            /// </summary>
            [EnumMember(Value = "EqualTo")]
            Equalto,
            
            /// <summary>
            /// Enum Notequalto for "NotEqualTo"
            /// </summary>
            [EnumMember(Value = "NotEqualTo")]
            Notequalto,
            
            /// <summary>
            /// Enum Lessthan for "LessThan"
            /// </summary>
            [EnumMember(Value = "LessThan")]
            Lessthan,
            
            /// <summary>
            /// Enum Greaterthan for "GreaterThan"
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanorequalto for "GreaterThanOrEqualTo"
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqualTo")]
            Greaterthanorequalto,
            
            /// <summary>
            /// Enum Lessthanorequalto for "LessThanOrEqualTo"
            /// </summary>
            [EnumMember(Value = "LessThanOrEqualTo")]
            Lessthanorequalto
        }
        /// <summary>
        /// Comparator that will be applied to the proficiency
        /// </summary>
        /// <value>Comparator that will be applied to the proficiency</value>
        [DataMember(Name="comparator", EmitDefaultValue=false)]
        public ComparatorEnum? Comparator { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillGroupLanguageCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SkillGroupLanguageCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillGroupLanguageCondition" /> class.
        /// </summary>
        /// <param name="LanguageSkill">The language skill to be used in the skill condition query (required).</param>
        /// <param name="Comparator">Comparator that will be applied to the proficiency (required).</param>
        /// <param name="Proficiency">The skill proficiency that will be used for the language skill. Integer range 0-5 (required).</param>
        /// <param name="ChildConditions">Nested conditions to be applied to this skill condition.</param>
        public SkillGroupLanguageCondition(string LanguageSkill = null, ComparatorEnum? Comparator = null, int? Proficiency = null, List<SkillGroupCondition> ChildConditions = null)
        {
            this.LanguageSkill = LanguageSkill;
            this.Comparator = Comparator;
            this.Proficiency = Proficiency;
            this.ChildConditions = ChildConditions;
            
        }
        


        /// <summary>
        /// The language skill to be used in the skill condition query
        /// </summary>
        /// <value>The language skill to be used in the skill condition query</value>
        [DataMember(Name="languageSkill", EmitDefaultValue=false)]
        public string LanguageSkill { get; set; }





        /// <summary>
        /// The skill proficiency that will be used for the language skill. Integer range 0-5
        /// </summary>
        /// <value>The skill proficiency that will be used for the language skill. Integer range 0-5</value>
        [DataMember(Name="proficiency", EmitDefaultValue=false)]
        public int? Proficiency { get; set; }



        /// <summary>
        /// Nested conditions to be applied to this skill condition
        /// </summary>
        /// <value>Nested conditions to be applied to this skill condition</value>
        [DataMember(Name="childConditions", EmitDefaultValue=false)]
        public List<SkillGroupCondition> ChildConditions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillGroupLanguageCondition {\n");

            sb.Append("  LanguageSkill: ").Append(LanguageSkill).Append("\n");
            sb.Append("  Comparator: ").Append(Comparator).Append("\n");
            sb.Append("  Proficiency: ").Append(Proficiency).Append("\n");
            sb.Append("  ChildConditions: ").Append(ChildConditions).Append("\n");
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
            return this.Equals(obj as SkillGroupLanguageCondition);
        }

        /// <summary>
        /// Returns true if SkillGroupLanguageCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of SkillGroupLanguageCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkillGroupLanguageCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LanguageSkill == other.LanguageSkill ||
                    this.LanguageSkill != null &&
                    this.LanguageSkill.Equals(other.LanguageSkill)
                ) &&
                (
                    this.Comparator == other.Comparator ||
                    this.Comparator != null &&
                    this.Comparator.Equals(other.Comparator)
                ) &&
                (
                    this.Proficiency == other.Proficiency ||
                    this.Proficiency != null &&
                    this.Proficiency.Equals(other.Proficiency)
                ) &&
                (
                    this.ChildConditions == other.ChildConditions ||
                    this.ChildConditions != null &&
                    this.ChildConditions.SequenceEqual(other.ChildConditions)
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
                if (this.LanguageSkill != null)
                    hash = hash * 59 + this.LanguageSkill.GetHashCode();

                if (this.Comparator != null)
                    hash = hash * 59 + this.Comparator.GetHashCode();

                if (this.Proficiency != null)
                    hash = hash * 59 + this.Proficiency.GetHashCode();

                if (this.ChildConditions != null)
                    hash = hash * 59 + this.ChildConditions.GetHashCode();

                return hash;
            }
        }
    }

}
