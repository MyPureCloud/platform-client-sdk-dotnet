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
    /// PostTextResponse
    /// </summary>
    [DataContract]
    public partial class PostTextResponse :  IEquatable<PostTextResponse>
    {
        
        
        /// <summary>
        /// The state of the bot after completion of the request
        /// </summary>
        /// <value>The state of the bot after completion of the request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BotStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Moredata for "MoreData"
            /// </summary>
            [EnumMember(Value = "MoreData")]
            Moredata
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The state of the bot after completion of the request
        /// </summary>
        /// <value>The state of the bot after completion of the request</value>
        [DataMember(Name="botState", EmitDefaultValue=false)]
        public BotStateEnum? BotState { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTextResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostTextResponse() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTextResponse" /> class.
        /// </summary>
        /// <param name="BotState">The state of the bot after completion of the request (required).</param>
        /// <param name="ReplyMessages">The list of messages to respond with, if any.</param>
        /// <param name="IntentName">The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected..</param>
        /// <param name="Slots">Data parameters detected and filled by the bot..</param>
        /// <param name="BotCorrelationId">The optional ID specified in the request.</param>
        /// <param name="AmazonLex">Raw data response from AWS (if called).</param>
        /// <param name="GoogleDialogFlow">Raw data response from Google Dialogflow (if called).</param>
        /// <param name="GenesysDialogEngine">Raw data response from Genesys&#39; Dialogengine (if called).</param>
        /// <param name="GenesysBotConnector">Raw data response from Genesys&#39; BotConnector (if called).</param>
        /// <param name="NuanceMixDlg">Raw data response from Nuance Mix Dlg (if called).</param>
        public PostTextResponse(BotStateEnum? BotState = null, List<PostTextMessage> ReplyMessages = null, string IntentName = null, Dictionary<string, string> Slots = null, string BotCorrelationId = null, Dictionary<string, Object> AmazonLex = null, Dictionary<string, Object> GoogleDialogFlow = null, Dictionary<string, Object> GenesysDialogEngine = null, Dictionary<string, Object> GenesysBotConnector = null, Dictionary<string, Object> NuanceMixDlg = null)
        {
            this.BotState = BotState;
            this.ReplyMessages = ReplyMessages;
            this.IntentName = IntentName;
            this.Slots = Slots;
            this.BotCorrelationId = BotCorrelationId;
            this.AmazonLex = AmazonLex;
            this.GoogleDialogFlow = GoogleDialogFlow;
            this.GenesysDialogEngine = GenesysDialogEngine;
            this.GenesysBotConnector = GenesysBotConnector;
            this.NuanceMixDlg = NuanceMixDlg;
            
        }
        
        
        
        
        
        /// <summary>
        /// The list of messages to respond with, if any
        /// </summary>
        /// <value>The list of messages to respond with, if any</value>
        [DataMember(Name="replyMessages", EmitDefaultValue=false)]
        public List<PostTextMessage> ReplyMessages { get; set; }
        
        
        
        /// <summary>
        /// The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected.
        /// </summary>
        /// <value>The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected.</value>
        [DataMember(Name="intentName", EmitDefaultValue=false)]
        public string IntentName { get; set; }
        
        
        
        /// <summary>
        /// Data parameters detected and filled by the bot.
        /// </summary>
        /// <value>Data parameters detected and filled by the bot.</value>
        [DataMember(Name="slots", EmitDefaultValue=false)]
        public Dictionary<string, string> Slots { get; set; }
        
        
        
        /// <summary>
        /// The optional ID specified in the request
        /// </summary>
        /// <value>The optional ID specified in the request</value>
        [DataMember(Name="botCorrelationId", EmitDefaultValue=false)]
        public string BotCorrelationId { get; set; }
        
        
        
        /// <summary>
        /// Raw data response from AWS (if called)
        /// </summary>
        /// <value>Raw data response from AWS (if called)</value>
        [DataMember(Name="amazonLex", EmitDefaultValue=false)]
        public Dictionary<string, Object> AmazonLex { get; set; }
        
        
        
        /// <summary>
        /// Raw data response from Google Dialogflow (if called)
        /// </summary>
        /// <value>Raw data response from Google Dialogflow (if called)</value>
        [DataMember(Name="googleDialogFlow", EmitDefaultValue=false)]
        public Dictionary<string, Object> GoogleDialogFlow { get; set; }
        
        
        
        /// <summary>
        /// Raw data response from Genesys&#39; Dialogengine (if called)
        /// </summary>
        /// <value>Raw data response from Genesys&#39; Dialogengine (if called)</value>
        [DataMember(Name="genesysDialogEngine", EmitDefaultValue=false)]
        public Dictionary<string, Object> GenesysDialogEngine { get; set; }
        
        
        
        /// <summary>
        /// Raw data response from Genesys&#39; BotConnector (if called)
        /// </summary>
        /// <value>Raw data response from Genesys&#39; BotConnector (if called)</value>
        [DataMember(Name="genesysBotConnector", EmitDefaultValue=false)]
        public Dictionary<string, Object> GenesysBotConnector { get; set; }
        
        
        
        /// <summary>
        /// Raw data response from Nuance Mix Dlg (if called)
        /// </summary>
        /// <value>Raw data response from Nuance Mix Dlg (if called)</value>
        [DataMember(Name="nuanceMixDlg", EmitDefaultValue=false)]
        public Dictionary<string, Object> NuanceMixDlg { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostTextResponse {\n");
            
            sb.Append("  BotState: ").Append(BotState).Append("\n");
            sb.Append("  ReplyMessages: ").Append(ReplyMessages).Append("\n");
            sb.Append("  IntentName: ").Append(IntentName).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
            sb.Append("  BotCorrelationId: ").Append(BotCorrelationId).Append("\n");
            sb.Append("  AmazonLex: ").Append(AmazonLex).Append("\n");
            sb.Append("  GoogleDialogFlow: ").Append(GoogleDialogFlow).Append("\n");
            sb.Append("  GenesysDialogEngine: ").Append(GenesysDialogEngine).Append("\n");
            sb.Append("  GenesysBotConnector: ").Append(GenesysBotConnector).Append("\n");
            sb.Append("  NuanceMixDlg: ").Append(NuanceMixDlg).Append("\n");
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
            return this.Equals(obj as PostTextResponse);
        }

        /// <summary>
        /// Returns true if PostTextResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PostTextResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostTextResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BotState == other.BotState ||
                    this.BotState != null &&
                    this.BotState.Equals(other.BotState)
                ) &&
                (
                    this.ReplyMessages == other.ReplyMessages ||
                    this.ReplyMessages != null &&
                    this.ReplyMessages.SequenceEqual(other.ReplyMessages)
                ) &&
                (
                    this.IntentName == other.IntentName ||
                    this.IntentName != null &&
                    this.IntentName.Equals(other.IntentName)
                ) &&
                (
                    this.Slots == other.Slots ||
                    this.Slots != null &&
                    this.Slots.SequenceEqual(other.Slots)
                ) &&
                (
                    this.BotCorrelationId == other.BotCorrelationId ||
                    this.BotCorrelationId != null &&
                    this.BotCorrelationId.Equals(other.BotCorrelationId)
                ) &&
                (
                    this.AmazonLex == other.AmazonLex ||
                    this.AmazonLex != null &&
                    this.AmazonLex.SequenceEqual(other.AmazonLex)
                ) &&
                (
                    this.GoogleDialogFlow == other.GoogleDialogFlow ||
                    this.GoogleDialogFlow != null &&
                    this.GoogleDialogFlow.SequenceEqual(other.GoogleDialogFlow)
                ) &&
                (
                    this.GenesysDialogEngine == other.GenesysDialogEngine ||
                    this.GenesysDialogEngine != null &&
                    this.GenesysDialogEngine.SequenceEqual(other.GenesysDialogEngine)
                ) &&
                (
                    this.GenesysBotConnector == other.GenesysBotConnector ||
                    this.GenesysBotConnector != null &&
                    this.GenesysBotConnector.SequenceEqual(other.GenesysBotConnector)
                ) &&
                (
                    this.NuanceMixDlg == other.NuanceMixDlg ||
                    this.NuanceMixDlg != null &&
                    this.NuanceMixDlg.SequenceEqual(other.NuanceMixDlg)
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
                
                if (this.BotState != null)
                    hash = hash * 59 + this.BotState.GetHashCode();
                
                if (this.ReplyMessages != null)
                    hash = hash * 59 + this.ReplyMessages.GetHashCode();
                
                if (this.IntentName != null)
                    hash = hash * 59 + this.IntentName.GetHashCode();
                
                if (this.Slots != null)
                    hash = hash * 59 + this.Slots.GetHashCode();
                
                if (this.BotCorrelationId != null)
                    hash = hash * 59 + this.BotCorrelationId.GetHashCode();
                
                if (this.AmazonLex != null)
                    hash = hash * 59 + this.AmazonLex.GetHashCode();
                
                if (this.GoogleDialogFlow != null)
                    hash = hash * 59 + this.GoogleDialogFlow.GetHashCode();
                
                if (this.GenesysDialogEngine != null)
                    hash = hash * 59 + this.GenesysDialogEngine.GetHashCode();
                
                if (this.GenesysBotConnector != null)
                    hash = hash * 59 + this.GenesysBotConnector.GetHashCode();
                
                if (this.NuanceMixDlg != null)
                    hash = hash * 59 + this.NuanceMixDlg.GetHashCode();
                
                return hash;
            }
        }
    }

}
