﻿using CityTravel.Domain.Entities;

using Microsoft.SqlServer.Types;

namespace CityTravel.Web.UI.Models
{
    /// <summary>
    /// from one to another viewmodels
    /// </summary>
    public class TmpAddRouteStopViewModel
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets Route.
        /// </summary>
        public Route Route { get; set; }

        /// <summary>
        /// Gets or sets StopPoint.
        /// </summary>
        public SqlGeography StopPoint { get; set; }

        #endregion
    }
}