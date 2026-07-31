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
    /// Type definition used by a virtual agent. The applicable fields depend on the type value and related fields.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentTypeDefinition :  IEquatable<AgenticVirtualAgentTypeDefinition>
    {
        /// <summary>
        /// Intended direction of use for this type.
        /// </summary>
        /// <value>Intended direction of use for this type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Input for "Input"
            /// </summary>
            [EnumMember(Value = "Input")]
            Input,
            
            /// <summary>
            /// Enum Output for "Output"
            /// </summary>
            [EnumMember(Value = "Output")]
            Output,
            
            /// <summary>
            /// Enum Agentinput for "AgentInput"
            /// </summary>
            [EnumMember(Value = "AgentInput")]
            Agentinput,
            
            /// <summary>
            /// Enum Agentoutput for "AgentOutput"
            /// </summary>
            [EnumMember(Value = "AgentOutput")]
            Agentoutput
        }
        /// <summary>
        /// Type value. The applicable fields depend on this value and related fields.
        /// </summary>
        /// <value>Type value. The applicable fields depend on this value and related fields.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum String for "string"
            /// </summary>
            [EnumMember(Value = "string")]
            String,
            
            /// <summary>
            /// Enum Integer for "integer"
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer,
            
            /// <summary>
            /// Enum Number for "number"
            /// </summary>
            [EnumMember(Value = "number")]
            Number,
            
            /// <summary>
            /// Enum Boolean for "boolean"
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean,
            
            /// <summary>
            /// Enum Null for "null"
            /// </summary>
            [EnumMember(Value = "null")]
            Null,
            
            /// <summary>
            /// Enum Object for "object"
            /// </summary>
            [EnumMember(Value = "object")]
            Object,
            
            /// <summary>
            /// Enum Array for "array"
            /// </summary>
            [EnumMember(Value = "array")]
            Array,
            
            /// <summary>
            /// Enum Dataactionhttperror for "DataActionHttpError"
            /// </summary>
            [EnumMember(Value = "DataActionHttpError")]
            Dataactionhttperror
        }
        /// <summary>
        /// Intended direction of use for this type.
        /// </summary>
        /// <value>Intended direction of use for this type.</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Type value. The applicable fields depend on this value and related fields.
        /// </summary>
        /// <value>Type value. The applicable fields depend on this value and related fields.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentTypeDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgenticVirtualAgentTypeDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentTypeDefinition" /> class.
        /// </summary>
        /// <param name="Name">Type name. (required).</param>
        /// <param name="Description">Additional context that helps the virtual agent understand what this type is used for..</param>
        /// <param name="Direction">Intended direction of use for this type..</param>
        /// <param name="Type">Type value. The applicable fields depend on this value and related fields..</param>
        /// <param name="UserUtteranceSubstring">Whether values of this string type must be copied as a contiguous substring from recent user messages..</param>
        /// <param name="Undisclosed">Whether values of this string type are hidden from the virtual agent and represented as opaque identifiers. Only valid when type is string..</param>
        /// <param name="Properties">Properties of this object type. Applies when type is object..</param>
        /// <param name="Items">Type of items in this array type. Applies when type is array..</param>
        /// <param name="StatusCodes">HTTP 4xx or 5xx status codes this error type can handle. Applies when type is DataActionHttpError..</param>
        /// <param name="DefaultInstruction">Default instruction for how the virtual agent should handle this error type when a tool references it without its own error instruction. Applies when type is DataActionHttpError..</param>
        /// <param name="Enum">Allowed enum values. Applies to enum types..</param>
        public AgenticVirtualAgentTypeDefinition(string Name = null, string Description = null, DirectionEnum? Direction = null, TypeEnum? Type = null, bool? UserUtteranceSubstring = null, bool? Undisclosed = null, List<AgenticVirtualAgentPropertyDefinition> Properties = null, string Items = null, List<int?> StatusCodes = null, string DefaultInstruction = null, List<string> Enum = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Direction = Direction;
            this.Type = Type;
            this.UserUtteranceSubstring = UserUtteranceSubstring;
            this.Undisclosed = Undisclosed;
            this.Properties = Properties;
            this.Items = Items;
            this.StatusCodes = StatusCodes;
            this.DefaultInstruction = DefaultInstruction;
            this.Enum = Enum;
            
        }
        


        /// <summary>
        /// Type name.
        /// </summary>
        /// <value>Type name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Additional context that helps the virtual agent understand what this type is used for.
        /// </summary>
        /// <value>Additional context that helps the virtual agent understand what this type is used for.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }







        /// <summary>
        /// Whether values of this string type must be copied as a contiguous substring from recent user messages.
        /// </summary>
        /// <value>Whether values of this string type must be copied as a contiguous substring from recent user messages.</value>
        [DataMember(Name="userUtteranceSubstring", EmitDefaultValue=false)]
        public bool? UserUtteranceSubstring { get; set; }



        /// <summary>
        /// Whether values of this string type are hidden from the virtual agent and represented as opaque identifiers. Only valid when type is string.
        /// </summary>
        /// <value>Whether values of this string type are hidden from the virtual agent and represented as opaque identifiers. Only valid when type is string.</value>
        [DataMember(Name="undisclosed", EmitDefaultValue=false)]
        public bool? Undisclosed { get; set; }



        /// <summary>
        /// Properties of this object type. Applies when type is object.
        /// </summary>
        /// <value>Properties of this object type. Applies when type is object.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<AgenticVirtualAgentPropertyDefinition> Properties { get; set; }



        /// <summary>
        /// Type of items in this array type. Applies when type is array.
        /// </summary>
        /// <value>Type of items in this array type. Applies when type is array.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public string Items { get; set; }



        /// <summary>
        /// HTTP 4xx or 5xx status codes this error type can handle. Applies when type is DataActionHttpError.
        /// </summary>
        /// <value>HTTP 4xx or 5xx status codes this error type can handle. Applies when type is DataActionHttpError.</value>
        [DataMember(Name="statusCodes", EmitDefaultValue=false)]
        public List<int?> StatusCodes { get; set; }



        /// <summary>
        /// Default instruction for how the virtual agent should handle this error type when a tool references it without its own error instruction. Applies when type is DataActionHttpError.
        /// </summary>
        /// <value>Default instruction for how the virtual agent should handle this error type when a tool references it without its own error instruction. Applies when type is DataActionHttpError.</value>
        [DataMember(Name="defaultInstruction", EmitDefaultValue=false)]
        public string DefaultInstruction { get; set; }



        /// <summary>
        /// Allowed enum values. Applies to enum types.
        /// </summary>
        /// <value>Allowed enum values. Applies to enum types.</value>
        [DataMember(Name="enum", EmitDefaultValue=false)]
        public List<string> Enum { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentTypeDefinition {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserUtteranceSubstring: ").Append(UserUtteranceSubstring).Append("\n");
            sb.Append("  Undisclosed: ").Append(Undisclosed).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  StatusCodes: ").Append(StatusCodes).Append("\n");
            sb.Append("  DefaultInstruction: ").Append(DefaultInstruction).Append("\n");
            sb.Append("  Enum: ").Append(Enum).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentTypeDefinition);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentTypeDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentTypeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentTypeDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.UserUtteranceSubstring == other.UserUtteranceSubstring ||
                    this.UserUtteranceSubstring != null &&
                    this.UserUtteranceSubstring.Equals(other.UserUtteranceSubstring)
                ) &&
                (
                    this.Undisclosed == other.Undisclosed ||
                    this.Undisclosed != null &&
                    this.Undisclosed.Equals(other.Undisclosed)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) &&
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.Equals(other.Items)
                ) &&
                (
                    this.StatusCodes == other.StatusCodes ||
                    this.StatusCodes != null &&
                    this.StatusCodes.SequenceEqual(other.StatusCodes)
                ) &&
                (
                    this.DefaultInstruction == other.DefaultInstruction ||
                    this.DefaultInstruction != null &&
                    this.DefaultInstruction.Equals(other.DefaultInstruction)
                ) &&
                (
                    this.Enum == other.Enum ||
                    this.Enum != null &&
                    this.Enum.SequenceEqual(other.Enum)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.UserUtteranceSubstring != null)
                    hash = hash * 59 + this.UserUtteranceSubstring.GetHashCode();

                if (this.Undisclosed != null)
                    hash = hash * 59 + this.Undisclosed.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();

                if (this.StatusCodes != null)
                    hash = hash * 59 + this.StatusCodes.GetHashCode();

                if (this.DefaultInstruction != null)
                    hash = hash * 59 + this.DefaultInstruction.GetHashCode();

                if (this.Enum != null)
                    hash = hash * 59 + this.Enum.GetHashCode();

                return hash;
            }
        }
    }

}
