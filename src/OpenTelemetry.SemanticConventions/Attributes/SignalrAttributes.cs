// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from scripts/templates/SemanticConventionsAttributes.cs.j2</auto-generated>

#pragma warning disable CS1570 // XML comment has badly formed XML

using System;

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class SignalrAttributes
{
    /// <summary>
    /// SignalR HTTP connection closure status.
    /// </summary>
    public const string AttributeSignalrConnectionStatus = "signalr.connection.status";

    /// <summary>
    /// <a href="https://github.com/dotnet/aspnetcore/blob/main/src/SignalR/docs/specs/TransportProtocols.md">SignalR transport type</a>.
    /// </summary>
    public const string AttributeSignalrTransport = "signalr.transport";

    /// <summary>
    /// SignalR HTTP connection closure status.
    /// </summary>
    public static class SignalrConnectionStatusValues
    {
        /// <summary>
        /// The connection was closed normally.
        /// </summary>
        public const string NormalClosure = "normal_closure";

        /// <summary>
        /// The connection was closed due to a timeout.
        /// </summary>
        public const string Timeout = "timeout";

        /// <summary>
        /// The connection was closed because the app is shutting down.
        /// </summary>
        public const string AppShutdown = "app_shutdown";
    }

    /// <summary>
    /// <a href="https://github.com/dotnet/aspnetcore/blob/main/src/SignalR/docs/specs/TransportProtocols.md">SignalR transport type</a>.
    /// </summary>
    public static class SignalrTransportValues
    {
        /// <summary>
        /// ServerSentEvents protocol.
        /// </summary>
        public const string ServerSentEvents = "server_sent_events";

        /// <summary>
        /// LongPolling protocol.
        /// </summary>
        public const string LongPolling = "long_polling";

        /// <summary>
        /// WebSockets protocol.
        /// </summary>
        public const string WebSockets = "web_sockets";
    }
}