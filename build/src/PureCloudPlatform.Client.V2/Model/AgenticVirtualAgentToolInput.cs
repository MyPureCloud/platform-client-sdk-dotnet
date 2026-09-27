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
    /// Input for a tool.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentToolInput :  IEquatable<AgenticVirtualAgentToolInput>
    {
        /// <summary>
        /// Source of the input value.
        /// </summary>
        /// <value>Source of the input value.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Toolinput for "ToolInput"
            /// </summary>
            [EnumMember(Value = "ToolInput")]
            Toolinput,
            
            /// <summary>
            /// Enum Tooloutput for "ToolOutput"
            /// </summary>
            [EnumMember(Value = "ToolOutput")]
            Tooloutput,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External
        }
        /// <summary>
        /// Source of the input value.
        /// </summary>
        /// <value>Source of the input value.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentToolInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentToolInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentToolInput" /> class.
        /// </summary>
        /// <param name="TargetName">The unique name that identifies this input parameter within the tool (required).</param>
        /// <param name="Type">Input type name. The valid referenced type depends on the input source. (required).</param>
        /// <param name="Source">Source of the input value. (required).</param>
        /// <param name="Required">Whether this input must be supplied..</param>
        /// <param name="FallbackToUser">Whether the virtual agent should ask the user for this input value when it is not available from the configured source..</param>
        /// <param name="Mapping">Path used to extract this input from a previous tool output. Only valid when source is &#39;ToolOutput&#39;. The path starts with a tool output type name, may contain only string property names or integer array indexes, and must resolve to a primitive value..</param>
        public AgenticVirtualAgentToolInput(string TargetName = null, string Type = null, SourceEnum? Source = null, bool? Required = null, bool? FallbackToUser = null, List<Object> Mapping = null)
        {
            this.TargetName = TargetName;
            this.Type = Type;
            this.Source = Source;
            this.Required = Required;
            this.FallbackToUser = FallbackToUser;
            this.Mapping = Mapping;
            
        }
        


        /// <summary>
        /// The unique name that identifies this input parameter within the tool
        /// </summary>
        /// <value>The unique name that identifies this input parameter within the tool</value>
        [DataMember(Name="targetName", EmitDefaultValue=false)]
        public string TargetName { get; set; }



        /// <summary>
        /// Input type name. The valid referenced type depends on the input source.
        /// </summary>
        /// <value>Input type name. The valid referenced type depends on the input source.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }





        /// <summary>
        /// Whether this input must be supplied.
        /// </summary>
        /// <value>Whether this input must be supplied.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }



        /// <summary>
        /// Whether the virtual agent should ask the user for this input value when it is not available from the configured source.
        /// </summary>
        /// <value>Whether the virtual agent should ask the user for this input value when it is not available from the configured source.</value>
        [DataMember(Name="fallbackToUser", EmitDefaultValue=false)]
        public bool? FallbackToUser { get; set; }



        /// <summary>
        /// Path used to extract this input from a previous tool output. Only valid when source is &#39;ToolOutput&#39;. The path starts with a tool output type name, may contain only string property names or integer array indexes, and must resolve to a primitive value.
        /// </summary>
        /// <value>Path used to extract this input from a previous tool output. Only valid when source is &#39;ToolOutput&#39;. The path starts with a tool output type name, may contain only string property names or integer array indexes, and must resolve to a primitive value.</value>
        [DataMember(Name="mapping", EmitDefaultValue=false)]
        public List<Object> Mapping { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentToolInput {\n");

            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  FallbackToUser: ").Append(FallbackToUser).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentToolInput);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentToolInput instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentToolInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentToolInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TargetName == other.TargetName ||
                    this.TargetName != null &&
                    this.TargetName.Equals(other.TargetName)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) &&
                (
                    this.FallbackToUser == other.FallbackToUser ||
                    this.FallbackToUser != null &&
                    this.FallbackToUser.Equals(other.FallbackToUser)
                ) &&
                (
                    this.Mapping == other.Mapping ||
                    this.Mapping != null &&
                    this.Mapping.SequenceEqual(other.Mapping)
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
                if (this.TargetName != null)
                    hash = hash * 59 + this.TargetName.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();

                if (this.FallbackToUser != null)
                    hash = hash * 59 + this.FallbackToUser.GetHashCode();

                if (this.Mapping != null)
                    hash = hash * 59 + this.Mapping.GetHashCode();

                return hash;
            }
        }
    }

}
