// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    internal static class VisualFeatureExtensions
    {
        public static string ToSerialString(this VisualFeature value) => value switch
        {
            VisualFeature.Categories => "categories",
            VisualFeature.Tags => "tags",
            VisualFeature.Description => "description",
            VisualFeature.Faces => "faces",
            VisualFeature.ImageType => "imageType",
            VisualFeature.Color => "color",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VisualFeature value.")
        };

        public static VisualFeature ToVisualFeature(this string value) => value switch
        {
            "categories" => VisualFeature.Categories,
            "tags" => VisualFeature.Tags,
            "description" => VisualFeature.Description,
            "faces" => VisualFeature.Faces,
            "imageType" => VisualFeature.ImageType,
            "color" => VisualFeature.Color,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VisualFeature value.")
        };
    }
}