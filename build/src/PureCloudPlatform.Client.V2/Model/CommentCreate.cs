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
    /// CommentCreate
    /// </summary>
    [DataContract]
    public partial class CommentCreate :  IEquatable<CommentCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommentCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentCreate" /> class.
        /// </summary>
        /// <param name="Content">Comment body, which cannot be empty and has a maximum length of 4,096 characters. (required).</param>
        public CommentCreate(string Content = null)
        {
            this.Content = Content;
            
        }
        


        /// <summary>
        /// Comment body, which cannot be empty and has a maximum length of 4,096 characters.
        /// </summary>
        /// <value>Comment body, which cannot be empty and has a maximum length of 4,096 characters.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentCreate {\n");

            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as CommentCreate);
        }

        /// <summary>
        /// Returns true if CommentCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of CommentCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommentCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                return hash;
            }
        }
    }

}
