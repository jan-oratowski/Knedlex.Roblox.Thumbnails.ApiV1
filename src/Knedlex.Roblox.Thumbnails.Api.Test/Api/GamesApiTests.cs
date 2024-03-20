/*
 * Thumbnails Api v1
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Knedlex.Roblox.Thumbnails.Api.Client;
using Knedlex.Roblox.Thumbnails.Api.Api;
// uncomment below to import models
//using Knedlex.Roblox.Thumbnails.Api.Model;

namespace Knedlex.Roblox.Thumbnails.Api.Test.Api
{
    /// <summary>
    ///  Class for testing GamesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GamesApiTests : IDisposable
    {
        private GamesApi instance;

        public GamesApiTests()
        {
            instance = new GamesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GamesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GamesApi
            //Assert.IsType<GamesApi>(instance);
        }

        /// <summary>
        /// Test V1GamesIconsGet
        /// </summary>
        [Fact]
        public void V1GamesIconsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<long> universeIds = null;
            //string returnPolicy = null;
            //string size = null;
            //string format = null;
            //bool? isCircular = null;
            //var response = instance.V1GamesIconsGet(universeIds, returnPolicy, size, format, isCircular);
            //Assert.IsType<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>(response);
        }

        /// <summary>
        /// Test V1GamesMultigetThumbnailsGet
        /// </summary>
        [Fact]
        public void V1GamesMultigetThumbnailsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<long> universeIds = null;
            //int? countPerUniverse = null;
            //bool? defaults = null;
            //string size = null;
            //string format = null;
            //bool? isCircular = null;
            //var response = instance.V1GamesMultigetThumbnailsGet(universeIds, countPerUniverse, defaults, size, format, isCircular);
            //Assert.IsType<RobloxWebWebAPIModelsApiArrayResponseRobloxThumbnailsApiModelsUniverseThumbnailsResponse>(response);
        }

        /// <summary>
        /// Test V1GamesUniverseIdThumbnailsGet
        /// </summary>
        [Fact]
        public void V1GamesUniverseIdThumbnailsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long universeId = null;
            //List<long> thumbnailIds = null;
            //string size = null;
            //string format = null;
            //bool? isCircular = null;
            //var response = instance.V1GamesUniverseIdThumbnailsGet(universeId, thumbnailIds, size, format, isCircular);
            //Assert.IsType<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>(response);
        }
    }
}
