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
    /// GoogleDialogflowCustomSettings
    /// </summary>
    [DataContract]
    public partial class GoogleDialogflowCustomSettings :  IEquatable<GoogleDialogflowCustomSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDialogflowCustomSettings" /> class.
        /// </summary>
        /// <param name="Environment">If set this environment will be used to initiate the dialogflow bot, otherwise the default configuration will be used.  See https://cloud.google.com/dialogflow/docs/agents-versions.</param>
        /// <param name="EventName">If set this eventName will be used to initiate the dialogflow bot rather than language processing on the input text.  See https://cloud.google.com/dialogflow/es/docs/events-overview.</param>
        /// <param name="WebhookQueryParameters">Parameters passed to the fulfillment webhook of the bot (if any)..</param>
        /// <param name="EventInputParameters">Parameters passed to the event input of the bot..</param>
        public GoogleDialogflowCustomSettings(string Environment = null, string EventName = null, Dictionary<string, string> WebhookQueryParameters = null, Dictionary<string, string> EventInputParameters = null)
        {
            this.Environment = Environment;
            this.EventName = EventName;
            this.WebhookQueryParameters = WebhookQueryParameters;
            this.EventInputParameters = EventInputParameters;
            
        }
        


        /// <summary>
        /// If set this environment will be used to initiate the dialogflow bot, otherwise the default configuration will be used.  See https://cloud.google.com/dialogflow/docs/agents-versions
        /// </summary>
        /// <value>If set this environment will be used to initiate the dialogflow bot, otherwise the default configuration will be used.  See https://cloud.google.com/dialogflow/docs/agents-versions</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public string Environment { get; set; }



        /// <summary>
        /// If set this eventName will be used to initiate the dialogflow bot rather than language processing on the input text.  See https://cloud.google.com/dialogflow/es/docs/events-overview
        /// </summary>
        /// <value>If set this eventName will be used to initiate the dialogflow bot rather than language processing on the input text.  See https://cloud.google.com/dialogflow/es/docs/events-overview</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public string EventName { get; set; }



        /// <summary>
        /// Parameters passed to the fulfillment webhook of the bot (if any).
        /// </summary>
        /// <value>Parameters passed to the fulfillment webhook of the bot (if any).</value>
        [DataMember(Name="webhookQueryParameters", EmitDefaultValue=false)]
        public Dictionary<string, string> WebhookQueryParameters { get; set; }



        /// <summary>
        /// Parameters passed to the event input of the bot.
        /// </summary>
        /// <value>Parameters passed to the event input of the bot.</value>
        [DataMember(Name="eventInputParameters", EmitDefaultValue=false)]
        public Dictionary<string, string> EventInputParameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleDialogflowCustomSettings {\n");

            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  WebhookQueryParameters: ").Append(WebhookQueryParameters).Append("\n");
            sb.Append("  EventInputParameters: ").Append(EventInputParameters).Append("\n");
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
            return this.Equals(obj as GoogleDialogflowCustomSettings);
        }

        /// <summary>
        /// Returns true if GoogleDialogflowCustomSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of GoogleDialogflowCustomSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleDialogflowCustomSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) &&
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) &&
                (
                    this.WebhookQueryParameters == other.WebhookQueryParameters ||
                    this.WebhookQueryParameters != null &&
                    this.WebhookQueryParameters.SequenceEqual(other.WebhookQueryParameters)
                ) &&
                (
                    this.EventInputParameters == other.EventInputParameters ||
                    this.EventInputParameters != null &&
                    this.EventInputParameters.SequenceEqual(other.EventInputParameters)
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
                if (this.Environment != null)
                    hash = hash * 59 + this.Environment.GetHashCode();

                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();

                if (this.WebhookQueryParameters != null)
                    hash = hash * 59 + this.WebhookQueryParameters.GetHashCode();

                if (this.EventInputParameters != null)
                    hash = hash * 59 + this.EventInputParameters.GetHashCode();

                return hash;
            }
        }
    }

}
