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
    /// LogEntry
    /// </summary>
    [DataContract]
    public partial class LogEntry :  IEquatable<LogEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogEntry" /> class.
        /// </summary>
        /// <param name="Level">Level of log entry.</param>
        /// <param name="Message">Log message.</param>
        /// <param name="Timestamp">Timestamp of log entry.</param>
        public LogEntry(string Level = null, string Message = null, long? Timestamp = null)
        {
            this.Level = Level;
            this.Message = Message;
            this.Timestamp = Timestamp;
            
        }
        


        /// <summary>
        /// Level of log entry
        /// </summary>
        /// <value>Level of log entry</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }



        /// <summary>
        /// Log message
        /// </summary>
        /// <value>Log message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Timestamp of log entry
        /// </summary>
        /// <value>Timestamp of log entry</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogEntry {\n");

            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as LogEntry);
        }

        /// <summary>
        /// Returns true if LogEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of LogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();

                return hash;
            }
        }
    }

}
