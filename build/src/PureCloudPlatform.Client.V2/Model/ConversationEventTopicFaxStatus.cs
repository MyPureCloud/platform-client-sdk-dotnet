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
    /// Extra information on fax transmission.
    /// </summary>
    [DataContract]
    public partial class ConversationEventTopicFaxStatus :  IEquatable<ConversationEventTopicFaxStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventTopicFaxStatus" /> class.
        /// </summary>
        /// <param name="Direction">The fax direction, either \"send\" or \"receive\"..</param>
        /// <param name="ExpectedPages">Total number of expected pages, if known..</param>
        /// <param name="ActivePage">Active page of the transmission..</param>
        /// <param name="LinesTransmitted">Number of lines that have completed transmission..</param>
        /// <param name="BytesTransmitted">Number of bytes that have competed transmission..</param>
        /// <param name="BaudRate">Current signaling rate of transmission, baud rate..</param>
        /// <param name="PageErrors">Number of page errors..</param>
        /// <param name="LineErrors">Number of line errors..</param>
        public ConversationEventTopicFaxStatus(string Direction = null, int? ExpectedPages = null, int? ActivePage = null, int? LinesTransmitted = null, int? BytesTransmitted = null, int? BaudRate = null, int? PageErrors = null, int? LineErrors = null)
        {
            this.Direction = Direction;
            this.ExpectedPages = ExpectedPages;
            this.ActivePage = ActivePage;
            this.LinesTransmitted = LinesTransmitted;
            this.BytesTransmitted = BytesTransmitted;
            this.BaudRate = BaudRate;
            this.PageErrors = PageErrors;
            this.LineErrors = LineErrors;
            
        }
        


        /// <summary>
        /// The fax direction, either \"send\" or \"receive\".
        /// </summary>
        /// <value>The fax direction, either \"send\" or \"receive\".</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }



        /// <summary>
        /// Total number of expected pages, if known.
        /// </summary>
        /// <value>Total number of expected pages, if known.</value>
        [DataMember(Name="expectedPages", EmitDefaultValue=false)]
        public int? ExpectedPages { get; set; }



        /// <summary>
        /// Active page of the transmission.
        /// </summary>
        /// <value>Active page of the transmission.</value>
        [DataMember(Name="activePage", EmitDefaultValue=false)]
        public int? ActivePage { get; set; }



        /// <summary>
        /// Number of lines that have completed transmission.
        /// </summary>
        /// <value>Number of lines that have completed transmission.</value>
        [DataMember(Name="linesTransmitted", EmitDefaultValue=false)]
        public int? LinesTransmitted { get; set; }



        /// <summary>
        /// Number of bytes that have competed transmission.
        /// </summary>
        /// <value>Number of bytes that have competed transmission.</value>
        [DataMember(Name="bytesTransmitted", EmitDefaultValue=false)]
        public int? BytesTransmitted { get; set; }



        /// <summary>
        /// Current signaling rate of transmission, baud rate.
        /// </summary>
        /// <value>Current signaling rate of transmission, baud rate.</value>
        [DataMember(Name="baudRate", EmitDefaultValue=false)]
        public int? BaudRate { get; set; }



        /// <summary>
        /// Number of page errors.
        /// </summary>
        /// <value>Number of page errors.</value>
        [DataMember(Name="pageErrors", EmitDefaultValue=false)]
        public int? PageErrors { get; set; }



        /// <summary>
        /// Number of line errors.
        /// </summary>
        /// <value>Number of line errors.</value>
        [DataMember(Name="lineErrors", EmitDefaultValue=false)]
        public int? LineErrors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventTopicFaxStatus {\n");

            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ExpectedPages: ").Append(ExpectedPages).Append("\n");
            sb.Append("  ActivePage: ").Append(ActivePage).Append("\n");
            sb.Append("  LinesTransmitted: ").Append(LinesTransmitted).Append("\n");
            sb.Append("  BytesTransmitted: ").Append(BytesTransmitted).Append("\n");
            sb.Append("  BaudRate: ").Append(BaudRate).Append("\n");
            sb.Append("  PageErrors: ").Append(PageErrors).Append("\n");
            sb.Append("  LineErrors: ").Append(LineErrors).Append("\n");
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
            return this.Equals(obj as ConversationEventTopicFaxStatus);
        }

        /// <summary>
        /// Returns true if ConversationEventTopicFaxStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationEventTopicFaxStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventTopicFaxStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.ExpectedPages == other.ExpectedPages ||
                    this.ExpectedPages != null &&
                    this.ExpectedPages.Equals(other.ExpectedPages)
                ) &&
                (
                    this.ActivePage == other.ActivePage ||
                    this.ActivePage != null &&
                    this.ActivePage.Equals(other.ActivePage)
                ) &&
                (
                    this.LinesTransmitted == other.LinesTransmitted ||
                    this.LinesTransmitted != null &&
                    this.LinesTransmitted.Equals(other.LinesTransmitted)
                ) &&
                (
                    this.BytesTransmitted == other.BytesTransmitted ||
                    this.BytesTransmitted != null &&
                    this.BytesTransmitted.Equals(other.BytesTransmitted)
                ) &&
                (
                    this.BaudRate == other.BaudRate ||
                    this.BaudRate != null &&
                    this.BaudRate.Equals(other.BaudRate)
                ) &&
                (
                    this.PageErrors == other.PageErrors ||
                    this.PageErrors != null &&
                    this.PageErrors.Equals(other.PageErrors)
                ) &&
                (
                    this.LineErrors == other.LineErrors ||
                    this.LineErrors != null &&
                    this.LineErrors.Equals(other.LineErrors)
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
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.ExpectedPages != null)
                    hash = hash * 59 + this.ExpectedPages.GetHashCode();

                if (this.ActivePage != null)
                    hash = hash * 59 + this.ActivePage.GetHashCode();

                if (this.LinesTransmitted != null)
                    hash = hash * 59 + this.LinesTransmitted.GetHashCode();

                if (this.BytesTransmitted != null)
                    hash = hash * 59 + this.BytesTransmitted.GetHashCode();

                if (this.BaudRate != null)
                    hash = hash * 59 + this.BaudRate.GetHashCode();

                if (this.PageErrors != null)
                    hash = hash * 59 + this.PageErrors.GetHashCode();

                if (this.LineErrors != null)
                    hash = hash * 59 + this.LineErrors.GetHashCode();

                return hash;
            }
        }
    }

}
