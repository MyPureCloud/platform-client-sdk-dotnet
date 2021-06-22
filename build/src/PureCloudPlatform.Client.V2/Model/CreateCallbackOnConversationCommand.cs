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
    /// CreateCallbackOnConversationCommand
    /// </summary>
    [DataContract]
    public partial class CreateCallbackOnConversationCommand :  IEquatable<CreateCallbackOnConversationCommand>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallbackOnConversationCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCallbackOnConversationCommand() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallbackOnConversationCommand" /> class.
        /// </summary>
        /// <param name="ScriptId">The identifier of the script to be used for the callback.</param>
        /// <param name="QueueId">The identifier of the queue to be used for the callback. Either queueId or routingData is required..</param>
        /// <param name="RoutingData">The routing data to be used for the callback. Either queueId or routingData is required..</param>
        /// <param name="CallbackUserName">The name of the party to be called back..</param>
        /// <param name="CallbackNumbers">A list of phone numbers for the callback. (required).</param>
        /// <param name="CallbackScheduledTime">The scheduled date-time for the callback as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="CountryCode">The country code to be associated with the callback numbers..</param>
        /// <param name="ValidateCallbackNumbers">Whether or not to validate the callback numbers for phone number format..</param>
        /// <param name="Data">A map of key-value pairs containing additional data that can be associated to the callback. These values will appear in the attributes property on the conversation participant. Example: { \&quot;notes\&quot;: \&quot;ready to close the deal!\&quot;, \&quot;customerPreferredName\&quot;: \&quot;Doc\&quot; }.</param>
        /// <param name="CallerId">The phone number displayed to recipients when a phone call is placed as part of the callback. Must conform to the E.164 format. May be overridden by other settings in the system such as external trunk settings. Telco support for \&quot;callerId\&quot; varies..</param>
        /// <param name="CallerIdName">The name displayed to recipients when a phone call is placed as part of the callback. May be overridden by other settings in the system such as external trunk settings. Telco support for \&quot;callerIdName\&quot; varies..</param>
        public CreateCallbackOnConversationCommand(string ScriptId = null, string QueueId = null, RoutingData RoutingData = null, string CallbackUserName = null, List<string> CallbackNumbers = null, DateTime? CallbackScheduledTime = null, string CountryCode = null, bool? ValidateCallbackNumbers = null, Dictionary<string, string> Data = null, string CallerId = null, string CallerIdName = null)
        {
            this.ScriptId = ScriptId;
            this.QueueId = QueueId;
            this.RoutingData = RoutingData;
            this.CallbackUserName = CallbackUserName;
            this.CallbackNumbers = CallbackNumbers;
            this.CallbackScheduledTime = CallbackScheduledTime;
            this.CountryCode = CountryCode;
            this.ValidateCallbackNumbers = ValidateCallbackNumbers;
            this.Data = Data;
            this.CallerId = CallerId;
            this.CallerIdName = CallerIdName;
            
        }
        
        
        
        /// <summary>
        /// The identifier of the script to be used for the callback
        /// </summary>
        /// <value>The identifier of the script to be used for the callback</value>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public string ScriptId { get; set; }
        
        
        
        /// <summary>
        /// The identifier of the queue to be used for the callback. Either queueId or routingData is required.
        /// </summary>
        /// <value>The identifier of the queue to be used for the callback. Either queueId or routingData is required.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// The routing data to be used for the callback. Either queueId or routingData is required.
        /// </summary>
        /// <value>The routing data to be used for the callback. Either queueId or routingData is required.</value>
        [DataMember(Name="routingData", EmitDefaultValue=false)]
        public RoutingData RoutingData { get; set; }
        
        
        
        /// <summary>
        /// The name of the party to be called back.
        /// </summary>
        /// <value>The name of the party to be called back.</value>
        [DataMember(Name="callbackUserName", EmitDefaultValue=false)]
        public string CallbackUserName { get; set; }
        
        
        
        /// <summary>
        /// A list of phone numbers for the callback.
        /// </summary>
        /// <value>A list of phone numbers for the callback.</value>
        [DataMember(Name="callbackNumbers", EmitDefaultValue=false)]
        public List<string> CallbackNumbers { get; set; }
        
        
        
        /// <summary>
        /// The scheduled date-time for the callback as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The scheduled date-time for the callback as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="callbackScheduledTime", EmitDefaultValue=false)]
        public DateTime? CallbackScheduledTime { get; set; }
        
        
        
        /// <summary>
        /// The country code to be associated with the callback numbers.
        /// </summary>
        /// <value>The country code to be associated with the callback numbers.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        
        
        
        /// <summary>
        /// Whether or not to validate the callback numbers for phone number format.
        /// </summary>
        /// <value>Whether or not to validate the callback numbers for phone number format.</value>
        [DataMember(Name="validateCallbackNumbers", EmitDefaultValue=false)]
        public bool? ValidateCallbackNumbers { get; set; }
        
        
        
        /// <summary>
        /// A map of key-value pairs containing additional data that can be associated to the callback. These values will appear in the attributes property on the conversation participant. Example: { \&quot;notes\&quot;: \&quot;ready to close the deal!\&quot;, \&quot;customerPreferredName\&quot;: \&quot;Doc\&quot; }
        /// </summary>
        /// <value>A map of key-value pairs containing additional data that can be associated to the callback. These values will appear in the attributes property on the conversation participant. Example: { \&quot;notes\&quot;: \&quot;ready to close the deal!\&quot;, \&quot;customerPreferredName\&quot;: \&quot;Doc\&quot; }</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, string> Data { get; set; }
        
        
        
        /// <summary>
        /// The phone number displayed to recipients when a phone call is placed as part of the callback. Must conform to the E.164 format. May be overridden by other settings in the system such as external trunk settings. Telco support for \&quot;callerId\&quot; varies.
        /// </summary>
        /// <value>The phone number displayed to recipients when a phone call is placed as part of the callback. Must conform to the E.164 format. May be overridden by other settings in the system such as external trunk settings. Telco support for \&quot;callerId\&quot; varies.</value>
        [DataMember(Name="callerId", EmitDefaultValue=false)]
        public string CallerId { get; set; }
        
        
        
        /// <summary>
        /// The name displayed to recipients when a phone call is placed as part of the callback. May be overridden by other settings in the system such as external trunk settings. Telco support for \&quot;callerIdName\&quot; varies.
        /// </summary>
        /// <value>The name displayed to recipients when a phone call is placed as part of the callback. May be overridden by other settings in the system such as external trunk settings. Telco support for \&quot;callerIdName\&quot; varies.</value>
        [DataMember(Name="callerIdName", EmitDefaultValue=false)]
        public string CallerIdName { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCallbackOnConversationCommand {\n");
            
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  RoutingData: ").Append(RoutingData).Append("\n");
            sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
            sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
            sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ValidateCallbackNumbers: ").Append(ValidateCallbackNumbers).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateCallbackOnConversationCommand);
        }

        /// <summary>
        /// Returns true if CreateCallbackOnConversationCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCallbackOnConversationCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCallbackOnConversationCommand other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScriptId == other.ScriptId ||
                    this.ScriptId != null &&
                    this.ScriptId.Equals(other.ScriptId)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.RoutingData == other.RoutingData ||
                    this.RoutingData != null &&
                    this.RoutingData.Equals(other.RoutingData)
                ) &&
                (
                    this.CallbackUserName == other.CallbackUserName ||
                    this.CallbackUserName != null &&
                    this.CallbackUserName.Equals(other.CallbackUserName)
                ) &&
                (
                    this.CallbackNumbers == other.CallbackNumbers ||
                    this.CallbackNumbers != null &&
                    this.CallbackNumbers.SequenceEqual(other.CallbackNumbers)
                ) &&
                (
                    this.CallbackScheduledTime == other.CallbackScheduledTime ||
                    this.CallbackScheduledTime != null &&
                    this.CallbackScheduledTime.Equals(other.CallbackScheduledTime)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.ValidateCallbackNumbers == other.ValidateCallbackNumbers ||
                    this.ValidateCallbackNumbers != null &&
                    this.ValidateCallbackNumbers.Equals(other.ValidateCallbackNumbers)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) &&
                (
                    this.CallerId == other.CallerId ||
                    this.CallerId != null &&
                    this.CallerId.Equals(other.CallerId)
                ) &&
                (
                    this.CallerIdName == other.CallerIdName ||
                    this.CallerIdName != null &&
                    this.CallerIdName.Equals(other.CallerIdName)
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
                
                if (this.ScriptId != null)
                    hash = hash * 59 + this.ScriptId.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.RoutingData != null)
                    hash = hash * 59 + this.RoutingData.GetHashCode();
                
                if (this.CallbackUserName != null)
                    hash = hash * 59 + this.CallbackUserName.GetHashCode();
                
                if (this.CallbackNumbers != null)
                    hash = hash * 59 + this.CallbackNumbers.GetHashCode();
                
                if (this.CallbackScheduledTime != null)
                    hash = hash * 59 + this.CallbackScheduledTime.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.ValidateCallbackNumbers != null)
                    hash = hash * 59 + this.ValidateCallbackNumbers.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                if (this.CallerId != null)
                    hash = hash * 59 + this.CallerId.GetHashCode();
                
                if (this.CallerIdName != null)
                    hash = hash * 59 + this.CallerIdName.GetHashCode();
                
                return hash;
            }
        }
    }

}
