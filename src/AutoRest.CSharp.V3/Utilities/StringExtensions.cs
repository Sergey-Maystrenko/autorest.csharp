﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CaseExtensions;

namespace AutoRest.CSharp.V3.Utilities
{
    internal static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string? text) => String.IsNullOrEmpty(text);
        public static bool IsNullOrWhiteSpace(this string? text) => String.IsNullOrWhiteSpace(text);
        public static string? NullIfEmpty(this string? text) => text.IsNullOrEmpty() ? null : text;
        public static string? NullIfWhiteSpace(this string? text) => text.IsNullOrWhiteSpace() ? null : text;
        public static string? EmptyIfNull(this string? text) => text ?? String.Empty;

        public static string JoinIgnoreEmpty(this IEnumerable<string?> values, string? separator) => String.Join(separator, values.Where(v => !v.IsNullOrEmpty()));

        [return: NotNullIfNotNull("text")]
        public static string? RemoveNonWordCharacters(this string? text) => !text.IsNullOrEmpty() ? Regex.Replace(text, @"\W+", String.Empty) : text;
        [return: NotNullIfNotNull("text")]
        public static string? RemoveMiddleDotCharacters(this string? text) => text?.Replace("·", String.Empty);
        [return: NotNullIfNotNull("name")]
        public static string? ToCleanName(this string? name) => name?.ToPascalCase().RemoveMiddleDotCharacters();

        //https://stackoverflow.com/a/41176852/294804
        public static IEnumerable<string> ToLines(this string value, bool removeEmptyLines = false)
        {
            using var sr = new StringReader(value);
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                if (removeEmptyLines && String.IsNullOrWhiteSpace(line)) continue;
                yield return line;
            }
        }
    }
}