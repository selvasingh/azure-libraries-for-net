// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ServiceBus.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ServiceBus.Fluent.Models;
    using Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition;
    using Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update;
    using System.Collections.Generic;
    using System;

    internal partial class SubscriptionImpl
    {
        /// <summary>
        /// Gets the manager client of this resource type.
        /// </summary>
        Microsoft.Azure.Management.ServiceBus.Fluent.IServiceBusManager Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasManager<Microsoft.Azure.Management.ServiceBus.Fluent.IServiceBusManager>.Manager
        {
            get
            {
                return this.Manager as Microsoft.Azure.Management.ServiceBus.Fluent.IServiceBusManager;
            }
        }

        /// <summary>
        /// Gets the resource ID string.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasId.Id
        {
            get
            {
                return this.Id;
            }
        }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasName.Name
        {
            get
            {
                return this.Name;
            }
        }

        /// <summary>
        /// The idle interval after which the subscription is automatically deleted.
        /// </summary>
        /// <param name="durationInMinutes">Idle duration in minutes.</param>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithDeleteOnIdle.WithDeleteOnIdleDurationInMinutes(int durationInMinutes)
        {
            return this.WithDeleteOnIdleDurationInMinutes(durationInMinutes) as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// The idle interval after which the subscription is automatically deleted.
        /// Note: unless it is explicitly overridden the default delete on idle duration
        /// is infinite (TimeSpan.Max).
        /// </summary>
        /// <param name="durationInMinutes">Idle duration in minutes.</param>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithDeleteOnIdle.WithDeleteOnIdleDurationInMinutes(int durationInMinutes)
        {
            return this.WithDeleteOnIdleDurationInMinutes(durationInMinutes) as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }

        /// <summary>
        /// Specifies that batching of messages should be disabled when service bus write messages to
        /// or delete messages from it's internal store.
        /// </summary>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithMessageBatching.WithoutMessageBatching()
        {
            return this.WithoutMessageBatching() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that service bus can batch multiple message when it write messages to or delete
        /// messages from it's internal store. This increases the throughput.
        /// </summary>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithMessageBatching.WithMessageBatching()
        {
            return this.WithMessageBatching() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that the default batching should be disabled on this subscription.
        /// With batching service bus can batch multiple message when it write or delete messages
        /// from it's internal store.
        /// </summary>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithMessageBatching.WithoutMessageBatching()
        {
            return this.WithoutMessageBatching() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }

        /// <summary>
        /// Specifies maximum number of times a message can be delivered. Once this count has exceeded,
        /// message will be moved to dead-letter subscription.
        /// </summary>
        /// <param name="deliveryCount">Maximum delivery subscription.</param>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithMessageMovedToDeadLetterQueueOnMaxDeliveryCount.WithMessageMovedToDeadLetterQueueOnMaxDeliveryCount(int deliveryCount)
        {
            return this.WithMessageMovedToDeadLetterQueueOnMaxDeliveryCount(deliveryCount) as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that expired message should not be moved to dead-letter subscription.
        /// </summary>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithExpiredMessageMovedToDeadLetterSubscription.WithoutExpiredMessageMovedToDeadLetterSubscription()
        {
            return this.WithoutExpiredMessageMovedToDeadLetterSubscription() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that expired message must be moved to dead-letter subscription.
        /// </summary>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithExpiredMessageMovedToDeadLetterSubscription.WithExpiredMessageMovedToDeadLetterSubscription()
        {
            return this.WithExpiredMessageMovedToDeadLetterSubscription() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that expired message should not be moved to dead-letter subscription.
        /// </summary>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithExpiredMessageMovedToDeadLetterSubscription.WithoutExpiredMessageMovedToDeadLetterSubscription()
        {
            return this.WithoutExpiredMessageMovedToDeadLetterSubscription() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }

        /// <summary>
        /// Specifies that expired message must be moved to dead-letter subscription.
        /// </summary>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithExpiredMessageMovedToDeadLetterSubscription.WithExpiredMessageMovedToDeadLetterSubscription()
        {
            return this.WithExpiredMessageMovedToDeadLetterSubscription() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }

        /// <summary>
        /// Specifies that filter evaluation failed message must be moved to dead-letter subscription.
        /// </summary>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException.WithMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException()
        {
            return this.WithMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that filter evaluation failed message should not be moved to dead-letter subscription.
        /// </summary>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException.WithoutMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException()
        {
            return this.WithoutMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that filter evaluation failed message must be moved to dead-letter subscription.
        /// </summary>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException.WithMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException()
        {
            return this.WithMessageMovedToDeadLetterSubscriptionOnFilterEvaluationException() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }

        /// <summary>
        /// Specifies the duration after which the message expires.
        /// </summary>
        /// <param name="ttl">Time to live duration.</param>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithDefaultMessageTTL.WithDefaultMessageTTL(TimeSpan ttl)
        {
            return this.WithDefaultMessageTTL(ttl) as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies the duration after which the message expires.
        /// Note: unless it is explicitly overridden the default ttl is infinite (TimeSpan.Max).
        /// </summary>
        /// <param name="ttl">Time to live duration.</param>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithDefaultMessageTTL.WithDefaultMessageTTL(TimeSpan ttl)
        {
            return this.WithDefaultMessageTTL(ttl) as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }

        /// <summary>
        /// Specifies maximum number of times a message can be delivered. Once this count has exceeded,
        /// message will be moved to dead-letter subscription.
        /// </summary>
        /// <param name="deliveryCount">Maximum delivery count.</param>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithMessageMovedToDeadLetterSubscriptionOnMaxDeliveryCount.WithMessageMovedToDeadLetterSubscriptionOnMaxDeliveryCount(int deliveryCount)
        {
            return this.WithMessageMovedToDeadLetterSubscriptionOnMaxDeliveryCount(deliveryCount) as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }

        /// <summary>
        /// Gets the name of the region the resource is in.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IResource.RegionName
        {
            get
            {
                return this.RegionName;
            }
        }

        /// <summary>
        /// Gets the tags for the resource.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string, string> Microsoft.Azure.Management.ResourceManager.Fluent.Core.IResource.Tags
        {
            get
            {
                return this.Tags as System.Collections.Generic.IReadOnlyDictionary<string, string>;
            }
        }

        /// <summary>
        /// Gets the region the resource is in.
        /// </summary>
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region Microsoft.Azure.Management.ResourceManager.Fluent.Core.IResource.Region
        {
            get
            {
                return this.Region as Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region;
            }
        }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IResource.Type
        {
            get
            {
                return this.Type;
            }
        }

        /// <summary>
        /// Specifies that session support should be disabled for the subscription.
        /// </summary>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithSession.WithoutSession()
        {
            return this.WithoutSession() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that session support should be enabled for the subscription.
        /// </summary>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithSession.WithSession()
        {
            return this.WithSession() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies that session support should be enabled for the subscription.
        /// </summary>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithSession.WithSession()
        {
            return this.WithSession() as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }

        /// <summary>
        /// Gets the name of the resource group.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasResourceGroup.ResourceGroupName
        {
            get
            {
                return this.ResourceGroupName;
            }
        }

        /// <summary>
        /// Gets indicates whether subscription has dead letter support on filter evaluation exceptions.
        /// </summary>
        bool Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.IsDeadLetteringEnabledForFilterEvaluationFailedMessages
        {
            get
            {
                return this.IsDeadLetteringEnabledForFilterEvaluationFailedMessages();
            }
        }

        /// <summary>
        /// Gets the idle duration after which the subscription is automatically deleted.
        /// </summary>
        long Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.DeleteOnIdleDurationInMinutes
        {
            get
            {
                return this.DeleteOnIdleDurationInMinutes();
            }
        }

        /// <summary>
        /// Gets number of active messages in the subscription.
        /// </summary>
        long Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.ActiveMessageCount
        {
            get
            {
                return this.ActiveMessageCount();
            }
        }

        /// <summary>
        /// Gets the exact time the message was created.
        /// </summary>
        System.DateTime Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.CreatedAt
        {
            get
            {
                return this.CreatedAt();
            }
        }

        /// <summary>
        /// Gets indicates whether this subscription has dead letter support when a message expires.
        /// </summary>
        bool Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.IsDeadLetteringEnabledForExpiredMessages
        {
            get
            {
                return this.IsDeadLetteringEnabledForExpiredMessages();
            }
        }

        /// <summary>
        /// Gets indicates whether server-side batched operations are enabled.
        /// </summary>
        bool Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.IsBatchedOperationsEnabled
        {
            get
            {
                return this.IsBatchedOperationsEnabled();
            }
        }

        /// <summary>
        /// Gets the number of messages in the subscription.
        /// </summary>
        long Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.MessageCount
        {
            get
            {
                return this.MessageCount();
            }
        }

        /// <summary>
        /// Gets number of messages transferred to another queue, topic, or subscription.
        /// </summary>
        long Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.TransferMessageCount
        {
            get
            {
                return this.TransferMessageCount();
            }
        }

        /// <summary>
        /// Gets the duration after which the message expires, starting from when the message is sent to subscription.
        /// </summary>
        System.TimeSpan Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.DefaultMessageTtlDuration
        {
            get
            {
                return this.DefaultMessageTtlDuration();
            }
        }

        /// <summary>
        /// Gets indicates whether the subscription supports sessions.
        /// </summary>
        bool Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.IsSessionEnabled
        {
            get
            {
                return this.IsSessionEnabled();
            }
        }

        /// <summary>
        /// Gets the current status of the subscription.
        /// </summary>
        Microsoft.Azure.Management.ServiceBus.Fluent.Models.EntityStatus Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.Status
        {
            get
            {
                return this.Status();
            }
        }

        /// <summary>
        /// Gets number of messages sent to the subscription that are yet to be released
        /// for consumption.
        /// </summary>
        long Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.ScheduledMessageCount
        {
            get
            {
                return this.ScheduledMessageCount();
            }
        }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        System.DateTime Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.UpdatedAt
        {
            get
            {
                return this.UpdatedAt();
            }
        }

        /// <summary>
        /// Gets last time there was a receive request to this subscription.
        /// </summary>
        System.DateTime Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.AccessedAt
        {
            get
            {
                return this.AccessedAt();
            }
        }

        /// <summary>
        /// Gets number of messages transferred into dead letters.
        /// </summary>
        long Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.TransferDeadLetterMessageCount
        {
            get
            {
                return this.TransferDeadLetterMessageCount();
            }
        }

        /// <summary>
        /// Gets the maximum number of a message delivery before marking it as dead-lettered.
        /// </summary>
        int Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.MaxDeliveryCountBeforeDeadLetteringMessage
        {
            get
            {
                return this.MaxDeliveryCountBeforeDeadLetteringMessage();
            }
        }

        /// <summary>
        /// Gets the duration of peek-lock which is the amount of time that the message is locked for other receivers.
        /// </summary>
        long Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.LockDurationInSeconds
        {
            get
            {
                return this.LockDurationInSeconds();
            }
        }

        /// <summary>
        /// Gets number of messages in the dead-letter subscription.
        /// </summary>
        long Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription.DeadLetterMessageCount
        {
            get
            {
                return this.DeadLetterMessageCount();
            }
        }

        /// <summary>
        /// Specifies the amount of time that the message is locked for other receivers.
        /// </summary>
        /// <param name="durationInSeconds">Duration of a lock in seconds.</param>
        /// <return>The next stage of subscription update.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IWithMessageLockDuration.WithMessageLockDurationInSeconds(int durationInSeconds)
        {
            return this.WithMessageLockDurationInSeconds(durationInSeconds) as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update.IUpdate;
        }

        /// <summary>
        /// Specifies the amount of time that the message is locked for other receivers.
        /// Note: unless it is explicitly overridden the default lock duration is 60 seconds,
        /// the maximum allowed value is 300 seconds.
        /// </summary>
        /// <param name="durationInSeconds">Duration of a lock in seconds.</param>
        /// <return>The next stage of subscription definition.</return>
        Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithMessageLockDuration.WithMessageLockDurationInSeconds(int durationInSeconds)
        {
            return this.WithMessageLockDurationInSeconds(durationInSeconds) as Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Definition.IWithCreate;
        }
    }
}