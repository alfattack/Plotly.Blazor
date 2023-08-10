/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ScatterGeoLib.MarkerLib.ColorBarLib
{
    /// <summary>
    ///     Sets the container <c>y</c> refers to. <c>container</c> spans the entire
    ///     <c>height</c> of the plot. <c>paper</c> refers to the height of the plotting
    ///     area only.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YRefEnum
    {
        [EnumMember(Value=@"paper")]
        Paper = 0,
        [EnumMember(Value=@"container")]
        Container
    }
}