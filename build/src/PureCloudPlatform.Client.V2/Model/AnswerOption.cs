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
    /// AnswerOption
    /// </summary>
    [DataContract]
    public partial class AnswerOption :  IEquatable<AnswerOption>
    {
        /// <summary>
        /// The built-in type of this answer option. Only used for built-in answer options such as selection states for Multiple Select answer options. Possible values include: Selected, Unselected
        /// </summary>
        /// <value>The built-in type of this answer option. Only used for built-in answer options such as selection states for Multiple Select answer options. Possible values include: Selected, Unselected</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BuiltInTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Selected for "Selected"
            /// </summary>
            [EnumMember(Value = "Selected")]
            Selected,
            
            /// <summary>
            /// Enum Unselected for "Unselected"
            /// </summary>
            [EnumMember(Value = "Unselected")]
            Unselected
        }
        /// <summary>
        /// The built-in type of this answer option. Only used for built-in answer options such as selection states for Multiple Select answer options. Possible values include: Selected, Unselected
        /// </summary>
        /// <value>The built-in type of this answer option. Only used for built-in answer options such as selection states for Multiple Select answer options. Possible values include: Selected, Unselected</value>
        [DataMember(Name="builtInType", EmitDefaultValue=false)]
        public BuiltInTypeEnum? BuiltInType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerOption" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="BuiltInType">The built-in type of this answer option. Only used for built-in answer options such as selection states for Multiple Select answer options. Possible values include: Selected, Unselected.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Value">Value.</param>
        /// <param name="AssistanceConditions">List of assistance conditions which are combined together with a logical AND operator. Eg ( assistanceCondtion1 &amp;&amp; assistanceCondition2 ) wherein assistanceCondition could be ( EXISTS topic1 || topic2 || ... ) or (NOTEXISTS topic3 || topic4 || ...)..</param>
        public AnswerOption(string Id = null, BuiltInTypeEnum? BuiltInType = null, string Text = null, int? Value = null, List<AssistanceCondition> AssistanceConditions = null)
        {
            this.Id = Id;
            this.BuiltInType = BuiltInType;
            this.Text = Text;
            this.Value = Value;
            this.AssistanceConditions = AssistanceConditions;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }



        /// <summary>
        /// List of assistance conditions which are combined together with a logical AND operator. Eg ( assistanceCondtion1 &amp;&amp; assistanceCondition2 ) wherein assistanceCondition could be ( EXISTS topic1 || topic2 || ... ) or (NOTEXISTS topic3 || topic4 || ...).
        /// </summary>
        /// <value>List of assistance conditions which are combined together with a logical AND operator. Eg ( assistanceCondtion1 &amp;&amp; assistanceCondition2 ) wherein assistanceCondition could be ( EXISTS topic1 || topic2 || ... ) or (NOTEXISTS topic3 || topic4 || ...).</value>
        [DataMember(Name="assistanceConditions", EmitDefaultValue=false)]
        public List<AssistanceCondition> AssistanceConditions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnswerOption {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BuiltInType: ").Append(BuiltInType).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  AssistanceConditions: ").Append(AssistanceConditions).Append("\n");
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
            return this.Equals(obj as AnswerOption);
        }

        /// <summary>
        /// Returns true if AnswerOption instances are equal
        /// </summary>
        /// <param name="other">Instance of AnswerOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnswerOption other)
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
                    this.BuiltInType == other.BuiltInType ||
                    this.BuiltInType != null &&
                    this.BuiltInType.Equals(other.BuiltInType)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.AssistanceConditions == other.AssistanceConditions ||
                    this.AssistanceConditions != null &&
                    this.AssistanceConditions.SequenceEqual(other.AssistanceConditions)
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

                if (this.BuiltInType != null)
                    hash = hash * 59 + this.BuiltInType.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.AssistanceConditions != null)
                    hash = hash * 59 + this.AssistanceConditions.GetHashCode();

                return hash;
            }
        }
    }

}
