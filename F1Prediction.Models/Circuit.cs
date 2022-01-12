using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    [DataContract]
    public class Circuit : IEquatable<Circuit>
    {
        /// <summary>
        /// Gets or Sets CircuitId
        /// </summary>

        [DataMember(Name = "circuitId")]
        public string CircuitId { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>

        [DataMember(Name = "round")]
        public string Round { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>

        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets CircuitName
        /// </summary>

        [DataMember(Name = "circuitName")]
        public string CircuitName { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>

        [DataMember(Name = "Location")]
        public CircuitLocation Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Circuit {\n");
            sb.Append("  CircuitId: ").Append(CircuitId).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CircuitName: ").Append(CircuitName).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Circuit)obj);
        }

        /// <summary>
        /// Returns true if Circuit instances are equal
        /// </summary>
        /// <param name="other">Instance of Circuit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Circuit other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    CircuitId == other.CircuitId ||
                    CircuitId != null &&
                    CircuitId.Equals(other.CircuitId)
                ) &&
                (
                    Round == other.Round ||
                    Round != null &&
                    Round.Equals(other.Round)
                ) &&
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) &&
                (
                    CircuitName == other.CircuitName ||
                    CircuitName != null &&
                    CircuitName.Equals(other.CircuitName)
                ) &&
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (CircuitId != null)
                    hashCode = hashCode * 59 + CircuitId.GetHashCode();
                if (Round != null)
                    hashCode = hashCode * 59 + Round.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (CircuitName != null)
                    hashCode = hashCode * 59 + CircuitName.GetHashCode();
                if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                return hashCode;
            }
        }
    }
}
