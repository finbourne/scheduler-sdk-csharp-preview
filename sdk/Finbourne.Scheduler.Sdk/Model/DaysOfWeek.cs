/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.591
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Scheduler.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Scheduler.Sdk.Model
{
    /// <summary>
    /// Days of the week
    /// </summary>
    /// <value>Days of the week</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DaysOfWeek
    {
        /// <summary>
        /// Enum Monday for value: Monday
        /// </summary>
        [EnumMember(Value = "Monday")]
        Monday = 1,

        /// <summary>
        /// Enum Tuesday for value: Tuesday
        /// </summary>
        [EnumMember(Value = "Tuesday")]
        Tuesday = 2,

        /// <summary>
        /// Enum Wednesday for value: Wednesday
        /// </summary>
        [EnumMember(Value = "Wednesday")]
        Wednesday = 3,

        /// <summary>
        /// Enum Thursday for value: Thursday
        /// </summary>
        [EnumMember(Value = "Thursday")]
        Thursday = 4,

        /// <summary>
        /// Enum Friday for value: Friday
        /// </summary>
        [EnumMember(Value = "Friday")]
        Friday = 5,

        /// <summary>
        /// Enum Saturday for value: Saturday
        /// </summary>
        [EnumMember(Value = "Saturday")]
        Saturday = 6,

        /// <summary>
        /// Enum Sunday for value: Sunday
        /// </summary>
        [EnumMember(Value = "Sunday")]
        Sunday = 7

    }

}
