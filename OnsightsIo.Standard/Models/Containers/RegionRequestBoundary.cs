// <copyright file="RegionRequestBoundary.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<RegionRequestBoundary>),
        new Type[] {
            typeof(LineRepresentationCase),
            typeof(PointRepresentationCase),
            typeof(PolygonRepresentationCase),
            typeof(PolylineRepresentationCase)
        },
        true
    )]
    public abstract class RegionRequestBoundary
    {
        /// <summary>
        /// This is LineRepresentation case.
        /// </summary>
        /// <returns>
        /// The RegionRequestBoundary instance, wrapping the provided LineRepresentation value.
        /// </returns>
        public static RegionRequestBoundary FromLineRepresentation(LineRepresentation lineRepresentation)
        {
            return new LineRepresentationCase().Set(lineRepresentation);
        }

        /// <summary>
        /// This is PointRepresentation case.
        /// </summary>
        /// <returns>
        /// The RegionRequestBoundary instance, wrapping the provided PointRepresentation value.
        /// </returns>
        public static RegionRequestBoundary FromPointRepresentation(PointRepresentation pointRepresentation)
        {
            return new PointRepresentationCase().Set(pointRepresentation);
        }

        /// <summary>
        /// This is PolygonRepresentation case.
        /// </summary>
        /// <returns>
        /// The RegionRequestBoundary instance, wrapping the provided PolygonRepresentation value.
        /// </returns>
        public static RegionRequestBoundary FromPolygonRepresentation(PolygonRepresentation polygonRepresentation)
        {
            return new PolygonRepresentationCase().Set(polygonRepresentation);
        }

        /// <summary>
        /// This is PolylineRepresentation case.
        /// </summary>
        /// <returns>
        /// The RegionRequestBoundary instance, wrapping the provided PolylineRepresentation value.
        /// </returns>
        public static RegionRequestBoundary FromPolylineRepresentation(PolylineRepresentation polylineRepresentation)
        {
            return new PolylineRepresentationCase().Set(polylineRepresentation);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<LineRepresentation, T> lineRepresentation,
            Func<PointRepresentation, T> pointRepresentation,
            Func<PolygonRepresentation, T> polygonRepresentation,
            Func<PolylineRepresentation, T> polylineRepresentation);

        [JsonConverter(typeof(UnionTypeCaseConverter<LineRepresentationCase, LineRepresentation>))]
        private sealed class LineRepresentationCase : RegionRequestBoundary, ICaseValue<LineRepresentationCase, LineRepresentation>
        {
            public LineRepresentation _value;

            public override T Match<T>(
                Func<LineRepresentation, T> lineRepresentation,
                Func<PointRepresentation, T> pointRepresentation,
                Func<PolygonRepresentation, T> polygonRepresentation,
                Func<PolylineRepresentation, T> polylineRepresentation)
            {
                return lineRepresentation(_value);
            }

            public LineRepresentationCase Set(LineRepresentation value)
            {
                _value = value;
                return this;
            }

            public LineRepresentation Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PointRepresentationCase, PointRepresentation>))]
        private sealed class PointRepresentationCase : RegionRequestBoundary, ICaseValue<PointRepresentationCase, PointRepresentation>
        {
            public PointRepresentation _value;

            public override T Match<T>(
                Func<LineRepresentation, T> lineRepresentation,
                Func<PointRepresentation, T> pointRepresentation,
                Func<PolygonRepresentation, T> polygonRepresentation,
                Func<PolylineRepresentation, T> polylineRepresentation)
            {
                return pointRepresentation(_value);
            }

            public PointRepresentationCase Set(PointRepresentation value)
            {
                _value = value;
                return this;
            }

            public PointRepresentation Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PolygonRepresentationCase, PolygonRepresentation>))]
        private sealed class PolygonRepresentationCase : RegionRequestBoundary, ICaseValue<PolygonRepresentationCase, PolygonRepresentation>
        {
            public PolygonRepresentation _value;

            public override T Match<T>(
                Func<LineRepresentation, T> lineRepresentation,
                Func<PointRepresentation, T> pointRepresentation,
                Func<PolygonRepresentation, T> polygonRepresentation,
                Func<PolylineRepresentation, T> polylineRepresentation)
            {
                return polygonRepresentation(_value);
            }

            public PolygonRepresentationCase Set(PolygonRepresentation value)
            {
                _value = value;
                return this;
            }

            public PolygonRepresentation Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PolylineRepresentationCase, PolylineRepresentation>))]
        private sealed class PolylineRepresentationCase : RegionRequestBoundary, ICaseValue<PolylineRepresentationCase, PolylineRepresentation>
        {
            public PolylineRepresentation _value;

            public override T Match<T>(
                Func<LineRepresentation, T> lineRepresentation,
                Func<PointRepresentation, T> pointRepresentation,
                Func<PolygonRepresentation, T> polygonRepresentation,
                Func<PolylineRepresentation, T> polylineRepresentation)
            {
                return polylineRepresentation(_value);
            }

            public PolylineRepresentationCase Set(PolylineRepresentation value)
            {
                _value = value;
                return this;
            }

            public PolylineRepresentation Get()
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