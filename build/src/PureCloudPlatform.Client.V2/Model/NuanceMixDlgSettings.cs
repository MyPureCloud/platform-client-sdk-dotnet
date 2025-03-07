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
    /// NuanceMixDlgSettings
    /// </summary>
    [DataContract]
    public partial class NuanceMixDlgSettings :  IEquatable<NuanceMixDlgSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NuanceMixDlgSettings" /> class.
        /// </summary>
        /// <param name="ChannelId">The Nuance channel ID to use when launching the Nuance bot, which must one of the code names of the bot&#39;s registered input channels..</param>
        /// <param name="InputParameters">Name/value pairs of input variables to be sent to the Nuance bot. The values must be in the appropriate format for the variable&#39;s type (see https://docs.mix.nuance.com/dialog-grpc/v1/#simple-variable-types for help).</param>
        public NuanceMixDlgSettings(string ChannelId = null, Dictionary<string, Object> InputParameters = null)
        {
            this.ChannelId = ChannelId;
            this.InputParameters = InputParameters;
            
        }
        


        /// <summary>
        /// The Nuance channel ID to use when launching the Nuance bot, which must one of the code names of the bot&#39;s registered input channels.
        /// </summary>
        /// <value>The Nuance channel ID to use when launching the Nuance bot, which must one of the code names of the bot&#39;s registered input channels.</value>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public string ChannelId { get; set; }



        /// <summary>
        /// Name/value pairs of input variables to be sent to the Nuance bot. The values must be in the appropriate format for the variable&#39;s type (see https://docs.mix.nuance.com/dialog-grpc/v1/#simple-variable-types for help)
        /// </summary>
        /// <value>Name/value pairs of input variables to be sent to the Nuance bot. The values must be in the appropriate format for the variable&#39;s type (see https://docs.mix.nuance.com/dialog-grpc/v1/#simple-variable-types for help)</value>
        [DataMember(Name="inputParameters", EmitDefaultValue=false)]
        public Dictionary<string, Object> InputParameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NuanceMixDlgSettings {\n");

            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  InputParameters: ").Append(InputParameters).Append("\n");
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
            return this.Equals(obj as NuanceMixDlgSettings);
        }

        /// <summary>
        /// Returns true if NuanceMixDlgSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of NuanceMixDlgSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NuanceMixDlgSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ChannelId == other.ChannelId ||
                    this.ChannelId != null &&
                    this.ChannelId.Equals(other.ChannelId)
                ) &&
                (
                    this.InputParameters == other.InputParameters ||
                    this.InputParameters != null &&
                    this.InputParameters.SequenceEqual(other.InputParameters)
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
                if (this.ChannelId != null)
                    hash = hash * 59 + this.ChannelId.GetHashCode();

                if (this.InputParameters != null)
                    hash = hash * 59 + this.InputParameters.GetHashCode();

                return hash;
            }
        }
    }

}
