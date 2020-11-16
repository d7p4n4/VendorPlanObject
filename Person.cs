using Ac4y.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendorPlanObject
{
    public class Person
    {
        [Ac4yDescription("Az adatbázis által generált érték")]
        [Ac4yExampleValue("2")]
        public int Id { get; set; }
        [Ac4yDescription("A személy neve")]
        [Ac4yExampleValue("Nagy Károly")]
        public string Name { get; set; }
        [Ac4yDescription("A személy kora")]
        [Ac4yExampleValue("45")]
        public int Age { get; set; }
    }
}
