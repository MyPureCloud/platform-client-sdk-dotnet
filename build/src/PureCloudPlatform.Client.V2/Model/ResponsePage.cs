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
    /// ResponsePage
    /// </summary>
    [DataContract]
    public partial class ResponsePage :  IEquatable<ResponsePage>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponsePage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePage" /> class.
        /// </summary>
        /// <param name="Url">The page URL. (required).</param>
        /// <param name="Title">Title of the page. (required).</param>
        /// <param name="Domain">Domain of the page&#39;s URL. (required).</param>
        /// <param name="Fragment">Fragment or hash of the page&#39;s URL..</param>
        /// <param name="Hostname">Hostname of the page&#39;s URL. (required).</param>
        /// <param name="Keywords">Keywords from the HTML &lt;meta&gt; tag of the page..</param>
        /// <param name="Lang">ISO 639-1 language code for the page as defined in the &lt;html&gt; tag..</param>
        /// <param name="Pathname">Path name of the page for the event. (required).</param>
        /// <param name="QueryString">Query string that is passed to the page in the current event..</param>
        public ResponsePage(string Url = null, string Title = null, string Domain = null, string Fragment = null, string Hostname = null, string Keywords = null, string Lang = null, string Pathname = null, string QueryString = null)
        {
            this.Url = Url;
            this.Title = Title;
            this.Domain = Domain;
            this.Fragment = Fragment;
            this.Hostname = Hostname;
            this.Keywords = Keywords;
            this.Lang = Lang;
            this.Pathname = Pathname;
            this.QueryString = QueryString;
            
        }
        


        /// <summary>
        /// The page URL.
        /// </summary>
        /// <value>The page URL.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Title of the page.
        /// </summary>
        /// <value>Title of the page.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Domain of the page&#39;s URL.
        /// </summary>
        /// <value>Domain of the page&#39;s URL.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }



        /// <summary>
        /// Fragment or hash of the page&#39;s URL.
        /// </summary>
        /// <value>Fragment or hash of the page&#39;s URL.</value>
        [DataMember(Name="fragment", EmitDefaultValue=false)]
        public string Fragment { get; set; }



        /// <summary>
        /// Hostname of the page&#39;s URL.
        /// </summary>
        /// <value>Hostname of the page&#39;s URL.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }



        /// <summary>
        /// Keywords from the HTML &lt;meta&gt; tag of the page.
        /// </summary>
        /// <value>Keywords from the HTML &lt;meta&gt; tag of the page.</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }



        /// <summary>
        /// ISO 639-1 language code for the page as defined in the &lt;html&gt; tag.
        /// </summary>
        /// <value>ISO 639-1 language code for the page as defined in the &lt;html&gt; tag.</value>
        [DataMember(Name="lang", EmitDefaultValue=false)]
        public string Lang { get; set; }



        /// <summary>
        /// Path name of the page for the event.
        /// </summary>
        /// <value>Path name of the page for the event.</value>
        [DataMember(Name="pathname", EmitDefaultValue=false)]
        public string Pathname { get; set; }



        /// <summary>
        /// Query string that is passed to the page in the current event.
        /// </summary>
        /// <value>Query string that is passed to the page in the current event.</value>
        [DataMember(Name="queryString", EmitDefaultValue=false)]
        public string QueryString { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponsePage {\n");

            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Fragment: ").Append(Fragment).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  Pathname: ").Append(Pathname).Append("\n");
            sb.Append("  QueryString: ").Append(QueryString).Append("\n");
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
            return this.Equals(obj as ResponsePage);
        }

        /// <summary>
        /// Returns true if ResponsePage instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponsePage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponsePage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.Fragment == other.Fragment ||
                    this.Fragment != null &&
                    this.Fragment.Equals(other.Fragment)
                ) &&
                (
                    this.Hostname == other.Hostname ||
                    this.Hostname != null &&
                    this.Hostname.Equals(other.Hostname)
                ) &&
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.Equals(other.Keywords)
                ) &&
                (
                    this.Lang == other.Lang ||
                    this.Lang != null &&
                    this.Lang.Equals(other.Lang)
                ) &&
                (
                    this.Pathname == other.Pathname ||
                    this.Pathname != null &&
                    this.Pathname.Equals(other.Pathname)
                ) &&
                (
                    this.QueryString == other.QueryString ||
                    this.QueryString != null &&
                    this.QueryString.Equals(other.QueryString)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();

                if (this.Fragment != null)
                    hash = hash * 59 + this.Fragment.GetHashCode();

                if (this.Hostname != null)
                    hash = hash * 59 + this.Hostname.GetHashCode();

                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();

                if (this.Lang != null)
                    hash = hash * 59 + this.Lang.GetHashCode();

                if (this.Pathname != null)
                    hash = hash * 59 + this.Pathname.GetHashCode();

                if (this.QueryString != null)
                    hash = hash * 59 + this.QueryString.GetHashCode();

                return hash;
            }
        }
    }

}
