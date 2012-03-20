﻿using System.Data.SqlTypes;

using CityTravel.Domain.Entities;

using Microsoft.SqlServer.Types;

using NUnit.Framework;

namespace CityTravel.Tests.Domain.Entities
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using CityTravel.Tests.Domain.DomainModel;
    using CityTravel.Tests.Domain.UnitOfWork;

    /// <summary>
    /// The route tests.
    /// </summary>
    [TestFixture]
    public class RouteTests
    {
        #region Public Methods and Operators

        /// <summary>
        /// The can_ get_ route_ geography.
        /// </summary>
        [Test]
        public void Can_Get_Route_Geography()
        {
            // Arrange
            var route = new Route();
            route.RouteGeography =
                SqlGeography.STGeomFromText(
                    new SqlChars("LINESTRING(35.01064 48.43012, 35.01436 48.42924, 35.01436 48.42924)"), 4326);

            var anotherRoute = new Route();
            anotherRoute.RouteBin =
                SqlGeography.STLineFromText(route.RouteGeography.STAsText(), 4326).STAsBinary().Buffer;

            // Assert
            Assert.AreNotEqual(null, route.RouteGeography);
            Assert.AreNotEqual(null, anotherRoute.RouteGeography);
        }

		/// <summary>
		/// The can_ get_ price_ transport.
		/// </summary>
		[Test]
		public void CanGetPriceTransport()
		{
		    int price = 3;
		    var result = Route.GetPriceTransport(price);

		    Assert.AreEqual("3", result);
        }

        /// <summary>
        /// Determines whether this instance [can make valid].
        /// </summary>
        [Test]
        public void CanMakeValidRoute()
        {
            var context = new FakeDbContext();
            var unitOfWork = new FakeUnitOfWork(context);
            var routes = new List<Route>();
            var route = unitOfWork.RouteRepository.All();
            routes.Add(route.First());
            var result = Route.MakeValid(routes);

            Assert.NotNull(result);
        }

        #endregion
    }
}