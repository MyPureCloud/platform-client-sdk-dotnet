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
    /// GuideSessionInputEvent
    /// </summary>
    [DataContract]
    public partial class GuideSessionInputEvent :  IEquatable<GuideSessionInputEvent>
    {
        /// <summary>
        /// The type of input event.
        /// </summary>
        /// <value>The type of input event.</value>
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
            /// Enum Userinput for "UserInput"
            /// </summary>
            [EnumMember(Value = "UserInput")]
            Userinput,
            
            /// <summary>
            /// Enum Returncontrol for "ReturnControl"
            /// </summary>
            [EnumMember(Value = "ReturnControl")]
            Returncontrol,
            
            /// <summary>
            /// Enum Noop for "NoOp"
            /// </summary>
            [EnumMember(Value = "NoOp")]
            Noop
        }
        /// <summary>
        /// The input mode for this event.
        /// </summary>
        /// <value>The input mode for this event.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text
        }
        /// <summary>
        /// The type of input event.
        /// </summary>
        /// <value>The type of input event.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The input mode for this event.
        /// </summary>
        /// <value>The input mode for this event.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionInputEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GuideSessionInputEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionInputEvent" /> class.
        /// </summary>
        /// <param name="Type">The type of input event. (required).</param>
        /// <param name="Text">The text content of the input event..</param>
        /// <param name="Mode">The input mode for this event. (required).</param>
        /// <param name="InvocationId">The invocation ID of the input event..</param>
        /// <param name="Invocations">The invocation data of the input event..</param>
        public GuideSessionInputEvent(TypeEnum? Type = null, string Text = null, ModeEnum? Mode = null, string InvocationId = null, List<GuideSessionTurnInvocationData> Invocations = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Mode = Mode;
            this.InvocationId = InvocationId;
            this.Invocations = Invocations;
            
        }
        




        /// <summary>
        /// The text content of the input event.
        /// </summary>
        /// <value>The text content of the input event.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }





        /// <summary>
        /// The invocation ID of the input event.
        /// </summary>
        /// <value>The invocation ID of the input event.</value>
        [DataMember(Name="invocationId", EmitDefaultValue=false)]
        public string InvocationId { get; set; }



        /// <summary>
        /// The invocation data of the input event.
        /// </summary>
        /// <value>The invocation data of the input event.</value>
        [DataMember(Name="invocations", EmitDefaultValue=false)]
        public List<GuideSessionTurnInvocationData> Invocations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideSessionInputEvent {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  InvocationId: ").Append(InvocationId).Append("\n");
            sb.Append("  Invocations: ").Append(Invocations).Append("\n");
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
            return this.Equals(obj as GuideSessionInputEvent);
        }

        /// <summary>
        /// Returns true if GuideSessionInputEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideSessionInputEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideSessionInputEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) &&
                (
                    this.InvocationId == other.InvocationId ||
                    this.InvocationId != null &&
                    this.InvocationId.Equals(other.InvocationId)
                ) &&
                (
                    this.Invocations == other.Invocations ||
                    this.Invocations != null &&
                    this.Invocations.SequenceEqual(other.Invocations)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();

                if (this.InvocationId != null)
                    hash = hash * 59 + this.InvocationId.GetHashCode();

                if (this.Invocations != null)
                    hash = hash * 59 + this.Invocations.GetHashCode();

                return hash;
            }
        }
    }

}
