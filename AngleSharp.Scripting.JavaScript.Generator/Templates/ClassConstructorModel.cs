﻿namespace AngleSharp.Scripting.JavaScript.Generator.Templates
{
    using System;
    using System.Collections.Generic;

    public class ClassConstructorModel
    {
        public String Namespace
        {
            get;
            set;
        }

        public String OriginalNamespace
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String OriginalName
        {
            get;
            set;
        }

        public IEnumerable<ParameterModel> Parameters
        {
            get;
            set;
        }
    }

    partial class ClassConstructor
    {
        public ClassConstructor(ClassConstructorModel model)
        {
            Model = model;
        }

        public ClassConstructorModel Model
        {
            get;
            private set;
        }
    }
}
