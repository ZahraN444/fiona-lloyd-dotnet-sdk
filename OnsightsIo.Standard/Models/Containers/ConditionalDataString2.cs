// <copyright file="ConditionalDataString2.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace OnsightsIo.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ConditionalDataString2>),
        new Type[] {
            typeof(ConditionalDataOkCase),
            typeof(ConditionalDataEmptyCase)
        },
        true
    )]
    public abstract class ConditionalDataString2
    {
        /// <summary>
        /// This is ConditionalDataOk case.
        /// </summary>
        /// <returns>
        /// The ConditionalDataString2 instance, wrapping the provided ConditionalDataOk value.
        /// </returns>
        public static ConditionalDataString2 FromConditionalDataOk(ConditionalDataOk conditionalDataOk)
        {
            return new ConditionalDataOkCase().Set(conditionalDataOk);
        }

        /// <summary>
        /// This is ConditionalDataEmpty case.
        /// </summary>
        /// <returns>
        /// The ConditionalDataString2 instance, wrapping the provided ConditionalDataEmpty value.
        /// </returns>
        public static ConditionalDataString2 FromConditionalDataEmpty(ConditionalDataEmpty conditionalDataEmpty)
        {
            return new ConditionalDataEmptyCase().Set(conditionalDataEmpty);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ConditionalDataOk, T> conditionalDataOk, Func<ConditionalDataEmpty, T> conditionalDataEmpty);

        [JsonConverter(typeof(UnionTypeCaseConverter<ConditionalDataOkCase, ConditionalDataOk>))]
        private sealed class ConditionalDataOkCase : ConditionalDataString2, ICaseValue<ConditionalDataOkCase, ConditionalDataOk>
        {
            public ConditionalDataOk _value;

            public override T Match<T>(Func<ConditionalDataOk, T> conditionalDataOk, Func<ConditionalDataEmpty, T> conditionalDataEmpty)
            {
                return conditionalDataOk(_value);
            }

            public ConditionalDataOkCase Set(ConditionalDataOk value)
            {
                _value = value;
                return this;
            }

            public ConditionalDataOk Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ConditionalDataEmptyCase, ConditionalDataEmpty>))]
        private sealed class ConditionalDataEmptyCase : ConditionalDataString2, ICaseValue<ConditionalDataEmptyCase, ConditionalDataEmpty>
        {
            public ConditionalDataEmpty _value;

            public override T Match<T>(Func<ConditionalDataOk, T> conditionalDataOk, Func<ConditionalDataEmpty, T> conditionalDataEmpty)
            {
                return conditionalDataEmpty(_value);
            }

            public ConditionalDataEmptyCase Set(ConditionalDataEmpty value)
            {
                _value = value;
                return this;
            }

            public ConditionalDataEmpty Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}