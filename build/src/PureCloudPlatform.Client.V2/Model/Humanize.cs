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
    /// Humanize
    /// </summary>
    [DataContract]
    public partial class Humanize :  IEquatable<Humanize>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Humanize" /> class.
        /// </summary>
        /// <param name="Enabled">Whether or not humanize conversations setting is enabled.</param>
        /// <param name="Bot">Bot messenger profile setting.</param>
        public Humanize(bool? Enabled = null, BotMessengerProfile Bot = null)
        {
            this.Enabled = Enabled;
            this.Bot = Bot;
            
        }
        


        /// <summary>
        /// Whether or not humanize conversations setting is enabled
        /// </summary>
        /// <value>Whether or not humanize conversations setting is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Bot messenger profile setting
        /// </summary>
        /// <value>Bot messenger profile setting</value>
        [DataMember(Name="bot", EmitDefaultValue=false)]
        public BotMessengerProfile Bot { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Humanize {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Bot: ").Append(Bot).Append("\n");
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
            return this.Equals(obj as Humanize);
        }

        /// <summary>
        /// Returns true if Humanize instances are equal
        /// </summary>
        /// <param name="other">Instance of Humanize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Humanize other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Bot == other.Bot ||
                    this.Bot != null &&
                    this.Bot.Equals(other.Bot)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Bot != null)
                    hash = hash * 59 + this.Bot.GetHashCode();

                return hash;
            }
        }
    }

}
