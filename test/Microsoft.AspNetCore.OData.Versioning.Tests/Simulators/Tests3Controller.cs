﻿namespace Microsoft.Simulators
{
    using Microsoft.AspNet.OData;
    using Microsoft.AspNet.OData.Routing;
    using Microsoft.AspNetCore.Mvc;

    [ApiVersion( "3.0" )]
    [ApiVersion( "3.0-Beta", Deprecated = true )]
    [ODataRoutePrefix( "Tests" )]
    public class Tests3Controller : ODataController
    {
        [ODataRoute]
        public IActionResult Get() => Ok( new[] { new TestEntity() { Id = 1 }, new TestEntity() { Id = 2 }, new TestEntity() { Id = 3 } } );

        [ODataRoute( "{id}" )]
        public IActionResult Get( int id ) => Ok( new TestEntity() { Id = id } );
    }
}