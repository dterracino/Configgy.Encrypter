﻿using Configgy.Cache;
using Configgy.Coercion;
using Configgy.Source;
using Configgy.Transfomers;
using Configgy.Validation;

namespace Configgy.Tests.Unit
{
    public class ConfigWrapper<T> : Config
    {
        public const string ThePropertyName = nameof(TheProperty);

        public T TheProperty { get { return Get<T>(); } }

        public ConfigWrapper()
            : base()
        {
        }

        public ConfigWrapper(string[] commandLine)
            : base(commandLine)
        {
        }

        public ConfigWrapper(IValueCache cache, IValueSource source, IValueTransformer transformer, IValueValidator validator, IValueCoercer coercer)
            : base(cache, source, transformer, validator, coercer)
        {
        }

        public T Get_Wrapper(string valueName)
        {
            return Get<T>(valueName);
        }
    }
}
