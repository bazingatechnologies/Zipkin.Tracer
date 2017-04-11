﻿//-----------------------------------------------------------------------
// <copyright file="ZipkinCollectorException.cs" company="Bazinga Technologies Inc.">
//     Copyright (C) 2016 Bazinga Technologies Inc.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace Zipkin
{
#if SERIALIZATION
    [Serializable]
#endif
    public class ZipkinCollectorException : Exception
    {
        public ZipkinCollectorException()
        {
        }

        public ZipkinCollectorException(string message) : base(message)
        {
        }

        public ZipkinCollectorException(string message, Exception inner) : base(message, inner)
        {
        }

#if SERIALIZATION
        protected ZipkinCollectorException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}