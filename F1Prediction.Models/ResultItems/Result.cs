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
    public class Result
    {
        /// <summary>
        /// Gets or Sets Number
        /// </summary>

        [DataMember(Name = "number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>

        [DataMember(Name = "position")]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets PositionText
        /// </summary>

        [DataMember(Name = "positionText")]
        public string PositionText { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>

        [DataMember(Name = "points")]
        public string Points { get; set; }

        /// <summary>
        /// Gets or Sets Driver
        /// </summary>

        [DataMember(Name = "Driver")]
        public Driver Driver { get; set; }

        /// <summary>
        /// Gets or Sets Constructor
        /// </summary>

        [DataMember(Name = "Constructor")]
        public Constructor Constructor { get; set; }

        /// <summary>
        /// Gets or Sets Grid
        /// </summary>

        [DataMember(Name = "grid")]
        public string Grid { get; set; }

        /// <summary>
        /// Gets or Sets Laps
        /// </summary>

        [DataMember(Name = "laps")]
        public string Laps { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>

        [DataMember(Name = "Time")]
        public ResultTime Time { get; set; }

        /// <summary>
        /// Gets or Sets FastestLap
        /// </summary>

        [DataMember(Name = "FastestLap")]
        public ResultFastestLap FastestLap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Result {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  PositionText: ").Append(PositionText).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
            sb.Append("  Constructor: ").Append(Constructor).Append("\n");
            sb.Append("  Grid: ").Append(Grid).Append("\n");
            sb.Append("  Laps: ").Append(Laps).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  FastestLap: ").Append(FastestLap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
            return obj.GetType() == GetType() && Equals((Result)obj);
        }

        /// <summary>
        /// Returns true if Result instances are equal
        /// </summary>
        /// <param name="other">Instance of Result to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Result other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
                ) &&
                (
                    Position == other.Position ||
                    Position != null &&
                    Position.Equals(other.Position)
                ) &&
                (
                    PositionText == other.PositionText ||
                    PositionText != null &&
                    PositionText.Equals(other.PositionText)
                ) &&
                (
                    Points == other.Points ||
                    Points != null &&
                    Points.Equals(other.Points)
                ) &&
                (
                    Driver == other.Driver ||
                    Driver != null &&
                    Driver.Equals(other.Driver)
                ) &&
                (
                    Constructor == other.Constructor ||
                    Constructor != null &&
                    Constructor.Equals(other.Constructor)
                ) &&
                (
                    Grid == other.Grid ||
                    Grid != null &&
                    Grid.Equals(other.Grid)
                ) &&
                (
                    Laps == other.Laps ||
                    Laps != null &&
                    Laps.Equals(other.Laps)
                ) &&
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) &&
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                ) &&
                (
                    FastestLap == other.FastestLap ||
                    FastestLap != null &&
                    FastestLap.Equals(other.FastestLap)
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
                if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                if (Position != null)
                    hashCode = hashCode * 59 + Position.GetHashCode();
                if (PositionText != null)
                    hashCode = hashCode * 59 + PositionText.GetHashCode();
                if (Points != null)
                    hashCode = hashCode * 59 + Points.GetHashCode();
                if (Driver != null)
                    hashCode = hashCode * 59 + Driver.GetHashCode();
                if (Constructor != null)
                    hashCode = hashCode * 59 + Constructor.GetHashCode();
                if (Grid != null)
                    hashCode = hashCode * 59 + Grid.GetHashCode();
                if (Laps != null)
                    hashCode = hashCode * 59 + Laps.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                if (FastestLap != null)
                    hashCode = hashCode * 59 + FastestLap.GetHashCode();
                return hashCode;
            }
        }
    }
}
