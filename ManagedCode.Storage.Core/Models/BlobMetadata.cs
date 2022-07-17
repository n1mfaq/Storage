﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace ManagedCode.Storage.Core.Models;

public class BlobMetadata
{
    public string Name { get; set; } = null!;
    public Uri? Uri { get; set; }

    public Dictionary<string,string>? Metadata { get; set; }
    public string? Container { get; set; }
    public string? MimeType { get; set; }
    public long Length { get; set; }
}