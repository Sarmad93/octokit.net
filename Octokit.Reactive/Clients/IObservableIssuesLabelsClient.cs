﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Reactive;

namespace Octokit.Reactive
{
    /// <summary>
    /// A client for GitHub's Issue Labels API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/issues/labels/">Issue Labels API documentation</a> for more information.
    /// </remarks>
    public interface IObservableIssuesLabelsClient
    {
        /// <summary>
        /// Gets all  labels for the issue.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#list-labels-on-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the issue</param>
        IObservable<Label> GetAllForIssue(string owner, string name, int number);

        /// <summary>
        /// Gets all  labels for the issue.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#list-labels-on-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the issue</param>
        IObservable<Label> GetAllForIssue(int repositoryId, int number);

        /// <summary>
        /// Gets all  labels for the issue.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#list-labels-on-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the issue</param>
        /// <param name="options">Options for changing the API response</param>
        IObservable<Label> GetAllForIssue(string owner, string name, int number, ApiOptions options);

        /// <summary>
        /// Gets all  labels for the issue.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#list-labels-on-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the issue</param>
        /// <param name="options">Options for changing the API response</param>
        IObservable<Label> GetAllForIssue(int repositoryId, int number, ApiOptions options);

        /// <summary>
        /// Gets all  labels for the repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#list-all-labels-for-this-repository">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        IObservable<Label> GetAllForRepository(string owner, string name);

        /// <summary>
        /// Gets all  labels for the repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#list-all-labels-for-this-repository">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        IObservable<Label> GetAllForRepository(int repositoryId);

        /// <summary>
        /// Gets all  labels for the repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#list-all-labels-for-this-repository">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        IObservable<Label> GetAllForRepository(string owner, string name, ApiOptions options);

        /// <summary>
        /// Gets all  labels for the repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#list-all-labels-for-this-repository">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        IObservable<Label> GetAllForRepository(int repositoryId, ApiOptions options);

        /// <summary>
        /// Gets labels for every issue in a milestone
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#get-labels-for-every-issue-in-a-milestone">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the milestone</param>
        IObservable<Label> GetAllForMilestone(string owner, string name, int number);

        /// <summary>
        /// Gets labels for every issue in a milestone
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#get-labels-for-every-issue-in-a-milestone">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the milestone</param>
        IObservable<Label> GetAllForMilestone(int repositoryId, int number);

        /// <summary>
        /// Gets labels for every issue in a milestone
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#get-labels-for-every-issue-in-a-milestone">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the milestone</param>
        /// <param name="options">Options for changing the API response</param>
        IObservable<Label> GetAllForMilestone(string owner, string name, int number, ApiOptions options);

        /// <summary>
        /// Gets labels for every issue in a milestone
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#get-labels-for-every-issue-in-a-milestone">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the milestone</param>
        /// <param name="options">Options for changing the API response</param>
        IObservable<Label> GetAllForMilestone(int repositoryId, int number, ApiOptions options);

        /// <summary>
        /// Gets a single Label by name.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#get-a-single-label">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="labelName">The name of the label</param>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
             Justification = "Method makes a network request")]
        IObservable<Label> Get(string owner, string name, string labelName);

        /// <summary>
        /// Gets a single Label by name.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#get-a-single-label">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="labelName">The name of the label</param>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
             Justification = "Method makes a network request")]
        IObservable<Label> Get(int repositoryId, string labelName);

        /// <summary>
        /// Deletes a label.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#delete-a-label">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="labelName">The name of the label</param>
        IObservable<Unit> Delete(string owner, string name, string labelName);

        /// <summary>
        /// Deletes a label.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#delete-a-label">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="labelName">The name of the label</param>
        IObservable<Unit> Delete(int repositoryId, string labelName);

        /// <summary>
        /// Creates a label.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#create-a-label">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="newLabel">The data for the label to be created</param>
        IObservable<Label> Create(string owner, string name, NewLabel newLabel);

        /// <summary>
        /// Creates a label.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#create-a-label">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="newLabel">The data for the label to be created</param>
        IObservable<Label> Create(int repositoryId, NewLabel newLabel);

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#update-a-label">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="labelName">The name of the label</param>
        /// <param name="labelUpdate">The data for the label to be updated</param>
        IObservable<Label> Update(string owner, string name, string labelName, LabelUpdate labelUpdate);

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#update-a-label">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="labelName">The name of the label</param>
        /// <param name="labelUpdate">The data for the label to be updated</param>
        IObservable<Label> Update(int repositoryId, string labelName, LabelUpdate labelUpdate);

        /// <summary>
        /// Adds a label to an issue
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#add-labels-to-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the issue</param>
        /// <param name="labels">The names of the labels to add</param>
        IObservable<Label> AddToIssue(string owner, string name, int number, string[] labels);

        /// <summary>
        /// Adds a label to an issue
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#add-labels-to-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the issue</param>
        /// <param name="labels">The names of the labels to add</param>
        IObservable<Label> AddToIssue(int repositoryId, int number, string[] labels);

        /// <summary>
        /// Removes a label from an issue
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#remove-a-label-from-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the issue</param>
        /// <param name="labelName">The name of the label to remove</param>
        IObservable<Unit> RemoveFromIssue(string owner, string name, int number, string labelName);

        /// <summary>
        /// Removes a label from an issue
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#remove-a-label-from-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the issue</param>
        /// <param name="labelName">The name of the label to remove</param>
        IObservable<Unit> RemoveFromIssue(int repositoryId, int number, string labelName);

        /// <summary>
        /// Replaces all labels on the specified issues with the provided labels
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#replace-all-labels-for-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the issue</param>
        /// <param name="labels">The names of the labels to set</param>
        IObservable<Label> ReplaceAllForIssue(string owner, string name, int number, string[] labels);

        /// <summary>
        /// Replaces all labels on the specified issues with the provided labels
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#replace-all-labels-for-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the issue</param>
        /// <param name="labels">The names of the labels to set</param>
        IObservable<Label> ReplaceAllForIssue(int repositoryId, int number, string[] labels);

        /// <summary>
        /// Removes all labels from an issue
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#remove-all-labels-from-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the issue</param>
        IObservable<Unit> RemoveAllFromIssue(string owner, string name, int number);

        /// <summary>
        /// Removes all labels from an issue
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/issues/labels/#remove-all-labels-from-an-issue">API documentation</a> for more information.
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the issue</param>
        IObservable<Unit> RemoveAllFromIssue(int repositoryId, int number);
    }
}
