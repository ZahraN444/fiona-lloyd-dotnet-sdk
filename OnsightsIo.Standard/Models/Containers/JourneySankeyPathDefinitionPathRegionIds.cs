// <copyright file="JourneySankeyPathDefinitionPathRegionIds.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace OnsightsIo.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<JourneySankeyPathDefinitionPathRegionIds>),
        new Type[] {
            typeof(UUIDCase),
            typeof(PathRegionIdCase)
        },
        true
    )]
    public abstract class JourneySankeyPathDefinitionPathRegionIds
    {
        /// <summary>
        /// This is UUID case.
        /// </summary>
        /// <returns>
        /// The JourneySankeyPathDefinitionPathRegionIds instance, wrapping the provided Guid value.
        /// </returns>
        public static JourneySankeyPathDefinitionPathRegionIds FromUUID(Guid uUID)
        {
            return new UUIDCase().Set(uUID);
        }

        /// <summary>
        /// This is PathRegionId case.
        /// </summary>
        /// <returns>
        /// The JourneySankeyPathDefinitionPathRegionIds instance, wrapping the provided PathRegionIdEnum value.
        /// </returns>
        public static JourneySankeyPathDefinitionPathRegionIds FromPathRegionId(PathRegionIdEnum pathRegionId)
        {
            return new PathRegionIdCase().Set(pathRegionId);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<Guid, T> uUID, Func<PathRegionIdEnum, T> pathRegionId);

        [JsonConverter(typeof(UnionTypeCaseConverter<UUIDCase, Guid>), JTokenType.Guid)]
        private sealed class UUIDCase : JourneySankeyPathDefinitionPathRegionIds, ICaseValue<UUIDCase, Guid>
        {
            public Guid _value;

            public override T Match<T>(Func<Guid, T> uUID, Func<PathRegionIdEnum, T> pathRegionId)
            {
                return uUID(_value);
            }

            public UUIDCase Set(Guid value)
            {
                _value = value;
                return this;
            }

            public Guid Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PathRegionIdCase, PathRegionIdEnum>))]
        private sealed class PathRegionIdCase : JourneySankeyPathDefinitionPathRegionIds, ICaseValue<PathRegionIdCase, PathRegionIdEnum>
        {
            public PathRegionIdEnum _value;

            public override T Match<T>(Func<Guid, T> uUID, Func<PathRegionIdEnum, T> pathRegionId)
            {
                return pathRegionId(_value);
            }

            public PathRegionIdCase Set(PathRegionIdEnum value)
            {
                _value = value;
                return this;
            }

            public PathRegionIdEnum Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }
    }
}