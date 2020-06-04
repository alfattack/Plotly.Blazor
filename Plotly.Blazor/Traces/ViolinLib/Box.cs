/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ViolinLib
{
    /// <summary>
    ///     The Box class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Box : IEquatable<Box>
    {
        /// <summary>
        ///     Determines if an miniature box plot is drawn inside the violins. 
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the width of the inner box plots relative to the violins&#39; width.
        ///     For example, with 1, the inner box plots are as wide as the violins.
        /// </summary>
        [JsonPropertyName(@"width")]
        public decimal? Width { get; set;} 

        /// <summary>
        ///     Sets the inner box plot fill color.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.ViolinLib.BoxLib.Line Line { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Box other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Box other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Visible == other.Visible &&
                    Visible != null && other.Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    Width == other.Width &&
                    Width != null && other.Width != null &&
                    Width.Equals(other.Width)
                ) && 
                (
                    FillColor == other.FillColor &&
                    FillColor != null && other.FillColor != null &&
                    FillColor.Equals(other.FillColor)
                ) && 
                (
                    Line == other.Line &&
                    Line != null && other.Line != null &&
                    Line.Equals(other.Line)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                if (FillColor != null) hashCode = hashCode * 59 + FillColor.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Box and the right Box.
        /// </summary>
        /// <param name="left">Left Box.</param>
        /// <param name="right">Right Box.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Box left, Box right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Box and the right Box.
        /// </summary>
        /// <param name="left">Left Box.</param>
        /// <param name="right">Right Box.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Box left, Box right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Box</returns>
        public Box DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Box) formatter.Deserialize(ms);
        }
    }
}