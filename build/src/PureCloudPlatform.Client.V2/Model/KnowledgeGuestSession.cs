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
    /// KnowledgeGuestSession
    /// </summary>
    [DataContract]
    public partial class KnowledgeGuestSession :  IEquatable<KnowledgeGuestSession>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeGuestSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeGuestSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeGuestSession" /> class.
        /// </summary>
        /// <param name="App">The app where the session is started. (required).</param>
        /// <param name="CustomerId">An arbitrary ID for the customer starting the session. Used to track multiple sessions started by the same customer. (required).</param>
        /// <param name="PageUrl">URL of the page where the session is started..</param>
        /// <param name="Contexts">The session contexts..</param>
        /// <param name="JourneySessionId">Journey session ID. Used to get the segments of the customer to filter search results..</param>
        public KnowledgeGuestSession(KnowledgeGuestSessionApp App = null, string CustomerId = null, string PageUrl = null, List<KnowledgeGuestSessionContext> Contexts = null, string JourneySessionId = null)
        {
            this.App = App;
            this.CustomerId = CustomerId;
            this.PageUrl = PageUrl;
            this.Contexts = Contexts;
            this.JourneySessionId = JourneySessionId;
            
        }
        


        /// <summary>
        /// Session ID.
        /// </summary>
        /// <value>Session ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The app where the session is started.
        /// </summary>
        /// <value>The app where the session is started.</value>
        [DataMember(Name="app", EmitDefaultValue=false)]
        public KnowledgeGuestSessionApp App { get; set; }



        /// <summary>
        /// An arbitrary ID for the customer starting the session. Used to track multiple sessions started by the same customer.
        /// </summary>
        /// <value>An arbitrary ID for the customer starting the session. Used to track multiple sessions started by the same customer.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }



        /// <summary>
        /// URL of the page where the session is started.
        /// </summary>
        /// <value>URL of the page where the session is started.</value>
        [DataMember(Name="pageUrl", EmitDefaultValue=false)]
        public string PageUrl { get; set; }



        /// <summary>
        /// The session contexts.
        /// </summary>
        /// <value>The session contexts.</value>
        [DataMember(Name="contexts", EmitDefaultValue=false)]
        public List<KnowledgeGuestSessionContext> Contexts { get; set; }



        /// <summary>
        /// Journey session ID. Used to get the segments of the customer to filter search results.
        /// </summary>
        /// <value>Journey session ID. Used to get the segments of the customer to filter search results.</value>
        [DataMember(Name="journeySessionId", EmitDefaultValue=false)]
        public string JourneySessionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeGuestSession {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  PageUrl: ").Append(PageUrl).Append("\n");
            sb.Append("  Contexts: ").Append(Contexts).Append("\n");
            sb.Append("  JourneySessionId: ").Append(JourneySessionId).Append("\n");
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
            return this.Equals(obj as KnowledgeGuestSession);
        }

        /// <summary>
        /// Returns true if KnowledgeGuestSession instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeGuestSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeGuestSession other)
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
                    this.App == other.App ||
                    this.App != null &&
                    this.App.Equals(other.App)
                ) &&
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) &&
                (
                    this.PageUrl == other.PageUrl ||
                    this.PageUrl != null &&
                    this.PageUrl.Equals(other.PageUrl)
                ) &&
                (
                    this.Contexts == other.Contexts ||
                    this.Contexts != null &&
                    this.Contexts.SequenceEqual(other.Contexts)
                ) &&
                (
                    this.JourneySessionId == other.JourneySessionId ||
                    this.JourneySessionId != null &&
                    this.JourneySessionId.Equals(other.JourneySessionId)
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

                if (this.App != null)
                    hash = hash * 59 + this.App.GetHashCode();

                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();

                if (this.PageUrl != null)
                    hash = hash * 59 + this.PageUrl.GetHashCode();

                if (this.Contexts != null)
                    hash = hash * 59 + this.Contexts.GetHashCode();

                if (this.JourneySessionId != null)
                    hash = hash * 59 + this.JourneySessionId.GetHashCode();

                return hash;
            }
        }
    }

}
