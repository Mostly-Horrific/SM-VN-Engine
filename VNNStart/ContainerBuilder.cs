﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNNLanguage;
using VNNMedia;

namespace VNNStart
{
    public static class DiContainer
    {
        private static IContainer container { get; set; }

        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DirtyParser>().As<IParser>();
            builder.RegisterType<Instructor>().As<IInstructor>();
            builder.RegisterType<ContentManager>().As<IContentManager>();
            return builder.Build();
        }
    }
}
