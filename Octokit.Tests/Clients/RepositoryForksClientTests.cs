﻿using NSubstitute;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Octokit.Tests.Clients
{
    public class RepositoryForksClientTests
    {
        public class TheCtor
        {
            [Fact]
            public void EnsuresNonNullArguments()
            {
                Assert.Throws<ArgumentNullException>(
                    () => new RepositoryForksClient(null));
            }
        }

        public class TheGetAllMethod
        {
            [Fact]
            public async Task RequestsCorrectUrl()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new RepositoriesClient(connection);

                await client.Forks.GetAll("fake", "repo");

                connection.Received().GetAll<Repository>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/forks"), Args.ApiOptions);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithApiOptions()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new RepositoriesClient(connection);

                var options = new ApiOptions
                {
                    PageCount = 1,
                    StartPage = 1,
                    PageSize = 1
                };

                await client.Forks.GetAll("fake", "repo", options);

                connection.Received().GetAll<Repository>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/forks"), options);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRequestParameters()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new RepositoriesClient(connection);

                await client.Forks.GetAll("fake", "repo", new RepositoryForksListRequest { Sort = Sort.Stargazers });

                connection.Received().GetAll<Repository>(
                    Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/forks"),
                    Arg.Is<Dictionary<string, string>>(d => d["sort"] == "stargazers"), Args.ApiOptions);
            }

            [Fact]
            public async Task RequestsCorrectUrlWithRequestParametersWithApiOptions()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new RepositoriesClient(connection);

                var options = new ApiOptions
                {
                    PageCount = 1,
                    StartPage = 1,
                    PageSize = 1
                };

                await client.Forks.GetAll("fake", "repo", new RepositoryForksListRequest { Sort = Sort.Stargazers }, options);

                connection.Received().GetAll<Repository>(
                    Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/forks"),
                    Arg.Is<Dictionary<string, string>>(d => d["sort"] == "stargazers"), options);
            }

            [Fact]
            public async Task EnsuresNonNullArguments()
            {
                var client = new RepositoryForksClient(Substitute.For<IApiConnection>());

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll(null, "name"));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", null));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll(null, "name", ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", null, ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", "name", (ApiOptions)null));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll(null, "name", new RepositoryForksListRequest()));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", null, new RepositoryForksListRequest()));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", "name", (RepositoryForksListRequest)null));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll(null, "name", new RepositoryForksListRequest(), ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", null, new RepositoryForksListRequest(), ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", "name", null, ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.GetAll("owner", "name", new RepositoryForksListRequest(), null));

                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("", "name"));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("owner", ""));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("", "name", ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("owner", "", ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("", "name", new RepositoryForksListRequest()));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("owner", "", new RepositoryForksListRequest()));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("", "name", new RepositoryForksListRequest(), ApiOptions.None));
                await Assert.ThrowsAsync<ArgumentException>(() => client.GetAll("owner", "", new RepositoryForksListRequest(), ApiOptions.None));
            }
        }

        public class TheCreateMethod
        {
            [Fact]
            public void RequestsCorrectUrl()
            {
                var connection = Substitute.For<IApiConnection>();
                var client = new RepositoriesClient(connection);

                var newRepositoryFork = new NewRepositoryFork();

                client.Forks.Create("fake", "repo", newRepositoryFork);

                connection.Received().Post<Repository>(Arg.Is<Uri>(u => u.ToString() == "repos/fake/repo/forks"), newRepositoryFork);
            }

            [Fact]
            public async Task EnsuresNonNullArguments()
            {
                var client = new RepositoryForksClient(Substitute.For<IApiConnection>());

                await Assert.ThrowsAsync<ArgumentNullException>(() => client.Create(null, "name", new NewRepositoryFork()));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.Create("owner", null, new NewRepositoryFork()));
                await Assert.ThrowsAsync<ArgumentNullException>(() => client.Create("owner", "name", null));

                await Assert.ThrowsAsync<ArgumentException>(() => client.Create("", "name", new NewRepositoryFork()));
                await Assert.ThrowsAsync<ArgumentException>(() => client.Create("owner", "", new NewRepositoryFork()));
            }
        }
    }
}