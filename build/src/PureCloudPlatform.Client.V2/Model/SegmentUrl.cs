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
    /// SegmentUrl
    /// </summary>
    [DataContract]
    public partial class SegmentUrl :  IEquatable<SegmentUrl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentUrl" /> class.
        /// </summary>
        /// <param name="Recording">The Recording Reference.</param>
        /// <param name="Url">The pre-signed S3 URL of the transcript.</param>
        public SegmentUrl(AddressableEntityRef Recording = null, string Url = null)
        {
            this.Recording = Recording;
            this.Url = Url;
            
        }
        


        /// <summary>
        /// The Recording Reference
        /// </summary>
        /// <value>The Recording Reference</value>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public AddressableEntityRef Recording { get; set; }



        /// <summary>
        /// The pre-signed S3 URL of the transcript
        /// </summary>
        /// <value>The pre-signed S3 URL of the transcript</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentUrl {\n");

            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as SegmentUrl);
        }

        /// <summary>
        /// Returns true if SegmentUrl instances are equal
        /// </summary>
        /// <param name="other">Instance of SegmentUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegmentUrl other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Recording != null)
                    hash = hash * 59 + this.Recording.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                return hash;
            }
        }
    }

}
