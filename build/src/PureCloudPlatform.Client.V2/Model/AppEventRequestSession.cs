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
    /// AppEventRequestSession
    /// </summary>
    [DataContract]
    public partial class AppEventRequestSession :  IEquatable<AppEventRequestSession>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventRequestSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppEventRequestSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventRequestSession" /> class.
        /// </summary>
        /// <param name="Id">ID of the app session. (required).</param>
        /// <param name="EventCount">The count of all events recorded during this session. This should be incremented for each event in the session, regardless of event name. (required).</param>
        /// <param name="ScreenviewCount">The count of all screen view events recorded during this session. This should be incremented for each screen_viewed event in the session. (required).</param>
        public AppEventRequestSession(string Id = null, int? EventCount = null, int? ScreenviewCount = null)
        {
            this.Id = Id;
            this.EventCount = EventCount;
            this.ScreenviewCount = ScreenviewCount;
            
        }
        


        /// <summary>
        /// ID of the app session.
        /// </summary>
        /// <value>ID of the app session.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The count of all events recorded during this session. This should be incremented for each event in the session, regardless of event name.
        /// </summary>
        /// <value>The count of all events recorded during this session. This should be incremented for each event in the session, regardless of event name.</value>
        [DataMember(Name="eventCount", EmitDefaultValue=false)]
        public int? EventCount { get; set; }



        /// <summary>
        /// The count of all screen view events recorded during this session. This should be incremented for each screen_viewed event in the session.
        /// </summary>
        /// <value>The count of all screen view events recorded during this session. This should be incremented for each screen_viewed event in the session.</value>
        [DataMember(Name="screenviewCount", EmitDefaultValue=false)]
        public int? ScreenviewCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppEventRequestSession {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventCount: ").Append(EventCount).Append("\n");
            sb.Append("  ScreenviewCount: ").Append(ScreenviewCount).Append("\n");
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
            return this.Equals(obj as AppEventRequestSession);
        }

        /// <summary>
        /// Returns true if AppEventRequestSession instances are equal
        /// </summary>
        /// <param name="other">Instance of AppEventRequestSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppEventRequestSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.EventCount == other.EventCount ||
                    this.EventCount != null &&
                    this.EventCount.Equals(other.EventCount)
                ) &&
                (
                    this.ScreenviewCount == other.ScreenviewCount ||
                    this.ScreenviewCount != null &&
                    this.ScreenviewCount.Equals(other.ScreenviewCount)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.EventCount != null)
                    hash = hash * 59 + this.EventCount.GetHashCode();

                if (this.ScreenviewCount != null)
                    hash = hash * 59 + this.ScreenviewCount.GetHashCode();

                return hash;
            }
        }
    }

}
