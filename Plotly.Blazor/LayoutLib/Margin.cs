/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Margin class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Margin : IEquatable<Margin>
    {
        /// <summary>
        ///     Sets the left margin (in px).
        /// </summary>
        [JsonPropertyName(@"l")]
        public decimal? L { get; set;} 

        /// <summary>
        ///     Sets the right margin (in px).
        /// </summary>
        [JsonPropertyName(@"r")]
        public decimal? R { get; set;} 

        /// <summary>
        ///     Sets the top margin (in px).
        /// </summary>
        [JsonPropertyName(@"t")]
        public decimal? T { get; set;} 

        /// <summary>
        ///     Sets the bottom margin (in px).
        /// </summary>
        [JsonPropertyName(@"b")]
        public decimal? B { get; set;} 

        /// <summary>
        ///     Sets the amount of padding (in px) between the plotting area and the axis
        ///     lines
        /// </summary>
        [JsonPropertyName(@"pad")]
        public decimal? Pad { get; set;} 

        /// <summary>
        ///     Turns on/off margin expansion computations. Legends, colorbars, updatemenus,
        ///     sliders, axis rangeselector and rangeslider are allowed to push the margins
        ///     by defaults.
        /// </summary>
        [JsonPropertyName(@"autoexpand")]
        public bool? AutoExpand { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Margin other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Margin other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    L == other.L &&
                    L != null && other.L != null &&
                    L.Equals(other.L)
                ) && 
                (
                    R == other.R &&
                    R != null && other.R != null &&
                    R.Equals(other.R)
                ) && 
                (
                    T == other.T &&
                    T != null && other.T != null &&
                    T.Equals(other.T)
                ) && 
                (
                    B == other.B &&
                    B != null && other.B != null &&
                    B.Equals(other.B)
                ) && 
                (
                    Pad == other.Pad &&
                    Pad != null && other.Pad != null &&
                    Pad.Equals(other.Pad)
                ) && 
                (
                    AutoExpand == other.AutoExpand &&
                    AutoExpand != null && other.AutoExpand != null &&
                    AutoExpand.Equals(other.AutoExpand)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (L != null) hashCode = hashCode * 59 + L.GetHashCode();
                if (R != null) hashCode = hashCode * 59 + R.GetHashCode();
                if (T != null) hashCode = hashCode * 59 + T.GetHashCode();
                if (B != null) hashCode = hashCode * 59 + B.GetHashCode();
                if (Pad != null) hashCode = hashCode * 59 + Pad.GetHashCode();
                if (AutoExpand != null) hashCode = hashCode * 59 + AutoExpand.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Margin and the right Margin.
        /// </summary>
        /// <param name="left">Left Margin.</param>
        /// <param name="right">Right Margin.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Margin left, Margin right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Margin and the right Margin.
        /// </summary>
        /// <param name="left">Left Margin.</param>
        /// <param name="right">Right Margin.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Margin left, Margin right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Margin</returns>
        public Margin DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Margin) formatter.Deserialize(ms);
        }
    }
}