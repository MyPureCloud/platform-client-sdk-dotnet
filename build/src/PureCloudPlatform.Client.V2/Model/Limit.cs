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
    /// Limit
    /// </summary>
    [DataContract]
    public partial class Limit :  IEquatable<Limit>
    {
        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NamespaceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Workforcemanagement for "workforce.management"
            /// </summary>
            [EnumMember(Value = "workforce.management")]
            Workforcemanagement,
            
            /// <summary>
            /// Enum Agentassistant for "agent.assistant"
            /// </summary>
            [EnumMember(Value = "agent.assistant")]
            Agentassistant,
            
            /// <summary>
            /// Enum Analyticsagents for "analytics.agents"
            /// </summary>
            [EnumMember(Value = "analytics.agents")]
            Analyticsagents,
            
            /// <summary>
            /// Enum Analyticsalerting for "analytics.alerting"
            /// </summary>
            [EnumMember(Value = "analytics.alerting")]
            Analyticsalerting,
            
            /// <summary>
            /// Enum Analyticsdataextraction for "analytics.data.extraction"
            /// </summary>
            [EnumMember(Value = "analytics.data.extraction")]
            Analyticsdataextraction,
            
            /// <summary>
            /// Enum Analytics for "analytics"
            /// </summary>
            [EnumMember(Value = "analytics")]
            Analytics,
            
            /// <summary>
            /// Enum Analyticsrealtime for "analytics.realtime"
            /// </summary>
            [EnumMember(Value = "analytics.realtime")]
            Analyticsrealtime,
            
            /// <summary>
            /// Enum Analyticsreportingsettings for "analytics.reporting.settings"
            /// </summary>
            [EnumMember(Value = "analytics.reporting.settings")]
            Analyticsreportingsettings,
            
            /// <summary>
            /// Enum Architect for "architect"
            /// </summary>
            [EnumMember(Value = "architect")]
            Architect,
            
            /// <summary>
            /// Enum Audiohook for "audiohook"
            /// </summary>
            [EnumMember(Value = "audiohook")]
            Audiohook,
            
            /// <summary>
            /// Enum Audiohookmonitor for "audiohook.monitor"
            /// </summary>
            [EnumMember(Value = "audiohook.monitor")]
            Audiohookmonitor,
            
            /// <summary>
            /// Enum Audit for "audit"
            /// </summary>
            [EnumMember(Value = "audit")]
            Audit,
            
            /// <summary>
            /// Enum Authapi for "auth.api"
            /// </summary>
            [EnumMember(Value = "auth.api")]
            Authapi,
            
            /// <summary>
            /// Enum Authorization for "authorization"
            /// </summary>
            [EnumMember(Value = "authorization")]
            Authorization,
            
            /// <summary>
            /// Enum Automationtesting for "automation.testing"
            /// </summary>
            [EnumMember(Value = "automation.testing")]
            Automationtesting,
            
            /// <summary>
            /// Enum Bots for "bots"
            /// </summary>
            [EnumMember(Value = "bots")]
            Bots,
            
            /// <summary>
            /// Enum Botsvoice for "bots.voice"
            /// </summary>
            [EnumMember(Value = "bots.voice")]
            Botsvoice,
            
            /// <summary>
            /// Enum Businessrules for "business.rules"
            /// </summary>
            [EnumMember(Value = "business.rules")]
            Businessrules,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Cobrowse for "cobrowse"
            /// </summary>
            [EnumMember(Value = "cobrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Contentmanagement for "content.management"
            /// </summary>
            [EnumMember(Value = "content.management")]
            Contentmanagement,
            
            /// <summary>
            /// Enum Conversation for "conversation"
            /// </summary>
            [EnumMember(Value = "conversation")]
            Conversation,
            
            /// <summary>
            /// Enum Dataactions for "dataactions"
            /// </summary>
            [EnumMember(Value = "dataactions")]
            Dataactions,
            
            /// <summary>
            /// Enum Datatables for "datatables"
            /// </summary>
            [EnumMember(Value = "datatables")]
            Datatables,
            
            /// <summary>
            /// Enum Directory for "directory"
            /// </summary>
            [EnumMember(Value = "directory")]
            Directory,
            
            /// <summary>
            /// Enum Dsar for "dsar"
            /// </summary>
            [EnumMember(Value = "dsar")]
            Dsar,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Employeeengagement for "employee.engagement"
            /// </summary>
            [EnumMember(Value = "employee.engagement")]
            Employeeengagement,
            
            /// <summary>
            /// Enum Eventorchestration for "event.orchestration"
            /// </summary>
            [EnumMember(Value = "event.orchestration")]
            Eventorchestration,
            
            /// <summary>
            /// Enum Externalcontacts for "external.contacts"
            /// </summary>
            [EnumMember(Value = "external.contacts")]
            Externalcontacts,
            
            /// <summary>
            /// Enum Externaleventsdataingestion for "external.events.data.ingestion"
            /// </summary>
            [EnumMember(Value = "external.events.data.ingestion")]
            Externaleventsdataingestion,
            
            /// <summary>
            /// Enum Gamification for "gamification"
            /// </summary>
            [EnumMember(Value = "gamification")]
            Gamification,
            
            /// <summary>
            /// Enum Gcv for "gcv"
            /// </summary>
            [EnumMember(Value = "gcv")]
            Gcv,
            
            /// <summary>
            /// Enum Gdpr for "gdpr"
            /// </summary>
            [EnumMember(Value = "gdpr")]
            Gdpr,
            
            /// <summary>
            /// Enum Groups for "groups"
            /// </summary>
            [EnumMember(Value = "groups")]
            Groups,
            
            /// <summary>
            /// Enum Guides for "guides"
            /// </summary>
            [EnumMember(Value = "guides")]
            Guides,
            
            /// <summary>
            /// Enum Historicaladherence for "historical.adherence"
            /// </summary>
            [EnumMember(Value = "historical.adherence")]
            Historicaladherence,
            
            /// <summary>
            /// Enum Infrastructureascode for "infrastructureascode"
            /// </summary>
            [EnumMember(Value = "infrastructureascode")]
            Infrastructureascode,
            
            /// <summary>
            /// Enum Integrations for "integrations"
            /// </summary>
            [EnumMember(Value = "integrations")]
            Integrations,
            
            /// <summary>
            /// Enum Intentminer for "intent.miner"
            /// </summary>
            [EnumMember(Value = "intent.miner")]
            Intentminer,
            
            /// <summary>
            /// Enum Internalmessaging for "internal.messaging"
            /// </summary>
            [EnumMember(Value = "internal.messaging")]
            Internalmessaging,
            
            /// <summary>
            /// Enum Journey for "journey"
            /// </summary>
            [EnumMember(Value = "journey")]
            Journey,
            
            /// <summary>
            /// Enum Knowledge for "knowledge"
            /// </summary>
            [EnumMember(Value = "knowledge")]
            Knowledge,
            
            /// <summary>
            /// Enum Languageunderstanding for "language.understanding"
            /// </summary>
            [EnumMember(Value = "language.understanding")]
            Languageunderstanding,
            
            /// <summary>
            /// Enum Learning for "learning"
            /// </summary>
            [EnumMember(Value = "learning")]
            Learning,
            
            /// <summary>
            /// Enum Limitregistry for "limit.registry"
            /// </summary>
            [EnumMember(Value = "limit.registry")]
            Limitregistry,
            
            /// <summary>
            /// Enum Marketplace for "marketplace"
            /// </summary>
            [EnumMember(Value = "marketplace")]
            Marketplace,
            
            /// <summary>
            /// Enum Mediacommunications for "media.communications"
            /// </summary>
            [EnumMember(Value = "media.communications")]
            Mediacommunications,
            
            /// <summary>
            /// Enum Messaging for "messaging"
            /// </summary>
            [EnumMember(Value = "messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Microfrontend for "micro.frontend"
            /// </summary>
            [EnumMember(Value = "micro.frontend")]
            Microfrontend,
            
            /// <summary>
            /// Enum Notifications for "notifications"
            /// </summary>
            [EnumMember(Value = "notifications")]
            Notifications,
            
            /// <summary>
            /// Enum Onboarding for "onboarding"
            /// </summary>
            [EnumMember(Value = "onboarding")]
            Onboarding,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Platformapi for "platform.api"
            /// </summary>
            [EnumMember(Value = "platform.api")]
            Platformapi,
            
            /// <summary>
            /// Enum Predictiverouting for "predictive.routing"
            /// </summary>
            [EnumMember(Value = "predictive.routing")]
            Predictiverouting,
            
            /// <summary>
            /// Enum Presence for "presence"
            /// </summary>
            [EnumMember(Value = "presence")]
            Presence,
            
            /// <summary>
            /// Enum Quality for "quality"
            /// </summary>
            [EnumMember(Value = "quality")]
            Quality,
            
            /// <summary>
            /// Enum Recording for "recording"
            /// </summary>
            [EnumMember(Value = "recording")]
            Recording,
            
            /// <summary>
            /// Enum Responsemanagement for "response.management"
            /// </summary>
            [EnumMember(Value = "response.management")]
            Responsemanagement,
            
            /// <summary>
            /// Enum Routing for "routing"
            /// </summary>
            [EnumMember(Value = "routing")]
            Routing,
            
            /// <summary>
            /// Enum Scim for "scim"
            /// </summary>
            [EnumMember(Value = "scim")]
            Scim,
            
            /// <summary>
            /// Enum Screenmonitoring for "screen.monitoring"
            /// </summary>
            [EnumMember(Value = "screen.monitoring")]
            Screenmonitoring,
            
            /// <summary>
            /// Enum Search for "search"
            /// </summary>
            [EnumMember(Value = "search")]
            Search,
            
            /// <summary>
            /// Enum Secondaryautomationtesting for "secondary.automation.testing"
            /// </summary>
            [EnumMember(Value = "secondary.automation.testing")]
            Secondaryautomationtesting,
            
            /// <summary>
            /// Enum Skills for "skills"
            /// </summary>
            [EnumMember(Value = "skills")]
            Skills,
            
            /// <summary>
            /// Enum Socialmedia for "social.media"
            /// </summary>
            [EnumMember(Value = "social.media")]
            Socialmedia,
            
            /// <summary>
            /// Enum Speechandtextanalytics for "speech.and.text.analytics"
            /// </summary>
            [EnumMember(Value = "speech.and.text.analytics")]
            Speechandtextanalytics,
            
            /// <summary>
            /// Enum Speechintegration for "speech.integration"
            /// </summary>
            [EnumMember(Value = "speech.integration")]
            Speechintegration,
            
            /// <summary>
            /// Enum Supportability for "supportability"
            /// </summary>
            [EnumMember(Value = "supportability")]
            Supportability,
            
            /// <summary>
            /// Enum Taskmanagement for "task.management"
            /// </summary>
            [EnumMember(Value = "task.management")]
            Taskmanagement,
            
            /// <summary>
            /// Enum Telephonyconfiguration for "telephony.configuration"
            /// </summary>
            [EnumMember(Value = "telephony.configuration")]
            Telephonyconfiguration,
            
            /// <summary>
            /// Enum Usage for "usage"
            /// </summary>
            [EnumMember(Value = "usage")]
            Usage,
            
            /// <summary>
            /// Enum Users for "users"
            /// </summary>
            [EnumMember(Value = "users")]
            Users,
            
            /// <summary>
            /// Enum Usersrules for "users.rules"
            /// </summary>
            [EnumMember(Value = "users.rules")]
            Usersrules,
            
            /// <summary>
            /// Enum Voicetranscription for "voice.transcription"
            /// </summary>
            [EnumMember(Value = "voice.transcription")]
            Voicetranscription,
            
            /// <summary>
            /// Enum Webdeployments for "web.deployments"
            /// </summary>
            [EnumMember(Value = "web.deployments")]
            Webdeployments,
            
            /// <summary>
            /// Enum Webmessaging for "web.messaging"
            /// </summary>
            [EnumMember(Value = "web.messaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Webchat for "webchat"
            /// </summary>
            [EnumMember(Value = "webchat")]
            Webchat,
            
            /// <summary>
            /// Enum Webhooks for "webhooks"
            /// </summary>
            [EnumMember(Value = "webhooks")]
            Webhooks,
            
            /// <summary>
            /// Enum Workforcemanagementagentavailability for "workforce.management.agent.availability"
            /// </summary>
            [EnumMember(Value = "workforce.management.agent.availability")]
            Workforcemanagementagentavailability,
            
            /// <summary>
            /// Enum Workforcemanagementforecast for "workforce.management.forecast"
            /// </summary>
            [EnumMember(Value = "workforce.management.forecast")]
            Workforcemanagementforecast,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System
        }
        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public NamespaceEnum? Namespace { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Limit" /> class.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="Namespace">Namespace.</param>
        /// <param name="Value">Value.</param>
        public Limit(string Key = null, NamespaceEnum? Namespace = null, long? Value = null)
        {
            this.Key = Key;
            this.Namespace = Namespace;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }





        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public long? Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Limit {\n");

            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as Limit);
        }

        /// <summary>
        /// Returns true if Limit instances are equal
        /// </summary>
        /// <param name="other">Instance of Limit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Limit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) &&
                (
                    this.Namespace == other.Namespace ||
                    this.Namespace != null &&
                    this.Namespace.Equals(other.Namespace)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();

                if (this.Namespace != null)
                    hash = hash * 59 + this.Namespace.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
