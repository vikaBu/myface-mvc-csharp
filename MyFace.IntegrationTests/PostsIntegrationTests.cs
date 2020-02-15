﻿using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace MyFace.IntegrationTests
{
    public class PostsIntegrationTests
    {
        private WebApplicationFactory<Startup> _factory;
        private HttpClient _client;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _factory = new WebApplicationFactory<Startup>();
            _client = _factory.CreateDefaultClient();
        }

        [Test]
        public async Task PostsPageShouldReturnSuccessResponse()
        {
            var response = await _client.GetAsync("/posts");

            response.StatusCode.Should().Be(200);
        }
    }
}