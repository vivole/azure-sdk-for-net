// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicyFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PrefixMatch))
            {
                writer.WritePropertyName("prefixMatch"u8);
                writer.WriteStartArray();
                foreach (var item in PrefixMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("blobTypes"u8);
            writer.WriteStartArray();
            foreach (var item in BlobTypes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(BlobIndexMatch))
            {
                writer.WritePropertyName("blobIndexMatch"u8);
                writer.WriteStartArray();
                foreach (var item in BlobIndexMatch)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagementPolicyFilter DeserializeManagementPolicyFilter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> prefixMatch = default;
            IList<string> blobTypes = default;
            Optional<IList<ManagementPolicyTagFilter>> blobIndexMatch = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefixMatch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    prefixMatch = array;
                    continue;
                }
                if (property.NameEquals("blobTypes"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    blobTypes = array;
                    continue;
                }
                if (property.NameEquals("blobIndexMatch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagementPolicyTagFilter> array = new List<ManagementPolicyTagFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementPolicyTagFilter.DeserializeManagementPolicyTagFilter(item));
                    }
                    blobIndexMatch = array;
                    continue;
                }
            }
            return new ManagementPolicyFilter(Optional.ToList(prefixMatch), blobTypes, Optional.ToList(blobIndexMatch));
        }
    }
}
