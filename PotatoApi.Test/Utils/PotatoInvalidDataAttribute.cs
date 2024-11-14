using AutoFixture;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoApi.Test.Utils
{
    internal class PotatoInvalidDataAttribute : AutoDataAttribute
    {
        public PotatoInvalidDataAttribute() : base(() =>
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new PotatoInvalidSpecimenBuilder());
            // galima prideti ir daugiau customizations
            return fixture;
        })
        { }
    }
}
