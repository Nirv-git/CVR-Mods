﻿using System;
using Wasmtime;
namespace WasmLoader.Refs
{
    public class SystemString_Ref : IRef
    {
        public void Setup(Linker linker, Store store, Objectstore objects)
        {
            linker.DefineFunction("env", "System_String__Join_SystemString_SystemString[]__SystemString", (Caller caller, System.Int32 separator, System.Int32 value) => {
                var resolved_separator = objects.RetriveObject<System.String>(separator, caller);
                var resolved_value = objects.RetriveObject<System.String[]>(value, caller);
                var result = System.String.Join(resolved_separator, resolved_value);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Join_SystemString_SystemObject[]__SystemString", (Caller caller, System.Int32 separator, System.Int32 values) => {
                var resolved_separator = objects.RetriveObject<System.String>(separator, caller);
                var resolved_values = objects.RetriveObject<System.Object[]>(values, caller);
                var result = System.String.Join(resolved_separator, resolved_values);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Join_SystemString_SystemString[]_SystemInt32_SystemInt32__SystemString", (Caller caller, System.Int32 separator, System.Int32 value, System.Int32 startIndex, System.Int32 count) => {
                var resolved_separator = objects.RetriveObject<System.String>(separator, caller);
                var resolved_value = objects.RetriveObject<System.String[]>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = System.String.Join(resolved_separator, resolved_value, startIndex, count);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Equals_this_SystemObject__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 obj) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_obj = objects.RetriveObject<System.Object>(obj, caller);
                var result = resolved_this.Equals(resolved_obj);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Equals_this_SystemString__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = resolved_this.Equals(resolved_value);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Equals_this_SystemString_SystemStringComparison__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.Equals(resolved_value, resolved_comparisonType);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Equals_SystemString_SystemString__SystemBoolean", (Caller caller, System.Int32 a, System.Int32 b) => {
                var resolved_a = objects.RetriveObject<System.String>(a, caller);
                var resolved_b = objects.RetriveObject<System.String>(b, caller);
                var result = System.String.Equals(resolved_a, resolved_b);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Equals_SystemString_SystemString_SystemStringComparison__SystemBoolean", (Caller caller, System.Int32 a, System.Int32 b, System.Int32 comparisonType) => {
                var resolved_a = objects.RetriveObject<System.String>(a, caller);
                var resolved_b = objects.RetriveObject<System.String>(b, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = System.String.Equals(resolved_a, resolved_b, resolved_comparisonType);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__op_Equality_SystemString_SystemString__SystemBoolean", (Caller caller, System.Int32 a, System.Int32 b) => {
                var resolved_a = objects.RetriveObject<System.String>(a, caller);
                var resolved_b = objects.RetriveObject<System.String>(b, caller);
                var result = resolved_a == resolved_b;
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__op_Inequality_SystemString_SystemString__SystemBoolean", (Caller caller, System.Int32 a, System.Int32 b) => {
                var resolved_a = objects.RetriveObject<System.String>(a, caller);
                var resolved_b = objects.RetriveObject<System.String>(b, caller);
                var result = resolved_a != resolved_b;
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__CopyTo_this_SystemInt32_SystemChar[]_SystemInt32_SystemInt32__SystemVoid", (Caller caller, System.Int32 parameter_this, System.Int32 sourceIndex, System.Int32 destination, System.Int32 destinationIndex, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_sourceIndex = objects.RetriveObject<System.Int32>(sourceIndex, caller);
                var resolved_destination = objects.RetriveObject<System.Char[]>(destination, caller);
                var resolved_destinationIndex = objects.RetriveObject<System.Int32>(destinationIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                resolved_this.CopyTo(sourceIndex, resolved_destination, destinationIndex, count);

            });

            linker.DefineFunction("env", "System_String__ToCharArray_this__SystemChar[]", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.ToCharArray();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToCharArray_this_SystemInt32_SystemInt32__SystemChar[]", (Caller caller, System.Int32 parameter_this, System.Int32 startIndex, System.Int32 length) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_length = objects.RetriveObject<System.Int32>(length, caller);
                var result = resolved_this.ToCharArray(startIndex, length);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__IsNullOrEmpty_SystemString__SystemBoolean", (Caller caller, System.Int32 value) => {
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = System.String.IsNullOrEmpty(resolved_value);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__IsNullOrWhiteSpace_SystemString__SystemBoolean", (Caller caller, System.Int32 value) => {
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = System.String.IsNullOrWhiteSpace(resolved_value);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__GetHashCode_this__SystemInt32", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.GetHashCode();
                return result;
            });

            linker.DefineFunction("env", "System_String__Split_this_SystemChar[]__SystemString[]", (Caller caller, System.Int32 parameter_this, System.Int32 separator) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_separator = objects.RetriveObject<System.Char[]>(separator, caller);
                var result = resolved_this.Split(resolved_separator);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Split_this_SystemChar[]_SystemInt32__SystemString[]", (Caller caller, System.Int32 parameter_this, System.Int32 separator, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_separator = objects.RetriveObject<System.Char[]>(separator, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = resolved_this.Split(resolved_separator, count);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Split_this_SystemChar[]_SystemStringSplitOptions__SystemString[]", (Caller caller, System.Int32 parameter_this, System.Int32 separator, System.Int32 options) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_separator = objects.RetriveObject<System.Char[]>(separator, caller);
                var resolved_options = objects.RetriveObject<System.StringSplitOptions>(options, caller);
                var result = resolved_this.Split(resolved_separator, resolved_options);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Split_this_SystemChar[]_SystemInt32_SystemStringSplitOptions__SystemString[]", (Caller caller, System.Int32 parameter_this, System.Int32 separator, System.Int32 count, System.Int32 options) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_separator = objects.RetriveObject<System.Char[]>(separator, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var resolved_options = objects.RetriveObject<System.StringSplitOptions>(options, caller);
                var result = resolved_this.Split(resolved_separator, count, resolved_options);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Split_this_SystemString[]_SystemStringSplitOptions__SystemString[]", (Caller caller, System.Int32 parameter_this, System.Int32 separator, System.Int32 options) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_separator = objects.RetriveObject<System.String[]>(separator, caller);
                var resolved_options = objects.RetriveObject<System.StringSplitOptions>(options, caller);
                var result = resolved_this.Split(resolved_separator, resolved_options);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Split_this_SystemString[]_SystemInt32_SystemStringSplitOptions__SystemString[]", (Caller caller, System.Int32 parameter_this, System.Int32 separator, System.Int32 count, System.Int32 options) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_separator = objects.RetriveObject<System.String[]>(separator, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var resolved_options = objects.RetriveObject<System.StringSplitOptions>(options, caller);
                var result = resolved_this.Split(resolved_separator, count, resolved_options);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Substring_this_SystemInt32__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 startIndex) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var result = resolved_this.Substring(startIndex);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Substring_this_SystemInt32_SystemInt32__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 startIndex, System.Int32 length) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_length = objects.RetriveObject<System.Int32>(length, caller);
                var result = resolved_this.Substring(startIndex, length);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Trim_this_SystemChar[]__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 trimChars) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_trimChars = objects.RetriveObject<System.Char[]>(trimChars, caller);
                var result = resolved_this.Trim(resolved_trimChars);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__TrimStart_this_SystemChar[]__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 trimChars) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_trimChars = objects.RetriveObject<System.Char[]>(trimChars, caller);
                var result = resolved_this.TrimStart(resolved_trimChars);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__TrimEnd_this_SystemChar[]__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 trimChars) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_trimChars = objects.RetriveObject<System.Char[]>(trimChars, caller);
                var result = resolved_this.TrimEnd(resolved_trimChars);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__IsNormalized_this__SystemBoolean", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.IsNormalized();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__IsNormalized_this_SystemTextNormalizationForm__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 normalizationForm) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_normalizationForm = objects.RetriveObject<System.Text.NormalizationForm>(normalizationForm, caller);
                var result = resolved_this.IsNormalized(resolved_normalizationForm);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Normalize_this__SystemString", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.Normalize();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Normalize_this_SystemTextNormalizationForm__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 normalizationForm) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_normalizationForm = objects.RetriveObject<System.Text.NormalizationForm>(normalizationForm, caller);
                var result = resolved_this.Normalize(resolved_normalizationForm);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemString__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 strB) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var result = System.String.Compare(resolved_strA, resolved_strB);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemString_SystemBoolean__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 strB, System.Int32 ignoreCase) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_ignoreCase = objects.RetriveObject<System.Boolean>(ignoreCase, caller);
                var result = System.String.Compare(resolved_strA, resolved_strB, resolved_ignoreCase);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemString_SystemStringComparison__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 strB, System.Int32 comparisonType) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = System.String.Compare(resolved_strA, resolved_strB, resolved_comparisonType);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemString_SystemGlobalizationCultureInfo_SystemGlobalizationCompareOptions__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 strB, System.Int32 culture, System.Int32 options) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_culture = objects.RetriveObject<System.Globalization.CultureInfo>(culture, caller);
                var resolved_options = objects.RetriveObject<System.Globalization.CompareOptions>(options, caller);
                var result = System.String.Compare(resolved_strA, resolved_strB, resolved_culture, resolved_options);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemString_SystemBoolean_SystemGlobalizationCultureInfo__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 strB, System.Int32 ignoreCase, System.Int32 culture) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_ignoreCase = objects.RetriveObject<System.Boolean>(ignoreCase, caller);
                var resolved_culture = objects.RetriveObject<System.Globalization.CultureInfo>(culture, caller);
                var result = System.String.Compare(resolved_strA, resolved_strB, resolved_ignoreCase, resolved_culture);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemInt32_SystemString_SystemInt32_SystemInt32__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 indexA, System.Int32 strB, System.Int32 indexB, System.Int32 length) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_indexA = objects.RetriveObject<System.Int32>(indexA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_indexB = objects.RetriveObject<System.Int32>(indexB, caller);
                var resolved_length = objects.RetriveObject<System.Int32>(length, caller);
                var result = System.String.Compare(resolved_strA, indexA, resolved_strB, indexB, length);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemInt32_SystemString_SystemInt32_SystemInt32_SystemBoolean__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 indexA, System.Int32 strB, System.Int32 indexB, System.Int32 length, System.Int32 ignoreCase) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_indexA = objects.RetriveObject<System.Int32>(indexA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_indexB = objects.RetriveObject<System.Int32>(indexB, caller);
                var resolved_length = objects.RetriveObject<System.Int32>(length, caller);
                var resolved_ignoreCase = objects.RetriveObject<System.Boolean>(ignoreCase, caller);
                var result = System.String.Compare(resolved_strA, indexA, resolved_strB, indexB, length, resolved_ignoreCase);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemInt32_SystemString_SystemInt32_SystemInt32_SystemBoolean_SystemGlobalizationCultureInfo__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 indexA, System.Int32 strB, System.Int32 indexB, System.Int32 length, System.Int32 ignoreCase, System.Int32 culture) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_indexA = objects.RetriveObject<System.Int32>(indexA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_indexB = objects.RetriveObject<System.Int32>(indexB, caller);
                var resolved_length = objects.RetriveObject<System.Int32>(length, caller);
                var resolved_ignoreCase = objects.RetriveObject<System.Boolean>(ignoreCase, caller);
                var resolved_culture = objects.RetriveObject<System.Globalization.CultureInfo>(culture, caller);
                var result = System.String.Compare(resolved_strA, indexA, resolved_strB, indexB, length, resolved_ignoreCase, resolved_culture);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemInt32_SystemString_SystemInt32_SystemInt32_SystemGlobalizationCultureInfo_SystemGlobalizationCompareOptions__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 indexA, System.Int32 strB, System.Int32 indexB, System.Int32 length, System.Int32 culture, System.Int32 options) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_indexA = objects.RetriveObject<System.Int32>(indexA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_indexB = objects.RetriveObject<System.Int32>(indexB, caller);
                var resolved_length = objects.RetriveObject<System.Int32>(length, caller);
                var resolved_culture = objects.RetriveObject<System.Globalization.CultureInfo>(culture, caller);
                var resolved_options = objects.RetriveObject<System.Globalization.CompareOptions>(options, caller);
                var result = System.String.Compare(resolved_strA, indexA, resolved_strB, indexB, length, resolved_culture, resolved_options);
                return result;
            });

            linker.DefineFunction("env", "System_String__Compare_SystemString_SystemInt32_SystemString_SystemInt32_SystemInt32_SystemStringComparison__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 indexA, System.Int32 strB, System.Int32 indexB, System.Int32 length, System.Int32 comparisonType) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_indexA = objects.RetriveObject<System.Int32>(indexA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_indexB = objects.RetriveObject<System.Int32>(indexB, caller);
                var resolved_length = objects.RetriveObject<System.Int32>(length, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = System.String.Compare(resolved_strA, indexA, resolved_strB, indexB, length, resolved_comparisonType);
                return result;
            });

            linker.DefineFunction("env", "System_String__CompareTo_this_SystemObject__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.Object>(value, caller);
                var result = resolved_this.CompareTo(resolved_value);
                return result;
            });

            linker.DefineFunction("env", "System_String__CompareTo_this_SystemString__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 strB) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var result = resolved_this.CompareTo(resolved_strB);
                return result;
            });

            linker.DefineFunction("env", "System_String__CompareOrdinal_SystemString_SystemString__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 strB) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var result = System.String.CompareOrdinal(resolved_strA, resolved_strB);
                return result;
            });

            linker.DefineFunction("env", "System_String__CompareOrdinal_SystemString_SystemInt32_SystemString_SystemInt32_SystemInt32__SystemInt32", (Caller caller, System.Int32 strA, System.Int32 indexA, System.Int32 strB, System.Int32 indexB, System.Int32 length) => {
                var resolved_strA = objects.RetriveObject<System.String>(strA, caller);
                var resolved_indexA = objects.RetriveObject<System.Int32>(indexA, caller);
                var resolved_strB = objects.RetriveObject<System.String>(strB, caller);
                var resolved_indexB = objects.RetriveObject<System.Int32>(indexB, caller);
                var resolved_length = objects.RetriveObject<System.Int32>(length, caller);
                var result = System.String.CompareOrdinal(resolved_strA, indexA, resolved_strB, indexB, length);
                return result;
            });

            linker.DefineFunction("env", "System_String__Contains_this_SystemString__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = resolved_this.Contains(resolved_value);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__EndsWith_this_SystemString__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = resolved_this.EndsWith(resolved_value);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__EndsWith_this_SystemString_SystemStringComparison__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.EndsWith(resolved_value, resolved_comparisonType);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__EndsWith_this_SystemString_SystemBoolean_SystemGlobalizationCultureInfo__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 ignoreCase, System.Int32 culture) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_ignoreCase = objects.RetriveObject<System.Boolean>(ignoreCase, caller);
                var resolved_culture = objects.RetriveObject<System.Globalization.CultureInfo>(culture, caller);
                var result = resolved_this.EndsWith(resolved_value, resolved_ignoreCase, resolved_culture);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemChar__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.Char>(value, caller);
                var result = resolved_this.IndexOf(resolved_value);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemChar_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.Char>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var result = resolved_this.IndexOf(resolved_value, startIndex);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOfAny_this_SystemChar[]__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 anyOf) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_anyOf = objects.RetriveObject<System.Char[]>(anyOf, caller);
                var result = resolved_this.IndexOfAny(resolved_anyOf);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOfAny_this_SystemChar[]_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 anyOf, System.Int32 startIndex) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_anyOf = objects.RetriveObject<System.Char[]>(anyOf, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var result = resolved_this.IndexOfAny(resolved_anyOf, startIndex);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemString__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = resolved_this.IndexOf(resolved_value);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemString_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var result = resolved_this.IndexOf(resolved_value, startIndex);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemString_SystemInt32_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = resolved_this.IndexOf(resolved_value, startIndex, count);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemString_SystemStringComparison__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.IndexOf(resolved_value, resolved_comparisonType);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemString_SystemInt32_SystemStringComparison__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.IndexOf(resolved_value, startIndex, resolved_comparisonType);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemString_SystemInt32_SystemInt32_SystemStringComparison__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex, System.Int32 count, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.IndexOf(resolved_value, startIndex, count, resolved_comparisonType);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemChar__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.Char>(value, caller);
                var result = resolved_this.LastIndexOf(resolved_value);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemChar_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.Char>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var result = resolved_this.LastIndexOf(resolved_value, startIndex);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOfAny_this_SystemChar[]__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 anyOf) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_anyOf = objects.RetriveObject<System.Char[]>(anyOf, caller);
                var result = resolved_this.LastIndexOfAny(resolved_anyOf);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOfAny_this_SystemChar[]_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 anyOf, System.Int32 startIndex) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_anyOf = objects.RetriveObject<System.Char[]>(anyOf, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var result = resolved_this.LastIndexOfAny(resolved_anyOf, startIndex);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemString__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = resolved_this.LastIndexOf(resolved_value);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemString_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var result = resolved_this.LastIndexOf(resolved_value, startIndex);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemString_SystemInt32_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = resolved_this.LastIndexOf(resolved_value, startIndex, count);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemString_SystemStringComparison__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.LastIndexOf(resolved_value, resolved_comparisonType);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemString_SystemInt32_SystemStringComparison__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.LastIndexOf(resolved_value, startIndex, resolved_comparisonType);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemString_SystemInt32_SystemInt32_SystemStringComparison__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex, System.Int32 count, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.LastIndexOf(resolved_value, startIndex, count, resolved_comparisonType);
                return result;
            });

            linker.DefineFunction("env", "System_String__PadLeft_this_SystemInt32__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 totalWidth) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_totalWidth = objects.RetriveObject<System.Int32>(totalWidth, caller);
                var result = resolved_this.PadLeft(totalWidth);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__PadLeft_this_SystemInt32_SystemChar__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 totalWidth, System.Int32 paddingChar) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_totalWidth = objects.RetriveObject<System.Int32>(totalWidth, caller);
                var resolved_paddingChar = objects.RetriveObject<System.Char>(paddingChar, caller);
                var result = resolved_this.PadLeft(totalWidth, resolved_paddingChar);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__PadRight_this_SystemInt32__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 totalWidth) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_totalWidth = objects.RetriveObject<System.Int32>(totalWidth, caller);
                var result = resolved_this.PadRight(totalWidth);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__PadRight_this_SystemInt32_SystemChar__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 totalWidth, System.Int32 paddingChar) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_totalWidth = objects.RetriveObject<System.Int32>(totalWidth, caller);
                var resolved_paddingChar = objects.RetriveObject<System.Char>(paddingChar, caller);
                var result = resolved_this.PadRight(totalWidth, resolved_paddingChar);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__StartsWith_this_SystemString__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = resolved_this.StartsWith(resolved_value);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__StartsWith_this_SystemString_SystemStringComparison__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 comparisonType) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_comparisonType = objects.RetriveObject<System.StringComparison>(comparisonType, caller);
                var result = resolved_this.StartsWith(resolved_value, resolved_comparisonType);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__StartsWith_this_SystemString_SystemBoolean_SystemGlobalizationCultureInfo__SystemBoolean", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 ignoreCase, System.Int32 culture) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var resolved_ignoreCase = objects.RetriveObject<System.Boolean>(ignoreCase, caller);
                var resolved_culture = objects.RetriveObject<System.Globalization.CultureInfo>(culture, caller);
                var result = resolved_this.StartsWith(resolved_value, resolved_ignoreCase, resolved_culture);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToLower_this__SystemString", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.ToLower();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToLower_this_SystemGlobalizationCultureInfo__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 culture) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_culture = objects.RetriveObject<System.Globalization.CultureInfo>(culture, caller);
                var result = resolved_this.ToLower(resolved_culture);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToLowerInvariant_this__SystemString", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.ToLowerInvariant();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToUpper_this__SystemString", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.ToUpper();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToUpper_this_SystemGlobalizationCultureInfo__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 culture) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_culture = objects.RetriveObject<System.Globalization.CultureInfo>(culture, caller);
                var result = resolved_this.ToUpper(resolved_culture);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToUpperInvariant_this__SystemString", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.ToUpperInvariant();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToString_this__SystemString", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.ToString();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__ToString_this_SystemIFormatProvider__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 provider) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_provider = objects.RetriveObject<System.IFormatProvider>(provider, caller);
                var result = resolved_this.ToString(resolved_provider);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Clone_this__SystemObject", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.Clone();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Trim_this__SystemString", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.Trim();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Insert_this_SystemInt32_SystemString__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 startIndex, System.Int32 value) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_value = objects.RetriveObject<System.String>(value, caller);
                var result = resolved_this.Insert(startIndex, resolved_value);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Replace_this_SystemChar_SystemChar__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 oldChar, System.Int32 newChar) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_oldChar = objects.RetriveObject<System.Char>(oldChar, caller);
                var resolved_newChar = objects.RetriveObject<System.Char>(newChar, caller);
                var result = resolved_this.Replace(resolved_oldChar, resolved_newChar);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Replace_this_SystemString_SystemString__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 oldValue, System.Int32 newValue) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_oldValue = objects.RetriveObject<System.String>(oldValue, caller);
                var resolved_newValue = objects.RetriveObject<System.String>(newValue, caller);
                var result = resolved_this.Replace(resolved_oldValue, resolved_newValue);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Remove_this_SystemInt32_SystemInt32__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 startIndex, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = resolved_this.Remove(startIndex, count);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Remove_this_SystemInt32__SystemString", (Caller caller, System.Int32 parameter_this, System.Int32 startIndex) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var result = resolved_this.Remove(startIndex);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Format_SystemString_SystemObject__SystemString", (Caller caller, System.Int32 format, System.Int32 arg0) => {
                var resolved_format = objects.RetriveObject<System.String>(format, caller);
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var result = System.String.Format(resolved_format, resolved_arg0);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Format_SystemString_SystemObject_SystemObject__SystemString", (Caller caller, System.Int32 format, System.Int32 arg0, System.Int32 arg1) => {
                var resolved_format = objects.RetriveObject<System.String>(format, caller);
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var resolved_arg1 = objects.RetriveObject<System.Object>(arg1, caller);
                var result = System.String.Format(resolved_format, resolved_arg0, resolved_arg1);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Format_SystemString_SystemObject_SystemObject_SystemObject__SystemString", (Caller caller, System.Int32 format, System.Int32 arg0, System.Int32 arg1, System.Int32 arg2) => {
                var resolved_format = objects.RetriveObject<System.String>(format, caller);
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var resolved_arg1 = objects.RetriveObject<System.Object>(arg1, caller);
                var resolved_arg2 = objects.RetriveObject<System.Object>(arg2, caller);
                var result = System.String.Format(resolved_format, resolved_arg0, resolved_arg1, resolved_arg2);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Format_SystemIFormatProvider_SystemString_SystemObject__SystemString", (Caller caller, System.Int32 provider, System.Int32 format, System.Int32 arg0) => {
                var resolved_provider = objects.RetriveObject<System.IFormatProvider>(provider, caller);
                var resolved_format = objects.RetriveObject<System.String>(format, caller);
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var result = System.String.Format(resolved_provider, resolved_format, resolved_arg0);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Format_SystemIFormatProvider_SystemString_SystemObject_SystemObject__SystemString", (Caller caller, System.Int32 provider, System.Int32 format, System.Int32 arg0, System.Int32 arg1) => {
                var resolved_provider = objects.RetriveObject<System.IFormatProvider>(provider, caller);
                var resolved_format = objects.RetriveObject<System.String>(format, caller);
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var resolved_arg1 = objects.RetriveObject<System.Object>(arg1, caller);
                var result = System.String.Format(resolved_provider, resolved_format, resolved_arg0, resolved_arg1);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Format_SystemIFormatProvider_SystemString_SystemObject_SystemObject_SystemObject__SystemString", (Caller caller, System.Int32 provider, System.Int32 format, System.Int32 arg0, System.Int32 arg1, System.Int32 arg2) => {
                var resolved_provider = objects.RetriveObject<System.IFormatProvider>(provider, caller);
                var resolved_format = objects.RetriveObject<System.String>(format, caller);
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var resolved_arg1 = objects.RetriveObject<System.Object>(arg1, caller);
                var resolved_arg2 = objects.RetriveObject<System.Object>(arg2, caller);
                var result = System.String.Format(resolved_provider, resolved_format, resolved_arg0, resolved_arg1, resolved_arg2);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Copy_SystemString__SystemString", (Caller caller, System.Int32 str) => {
                var resolved_str = objects.RetriveObject<System.String>(str, caller);
                var result = System.String.Copy(resolved_str);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemObject__SystemString", (Caller caller, System.Int32 arg0) => {
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var result = System.String.Concat(resolved_arg0);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemObject_SystemObject__SystemString", (Caller caller, System.Int32 arg0, System.Int32 arg1) => {
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var resolved_arg1 = objects.RetriveObject<System.Object>(arg1, caller);
                var result = System.String.Concat(resolved_arg0, resolved_arg1);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemObject_SystemObject_SystemObject__SystemString", (Caller caller, System.Int32 arg0, System.Int32 arg1, System.Int32 arg2) => {
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var resolved_arg1 = objects.RetriveObject<System.Object>(arg1, caller);
                var resolved_arg2 = objects.RetriveObject<System.Object>(arg2, caller);
                var result = System.String.Concat(resolved_arg0, resolved_arg1, resolved_arg2);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemObject_SystemObject_SystemObject_SystemObject__SystemString", (Caller caller, System.Int32 arg0, System.Int32 arg1, System.Int32 arg2, System.Int32 arg3) => {
                var resolved_arg0 = objects.RetriveObject<System.Object>(arg0, caller);
                var resolved_arg1 = objects.RetriveObject<System.Object>(arg1, caller);
                var resolved_arg2 = objects.RetriveObject<System.Object>(arg2, caller);
                var resolved_arg3 = objects.RetriveObject<System.Object>(arg3, caller);
                var result = System.String.Concat(resolved_arg0, resolved_arg1, resolved_arg2, resolved_arg3);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemObject[]__SystemString", (Caller caller, System.Int32 args) => {
                var resolved_args = objects.RetriveObject<System.Object[]>(args, caller);
                var result = System.String.Concat(resolved_args);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemString_SystemString__SystemString", (Caller caller, System.Int32 str0, System.Int32 str1) => {
                var resolved_str0 = objects.RetriveObject<System.String>(str0, caller);
                var resolved_str1 = objects.RetriveObject<System.String>(str1, caller);
                var result = System.String.Concat(resolved_str0, resolved_str1);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemString_SystemString_SystemString__SystemString", (Caller caller, System.Int32 str0, System.Int32 str1, System.Int32 str2) => {
                var resolved_str0 = objects.RetriveObject<System.String>(str0, caller);
                var resolved_str1 = objects.RetriveObject<System.String>(str1, caller);
                var resolved_str2 = objects.RetriveObject<System.String>(str2, caller);
                var result = System.String.Concat(resolved_str0, resolved_str1, resolved_str2);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemString_SystemString_SystemString_SystemString__SystemString", (Caller caller, System.Int32 str0, System.Int32 str1, System.Int32 str2, System.Int32 str3) => {
                var resolved_str0 = objects.RetriveObject<System.String>(str0, caller);
                var resolved_str1 = objects.RetriveObject<System.String>(str1, caller);
                var resolved_str2 = objects.RetriveObject<System.String>(str2, caller);
                var resolved_str3 = objects.RetriveObject<System.String>(str3, caller);
                var result = System.String.Concat(resolved_str0, resolved_str1, resolved_str2, resolved_str3);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Concat_SystemString[]__SystemString", (Caller caller, System.Int32 values) => {
                var resolved_values = objects.RetriveObject<System.String[]>(values, caller);
                var result = System.String.Concat(resolved_values);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Intern_SystemString__SystemString", (Caller caller, System.Int32 str) => {
                var resolved_str = objects.RetriveObject<System.String>(str, caller);
                var result = System.String.Intern(resolved_str);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__IsInterned_SystemString__SystemString", (Caller caller, System.Int32 str) => {
                var resolved_str = objects.RetriveObject<System.String>(str, caller);
                var result = System.String.IsInterned(resolved_str);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__GetTypeCode_this__SystemTypeCode", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.GetTypeCode();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__GetEnumerator_this__SystemCharEnumerator", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.GetEnumerator();
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__get_Chars_this_SystemInt32__SystemChar", (Caller caller, System.Int32 parameter_this, System.Int32 index) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_index = objects.RetriveObject<System.Int32>(index, caller);
                var result = resolved_this[index];
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__get_Length_this__SystemInt32", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var result = resolved_this.Length;
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOf_this_SystemChar_SystemInt32_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.Char>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = resolved_this.IndexOf(resolved_value, startIndex, count);
                return result;
            });

            linker.DefineFunction("env", "System_String__IndexOfAny_this_SystemChar[]_SystemInt32_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 anyOf, System.Int32 startIndex, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_anyOf = objects.RetriveObject<System.Char[]>(anyOf, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = resolved_this.IndexOfAny(resolved_anyOf, startIndex, count);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOf_this_SystemChar_SystemInt32_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 value, System.Int32 startIndex, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_value = objects.RetriveObject<System.Char>(value, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = resolved_this.LastIndexOf(resolved_value, startIndex, count);
                return result;
            });

            linker.DefineFunction("env", "System_String__LastIndexOfAny_this_SystemChar[]_SystemInt32_SystemInt32__SystemInt32", (Caller caller, System.Int32 parameter_this, System.Int32 anyOf, System.Int32 startIndex, System.Int32 count) => {
                var resolved_this = objects.RetriveObject<System.String>(parameter_this, caller);
                var resolved_anyOf = objects.RetriveObject<System.Char[]>(anyOf, caller);
                var resolved_startIndex = objects.RetriveObject<System.Int32>(startIndex, caller);
                var resolved_count = objects.RetriveObject<System.Int32>(count, caller);
                var result = resolved_this.LastIndexOfAny(resolved_anyOf, startIndex, count);
                return result;
            });

            linker.DefineFunction("env", "System_String__Format_SystemString_SystemObject[]__SystemString", (Caller caller, System.Int32 format, System.Int32 args) => {
                var resolved_format = objects.RetriveObject<System.String>(format, caller);
                var resolved_args = objects.RetriveObject<System.Object[]>(args, caller);
                var result = System.String.Format(resolved_format, resolved_args);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_String__Format_SystemIFormatProvider_SystemString_SystemObject[]__SystemString", (Caller caller, System.Int32 provider, System.Int32 format, System.Int32 args) => {
                var resolved_provider = objects.RetriveObject<System.IFormatProvider>(provider, caller);
                var resolved_format = objects.RetriveObject<System.String>(format, caller);
                var resolved_args = objects.RetriveObject<System.Object[]>(args, caller);
                var result = System.String.Format(resolved_provider, resolved_format, resolved_args);
                return objects.StoreObject(result);
            });

            linker.DefineFunction("env", "System_Object__GetType_this__SystemType", (Caller caller, System.Int32 parameter_this) => {
                var resolved_this = objects.RetriveObject<System.Object>(parameter_this, caller);
                var result = resolved_this.GetType();
                return objects.StoreObject(result);
            });

        }
    }
}