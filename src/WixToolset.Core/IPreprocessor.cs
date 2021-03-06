// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Core
{
    using System.Xml;
    using WixToolset.Extensibility.Data;

    public interface IPreprocessor
    {
        IPreprocessResult Preprocess(IPreprocessContext context);

        IPreprocessResult Preprocess(IPreprocessContext context, XmlReader reader);
    }
}
