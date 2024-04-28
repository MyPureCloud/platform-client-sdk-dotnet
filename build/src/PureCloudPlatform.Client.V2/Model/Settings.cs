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
    /// Settings
    /// </summary>
    [DataContract]
    public partial class Settings :  IEquatable<Settings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="CommunicationBasedACW">Communication Based ACW.</param>
        /// <param name="IncludeNonAgentConversationSummary">Display communication summary.</param>
        /// <param name="AllowCallbackQueueSelection">Allow Callback Queue Selection.</param>
        /// <param name="CallbacksInheritRoutingFromInboundCall">Inherit callback routing data from inbound calls.</param>
        /// <param name="CompleteAcwWhenAgentTransitionsOffline">Complete ACW When Agent Transitions Offline.</param>
        /// <param name="TotalActiveCallback">Exclude the 'interacting' duration from the handle calculations of callbacks.</param>
        public Settings(bool? CommunicationBasedACW = null, bool? IncludeNonAgentConversationSummary = null, bool? AllowCallbackQueueSelection = null, bool? CallbacksInheritRoutingFromInboundCall = null, bool? CompleteAcwWhenAgentTransitionsOffline = null, bool? TotalActiveCallback = null)
        {
            this.CommunicationBasedACW = CommunicationBasedACW;
            this.IncludeNonAgentConversationSummary = IncludeNonAgentConversationSummary;
            this.AllowCallbackQueueSelection = AllowCallbackQueueSelection;
            this.CallbacksInheritRoutingFromInboundCall = CallbacksInheritRoutingFromInboundCall;
            this.CompleteAcwWhenAgentTransitionsOffline = CompleteAcwWhenAgentTransitionsOffline;
            this.TotalActiveCallback = TotalActiveCallback;
            
        }
        


        /// <summary>
        /// Communication Based ACW
        /// </summary>
        /// <value>Communication Based ACW</value>
        [DataMember(Name="communicationBasedACW", EmitDefaultValue=false)]
        public bool? CommunicationBasedACW { get; set; }



        /// <summary>
        /// Display communication summary
        /// </summary>
        /// <value>Display communication summary</value>
        [DataMember(Name="includeNonAgentConversationSummary", EmitDefaultValue=false)]
        public bool? IncludeNonAgentConversationSummary { get; set; }



        /// <summary>
        /// Allow Callback Queue Selection
        /// </summary>
        /// <value>Allow Callback Queue Selection</value>
        [DataMember(Name="allowCallbackQueueSelection", EmitDefaultValue=false)]
        public bool? AllowCallbackQueueSelection { get; set; }



        /// <summary>
        /// Inherit callback routing data from inbound calls
        /// </summary>
        /// <value>Inherit callback routing data from inbound calls</value>
        [DataMember(Name="callbacksInheritRoutingFromInboundCall", EmitDefaultValue=false)]
        public bool? CallbacksInheritRoutingFromInboundCall { get; set; }



        /// <summary>
        /// Complete ACW When Agent Transitions Offline
        /// </summary>
        /// <value>Complete ACW When Agent Transitions Offline</value>
        [DataMember(Name="completeAcwWhenAgentTransitionsOffline", EmitDefaultValue=false)]
        public bool? CompleteAcwWhenAgentTransitionsOffline { get; set; }



        /// <summary>
        /// Exclude the 'interacting' duration from the handle calculations of callbacks
        /// </summary>
        /// <value>Exclude the 'interacting' duration from the handle calculations of callbacks</value>
        [DataMember(Name="totalActiveCallback", EmitDefaultValue=false)]
        public bool? TotalActiveCallback { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Settings {\n");

            sb.Append("  CommunicationBasedACW: ").Append(CommunicationBasedACW).Append("\n");
            sb.Append("  IncludeNonAgentConversationSummary: ").Append(IncludeNonAgentConversationSummary).Append("\n");
            sb.Append("  AllowCallbackQueueSelection: ").Append(AllowCallbackQueueSelection).Append("\n");
            sb.Append("  CallbacksInheritRoutingFromInboundCall: ").Append(CallbacksInheritRoutingFromInboundCall).Append("\n");
            sb.Append("  CompleteAcwWhenAgentTransitionsOffline: ").Append(CompleteAcwWhenAgentTransitionsOffline).Append("\n");
            sb.Append("  TotalActiveCallback: ").Append(TotalActiveCallback).Append("\n");
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
            return this.Equals(obj as Settings);
        }

        /// <summary>
        /// Returns true if Settings instances are equal
        /// </summary>
        /// <param name="other">Instance of Settings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Settings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CommunicationBasedACW == other.CommunicationBasedACW ||
                    this.CommunicationBasedACW != null &&
                    this.CommunicationBasedACW.Equals(other.CommunicationBasedACW)
                ) &&
                (
                    this.IncludeNonAgentConversationSummary == other.IncludeNonAgentConversationSummary ||
                    this.IncludeNonAgentConversationSummary != null &&
                    this.IncludeNonAgentConversationSummary.Equals(other.IncludeNonAgentConversationSummary)
                ) &&
                (
                    this.AllowCallbackQueueSelection == other.AllowCallbackQueueSelection ||
                    this.AllowCallbackQueueSelection != null &&
                    this.AllowCallbackQueueSelection.Equals(other.AllowCallbackQueueSelection)
                ) &&
                (
                    this.CallbacksInheritRoutingFromInboundCall == other.CallbacksInheritRoutingFromInboundCall ||
                    this.CallbacksInheritRoutingFromInboundCall != null &&
                    this.CallbacksInheritRoutingFromInboundCall.Equals(other.CallbacksInheritRoutingFromInboundCall)
                ) &&
                (
                    this.CompleteAcwWhenAgentTransitionsOffline == other.CompleteAcwWhenAgentTransitionsOffline ||
                    this.CompleteAcwWhenAgentTransitionsOffline != null &&
                    this.CompleteAcwWhenAgentTransitionsOffline.Equals(other.CompleteAcwWhenAgentTransitionsOffline)
                ) &&
                (
                    this.TotalActiveCallback == other.TotalActiveCallback ||
                    this.TotalActiveCallback != null &&
                    this.TotalActiveCallback.Equals(other.TotalActiveCallback)
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
                if (this.CommunicationBasedACW != null)
                    hash = hash * 59 + this.CommunicationBasedACW.GetHashCode();

                if (this.IncludeNonAgentConversationSummary != null)
                    hash = hash * 59 + this.IncludeNonAgentConversationSummary.GetHashCode();

                if (this.AllowCallbackQueueSelection != null)
                    hash = hash * 59 + this.AllowCallbackQueueSelection.GetHashCode();

                if (this.CallbacksInheritRoutingFromInboundCall != null)
                    hash = hash * 59 + this.CallbacksInheritRoutingFromInboundCall.GetHashCode();

                if (this.CompleteAcwWhenAgentTransitionsOffline != null)
                    hash = hash * 59 + this.CompleteAcwWhenAgentTransitionsOffline.GetHashCode();

                if (this.TotalActiveCallback != null)
                    hash = hash * 59 + this.TotalActiveCallback.GetHashCode();

                return hash;
            }
        }
    }

}
