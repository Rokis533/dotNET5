﻿using AutoFixture.Kernel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PotatoApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoApi.Test.Utils
{
    internal class PotatoSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var type = request as Type;

            if (type == typeof(Potato))
            {
                return new Potato
                {
                    Id = Random.Shared.Next(1000),
                    Name = $"potato_{Random.Shared.Next(1000)}",
                    Weight = Random.Shared.Next(100, 500)

                };
            }
            if (type == typeof(List<Potato>))
            {
                return new Potato
                {
                    Id = Random.Shared.Next(1000),
                    Name = $"potato_{Random.Shared.Next(1000)}",
                    Weight = Random.Shared.Next(100, 500)

                };
            }

            return new NoSpecimen();
        }
    }
}