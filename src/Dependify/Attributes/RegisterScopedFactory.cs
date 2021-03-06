﻿// Copyright 2017 Dávid Kaya. All rights reserved.
// Use of this source code is governed by the MIT license,
// as found in the LICENSE file.

using System;
using Microsoft.Extensions.DependencyInjection;

namespace Dependify.Attributes {
    /// <summary>
    /// Methods with this attribute will be registered as factories for classes with <see cref="ServiceLifetime.Scoped"/> lifetime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class RegisterScopedFactory : RegisterFactory {
        public RegisterScopedFactory(Type returnType) : base(returnType) { }
    }
}