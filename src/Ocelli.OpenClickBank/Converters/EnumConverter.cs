﻿using System.Text.Json;
using System.Text.Json.Serialization;
using Ocelli.OpenClickBank.Extensions;

namespace Ocelli.OpenClickBank.Converters;

internal class EnumConverter<T> : JsonConverter<T?> where T : Enum
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
            return reader.GetString().GetEnumFromString<T>();
        reader.TrySkip();
        return default;
    }

    public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options) =>
        writer.WriteAsNullable(value);
}