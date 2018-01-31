// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AutoUserScope.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoUserScope
    {
        [EnumMember(Value = "Task")]
        Task,
        [EnumMember(Value = "Pool")]
        Pool
    }
    internal static class AutoUserScopeEnumExtension
    {
        internal static string ToSerializedValue(this AutoUserScope? value)
        {
            return value == null ? null : ((AutoUserScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AutoUserScope value)
        {
            switch( value )
            {
                case AutoUserScope.Task:
                    return "Task";
                case AutoUserScope.Pool:
                    return "Pool";
            }
            return null;
        }

        internal static AutoUserScope? ParseAutoUserScope(this string value)
        {
            switch( value )
            {
                case "Task":
                    return AutoUserScope.Task;
                case "Pool":
                    return AutoUserScope.Pool;
            }
            return null;
        }
    }
}