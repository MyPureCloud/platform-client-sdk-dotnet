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
    /// CreateCallbackCommand
    /// </summary>
    [DataContract]
    public partial class CreateCallbackCommand :  IEquatable<CreateCallbackCommand>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallbackCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCallbackCommand() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallbackCommand" /> class.
        /// </summary>
        
        
        /// <param name="ScriptId">The identifier of the script to be used for the callback.</param>
        
        
        
        /// <param name="QueueId">The identifier of the queue to be used for the callback. Either queueId or routingData is required..</param>
        
        
        
        /// <param name="RoutingData">The routing data to be used for the callback. Either queueId or routingData is required..</param>
        
        
        
        /// <param name="CallbackUserName">The name of the party to be called back..</param>
        
        
        
        /// <param name="CallbackNumbers">A list of phone numbers for the callback. (required).</param>
        
        
        
        /// <param name="CallbackScheduledTime">The scheduled date-time for the callback as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="CountryCode">The country code to be associated with the callback numbers..</param>
        
        
        
        /// <param name="Data">A map of key-value pairs containing additional data that can be associated to the callback. These values will appear in the attributes property on the conversation participant. Example: { \&quot;notes\&quot;: \&quot;ready to close the deal!\&quot;, \&quot;customerPreferredName\&quot;: \&quot;Doc\&quot; }.</param>
        
        
        public CreateCallbackCommand(string ScriptId = null, string QueueId = null, RoutingData RoutingData = null, string CallbackUserName = null, List<string> CallbackNumbers = null, DateTime? CallbackScheduledTime = null, string CountryCode = null, Dictionary<string, string> Data = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // to ensure "CallbackNumbers" is required (not null)
            if (CallbackNumbers == null)
            {
                throw new InvalidDataException("CallbackNumbers is a required property for CreateCallbackCommand and cannot be null");
            }
            else
            {
                this.CallbackNumbers = CallbackNumbers;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.ScriptId = ScriptId;
            
            
            
            
            
            
            
            
this.QueueId = QueueId;
            
            
            
            
            
            
            
            
this.RoutingData = RoutingData;
            
            
            
            
            
            
            
            
this.CallbackUserName = CallbackUserName;
            
            
            
            
            
            
            
            
            
            
            
            
this.CallbackScheduledTime = CallbackScheduledTime;
            
            
            
            
            
            
            
            
this.CountryCode = CountryCode;
            
            
            
            
            
            
            
            
this.Data = Data;
            
            
            
            
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
        /// A map of key-value pairs containing additional data that can be associated to the callback. These values will appear in the attributes property on the conversation participant. Example: { \&quot;notes\&quot;: \&quot;ready to close the deal!\&quot;, \&quot;customerPreferredName\&quot;: \&quot;Doc\&quot; }
        /// </summary>
        /// <value>A map of key-value pairs containing additional data that can be associated to the callback. These values will appear in the attributes property on the conversation participant. Example: { \&quot;notes\&quot;: \&quot;ready to close the deal!\&quot;, \&quot;customerPreferredName\&quot;: \&quot;Doc\&quot; }</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, string> Data { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCallbackCommand {\n");
            
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            
            sb.Append("  RoutingData: ").Append(RoutingData).Append("\n");
            
            sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
            
            sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
            
            sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
            
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            
            sb.Append("  Data: ").Append(Data).Append("\n");
            
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
            return this.Equals(obj as CreateCallbackCommand);
        }

        /// <summary>
        /// Returns true if CreateCallbackCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCallbackCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCallbackCommand other)
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
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                return hash;
            }
        }
    }

}
