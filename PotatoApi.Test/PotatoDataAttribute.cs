using AutoFixture;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoApi.Test
{
    internal class PotatoDataAttribute : AutoDataAttribute
    {
        public PotatoDataAttribute() : base(() =>
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new PotatoSpecimenBuilder());
            // galima prideti ir daugiau customizations
            return fixture;
        })
        { }
    }
}
