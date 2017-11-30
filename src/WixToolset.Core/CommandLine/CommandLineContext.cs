﻿// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Core
{
    using System;
    using WixToolset.Data;
    using WixToolset.Extensibility.Services;

    internal class CommandLineContext : ICommandLineContext
    {
        public CommandLineContext(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        public IServiceProvider ServiceProvider { get; }

        public Messaging Messaging { get; set; }

        public IExtensionManager ExtensionManager { get; set; }

        public string Arguments { get; set; }

        public string[] ParsedArguments { get; set; }
    }
}