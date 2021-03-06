// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ContainerInstance.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ContainerInstance.Fluent.ContainerGroup.Definition;
    using Microsoft.Azure.Management.ContainerInstance.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using Microsoft.Azure.Management.Storage.Fluent;

    internal partial class ContainerGroupsImpl 
    {
        /// <summary>
        /// Begins a definition for a new resource.
        /// This is the beginning of the builder pattern used to create top level resources
        /// in Azure. The final method completing the definition and starting the actual resource creation
        /// process in Azure is  Creatable.create().
        /// Note that the  Creatable.create() method is
        /// only available at the stage of the resource definition that has the minimum set of input
        /// parameters specified. If you do not see  Creatable.create() among the available methods, it
        /// means you have not yet specified all the required input settings. Input settings generally begin
        /// with the word "with", for example: <code>.withNewResourceGroup()</code> and return the next stage
        /// of the resource definition, as an interface in the "fluent interface" style.
        /// </summary>
        /// <param name="name">The name of the new resource.</param>
        /// <return>The first stage of the new resource definition.</return>
        ContainerGroup.Definition.IBlank Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsCreating<ContainerGroup.Definition.IBlank>.Define(string name)
        {
            return this.Define(name) as ContainerGroup.Definition.IBlank;
        }

        /// <summary>
        /// Get the log content for the specified container instance within a container group.
        /// </summary>
        /// <param name="resourceGroupName">The Azure resource group name.</param>
        /// <param name="containerName">The container instance name.</param>
        /// <param name="containerGroupName">The container group name.</param>
        /// <throws>IllegalArgumentException thrown if parameters fail the validation.</throws>
        /// <return>All available log lines.</return>
        string Microsoft.Azure.Management.ContainerInstance.Fluent.IContainerGroups.GetLogContent(string resourceGroupName, string containerName, string containerGroupName)
        {
            return this.GetLogContent(resourceGroupName, containerName, containerGroupName);
        }

        /// <summary>
        /// Get the log content for the specified container instance within a container group.
        /// </summary>
        /// <param name="resourceGroupName">The Azure resource group name.</param>
        /// <param name="containerName">The container instance name.</param>
        /// <param name="containerGroupName">The container group name.</param>
        /// <param name="tailLineCount">Only get the last log lines up to this.</param>
        /// <throws>IllegalArgumentException thrown if parameters fail the validation.</throws>
        /// <return>The log lines from the end, up to the number specified.</return>
        string Microsoft.Azure.Management.ContainerInstance.Fluent.IContainerGroups.GetLogContent(string resourceGroupName, string containerName, string containerGroupName, int tailLineCount)
        {
            return this.GetLogContent(resourceGroupName, containerName, containerGroupName, tailLineCount);
        }

        /// <summary>
        /// Get the log content for the specified container instance within a container group.
        /// </summary>
        /// <param name="resourceGroupName">The Azure resource group name.</param>
        /// <param name="containerName">The container instance name.</param>
        /// <param name="containerGroupName">The container group name.</param>
        /// <throws>IllegalArgumentException thrown if parameters fail the validation.</throws>
        /// <return>A representation of the future computation of this call.</return>
        async Task<string> Microsoft.Azure.Management.ContainerInstance.Fluent.IContainerGroups.GetLogContentAsync(string resourceGroupName, string containerName, string containerGroupName, CancellationToken cancellationToken)
        {
            return await this.GetLogContentAsync(resourceGroupName, containerName, containerGroupName, cancellationToken);
        }

        /// <summary>
        /// Get the log content for the specified container instance within a container group.
        /// </summary>
        /// <param name="resourceGroupName">The Azure resource group name.</param>
        /// <param name="containerName">The container instance name.</param>
        /// <param name="containerGroupName">The container group name.</param>
        /// <param name="tailLineCount">Only get the last log lines up to this.</param>
        /// <throws>IllegalArgumentException thrown if parameters fail the validation.</throws>
        /// <return>A representation of the future computation of this call.</return>
        async Task<string> Microsoft.Azure.Management.ContainerInstance.Fluent.IContainerGroups.GetLogContentAsync(string resourceGroupName, string containerName, string containerGroupName, int tailLineCount, CancellationToken cancellationToken)
        {
            return await this.GetLogContentAsync(resourceGroupName, containerName, containerGroupName, tailLineCount, cancellationToken);
        }
    }
}