// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SubtaskState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubtaskState
    {
        /// <summary>
        /// The Task has been assigned to a Compute Node, but is waiting for a
        /// required Job Preparation Task to complete on the Compute Node. If
        /// the Job Preparation Task succeeds, the Task will move to running.
        /// If the Job Preparation Task fails, the Task will return to active
        /// and will be eligible to be assigned to a different Compute Node.
        /// </summary>
        [EnumMember(Value = "preparing")]
        Preparing,
        /// <summary>
        /// The Task is running on a Compute Node. This includes task-level
        /// preparation such as downloading resource files or deploying
        /// Packages specified on the Task - it does not necessarily mean that
        /// the Task command line has started executing.
        /// </summary>
        [EnumMember(Value = "running")]
        Running,
        /// <summary>
        /// The Task is no longer eligible to run, usually because the Task has
        /// finished successfully, or the Task has finished unsuccessfully and
        /// has exhausted its retry limit. A Task is also marked as completed
        /// if an error occurred launching the Task, or when the Task has been
        /// terminated.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed
    }
    internal static class SubtaskStateEnumExtension
    {
        internal static string ToSerializedValue(this SubtaskState? value)
        {
            return value == null ? null : ((SubtaskState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SubtaskState value)
        {
            switch( value )
            {
                case SubtaskState.Preparing:
                    return "preparing";
                case SubtaskState.Running:
                    return "running";
                case SubtaskState.Completed:
                    return "completed";
            }
            return null;
        }

        internal static SubtaskState? ParseSubtaskState(this string value)
        {
            switch( value )
            {
                case "preparing":
                    return SubtaskState.Preparing;
                case "running":
                    return SubtaskState.Running;
                case "completed":
                    return SubtaskState.Completed;
            }
            return null;
        }
    }
}
