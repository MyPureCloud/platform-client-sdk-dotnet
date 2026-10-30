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
    /// ContentSearchSetting
    /// </summary>
    [DataContract]
    public partial class ContentSearchSetting :  IEquatable<ContentSearchSetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSearchSetting" /> class.
        /// </summary>
        /// <param name="ContentSearchEnabled">If true, enables full-text search of interaction transcripts.</param>
        public ContentSearchSetting(bool? ContentSearchEnabled = null)
        {
            this.ContentSearchEnabled = ContentSearchEnabled;
            
        }
        


        /// <summary>
        /// If true, enables full-text search of interaction transcripts
        /// </summary>
        /// <value>If true, enables full-text search of interaction transcripts</value>
        [DataMember(Name="contentSearchEnabled", EmitDefaultValue=false)]
        public bool? ContentSearchEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentSearchSetting {\n");

            sb.Append("  ContentSearchEnabled: ").Append(ContentSearchEnabled).Append("\n");
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
            return this.Equals(obj as ContentSearchSetting);
        }

        /// <summary>
        /// Returns true if ContentSearchSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentSearchSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentSearchSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContentSearchEnabled == other.ContentSearchEnabled ||
                    this.ContentSearchEnabled != null &&
                    this.ContentSearchEnabled.Equals(other.ContentSearchEnabled)
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
                if (this.ContentSearchEnabled != null)
                    hash = hash * 59 + this.ContentSearchEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
