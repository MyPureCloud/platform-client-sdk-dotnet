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
    /// GuideVersion
    /// </summary>
    [DataContract]
    public partial class GuideVersion :  IEquatable<GuideVersion>
    {
        /// <summary>
        /// The current state of the guide version.
        /// </summary>
        /// <value>The current state of the guide version.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Testready for "TestReady"
            /// </summary>
            [EnumMember(Value = "TestReady")]
            Testready,
            
            /// <summary>
            /// Enum Productionready for "ProductionReady"
            /// </summary>
            [EnumMember(Value = "ProductionReady")]
            Productionready
        }
        /// <summary>
        /// The current state of the guide version.
        /// </summary>
        /// <value>The current state of the guide version.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideVersion" /> class.
        /// </summary>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="State">The current state of the guide version..</param>
        /// <param name="Resources">The resources associated with this version of the guide..</param>
        /// <param name="KnowledgeSettings">The knowledge settings associated with this version of the guide..</param>
        public GuideVersion(string SelfUri = null, StateEnum? State = null, GuideVersionResources Resources = null, AuthoringKnowledgeSettings KnowledgeSettings = null)
        {
            this.SelfUri = SelfUri;
            this.State = State;
            this.Resources = Resources;
            this.KnowledgeSettings = KnowledgeSettings;
            
        }
        


        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }



        /// <summary>
        /// The guide this version belongs to.
        /// </summary>
        /// <value>The guide this version belongs to.</value>
        [DataMember(Name="guide", EmitDefaultValue=false)]
        public AddressableEntityRef Guide { get; private set; }



        /// <summary>
        /// Guide version.
        /// </summary>
        /// <value>Guide version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; private set; }



        /// <summary>
        /// The instruction given to this version of the guide, for how it should behave when interacting with a User.
        /// </summary>
        /// <value>The instruction given to this version of the guide, for how it should behave when interacting with a User.</value>
        [DataMember(Name="instruction", EmitDefaultValue=false)]
        public string Instruction { get; private set; }





        /// <summary>
        /// The date and time the guide version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time the guide version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The date and time the guide version was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time the guide version was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The variables associated with this version of the guide. Includes input variables (provided) and output variables (captured during execution).
        /// </summary>
        /// <value>The variables associated with this version of the guide. Includes input variables (provided) and output variables (captured during execution).</value>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<Variable> Variables { get; private set; }



        /// <summary>
        /// The resources associated with this version of the guide.
        /// </summary>
        /// <value>The resources associated with this version of the guide.</value>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public GuideVersionResources Resources { get; set; }



        /// <summary>
        /// The knowledge settings associated with this version of the guide.
        /// </summary>
        /// <value>The knowledge settings associated with this version of the guide.</value>
        [DataMember(Name="knowledgeSettings", EmitDefaultValue=false)]
        public AuthoringKnowledgeSettings KnowledgeSettings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideVersion {\n");

            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Guide: ").Append(Guide).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  KnowledgeSettings: ").Append(KnowledgeSettings).Append("\n");
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
            return this.Equals(obj as GuideVersion);
        }

        /// <summary>
        /// Returns true if GuideVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideVersion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Guide == other.Guide ||
                    this.Guide != null &&
                    this.Guide.Equals(other.Guide)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Instruction == other.Instruction ||
                    this.Instruction != null &&
                    this.Instruction.Equals(other.Instruction)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                ) &&
                (
                    this.KnowledgeSettings == other.KnowledgeSettings ||
                    this.KnowledgeSettings != null &&
                    this.KnowledgeSettings.Equals(other.KnowledgeSettings)
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
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.Guide != null)
                    hash = hash * 59 + this.Guide.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Instruction != null)
                    hash = hash * 59 + this.Instruction.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Variables != null)
                    hash = hash * 59 + this.Variables.GetHashCode();

                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();

                if (this.KnowledgeSettings != null)
                    hash = hash * 59 + this.KnowledgeSettings.GetHashCode();

                return hash;
            }
        }
    }

}
