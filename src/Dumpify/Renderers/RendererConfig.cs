﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumpify.Renderers;

public struct RendererConfig
{
    public string? Label { get; init; }
    public int? MaxNestingLevel { get; init; }
}