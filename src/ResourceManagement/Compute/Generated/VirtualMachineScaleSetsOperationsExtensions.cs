// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineScaleSetsOperations.
    /// </summary>
    public static partial class VirtualMachineScaleSetsOperationsExtensions
    {
        /// <summary>
        /// Create or update a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set to create or update.
        /// </param>
        /// <param name='parameters'>
        /// The scale set object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<VirtualMachineScaleSetInner> CreateOrUpdateAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, VirtualMachineScaleSetInner parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Update a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set to create or update.
        /// </param>
        /// <param name='parameters'>
        /// The scale set object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<VirtualMachineScaleSetInner> UpdateAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, VirtualMachineScaleSetUpdateInner parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> DeleteAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Display information about a virtual machine scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<VirtualMachineScaleSetInner> GetAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deallocates specific virtual machines in a VM scale set. Shuts down the
        /// virtual machines and releases the compute resources. You are not billed for
        /// the compute resources that this virtual machine scale set deallocates.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> DeallocateAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.DeallocateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes virtual machines in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> DeleteInstancesAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.DeleteInstancesWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets the status of a VM scale set instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<VirtualMachineScaleSetInstanceViewInner> GetInstanceViewAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetInstanceViewWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a list of all VM scale sets under a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<VirtualMachineScaleSetInner>> ListAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a list of all VM Scale Sets in the subscription, regardless of the
        /// associated resource group. Use nextLink property in the response to get the
        /// next page of VM Scale Sets. Do this till nextLink is null to fetch all the
        /// VM Scale Sets.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<VirtualMachineScaleSetInner>> ListAllAsync(this IVirtualMachineScaleSetsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a list of SKUs available for your VM scale set, including the minimum
        /// and maximum VM instances allowed for each SKU.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<VirtualMachineScaleSetSku>> ListSkusAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListSkusWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Power off (stop) one or more virtual machines in a VM scale set. Note that
        /// resources are still attached and you are getting charged for the resources.
        /// Instead, use deallocate to release resources and avoid charges.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> PowerOffAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PowerOffWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Restarts one or more virtual machines in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> RestartAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.RestartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Starts one or more virtual machines in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> StartAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.StartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Upgrades one or more virtual machines to the latest SKU set in the VM scale
        /// set model.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> UpdateInstancesAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.UpdateInstancesWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Reimages (upgrade the operating system) one or more virtual machines in a
        /// VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> ReimageAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ReimageWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Reimages all the disks ( including data disks ) in the virtual machines in
        /// a VM scale set. This operation is only supported for managed disks.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> ReimageAllAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ReimageAllWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Create or update a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set to create or update.
        /// </param>
        /// <param name='parameters'>
        /// The scale set object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<VirtualMachineScaleSetInner> BeginCreateOrUpdateAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, VirtualMachineScaleSetInner parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Update a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set to create or update.
        /// </param>
        /// <param name='parameters'>
        /// The scale set object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<VirtualMachineScaleSetInner> BeginUpdateAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, VirtualMachineScaleSetUpdateInner parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginDeleteAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deallocates specific virtual machines in a VM scale set. Shuts down the
        /// virtual machines and releases the compute resources. You are not billed for
        /// the compute resources that this virtual machine scale set deallocates.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginDeallocateAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginDeallocateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes virtual machines in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginDeleteInstancesAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginDeleteInstancesWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Power off (stop) one or more virtual machines in a VM scale set. Note that
        /// resources are still attached and you are getting charged for the resources.
        /// Instead, use deallocate to release resources and avoid charges.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginPowerOffAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginPowerOffWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Restarts one or more virtual machines in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginRestartAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Starts one or more virtual machines in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginStartAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Upgrades one or more virtual machines to the latest SKU set in the VM scale
        /// set model.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginUpdateInstancesAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginUpdateInstancesWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Reimages (upgrade the operating system) one or more virtual machines in a
        /// VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginReimageAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginReimageWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Reimages all the disks ( including data disks ) in the virtual machines in
        /// a VM scale set. This operation is only supported for managed disks.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// The virtual machine scale set instance ids. Omitting the virtual machine
        /// scale set instance ids will result in the operation being performed on all
        /// virtual machines in the virtual machine scale set.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginReimageAllAsync(this IVirtualMachineScaleSetsOperations operations, string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginReimageAllWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceIds, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a list of all VM scale sets under a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<VirtualMachineScaleSetInner>> ListNextAsync(this IVirtualMachineScaleSetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a list of all VM Scale Sets in the subscription, regardless of the
        /// associated resource group. Use nextLink property in the response to get the
        /// next page of VM Scale Sets. Do this till nextLink is null to fetch all the
        /// VM Scale Sets.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<VirtualMachineScaleSetInner>> ListAllNextAsync(this IVirtualMachineScaleSetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a list of SKUs available for your VM scale set, including the minimum
        /// and maximum VM instances allowed for each SKU.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<VirtualMachineScaleSetSku>> ListSkusNextAsync(this IVirtualMachineScaleSetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListSkusNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
