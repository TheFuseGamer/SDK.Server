﻿using System;
using JetBrains.Annotations;

namespace NFive.SDK.Server.Rpc
{
	/// <summary>
	/// Represents the ability listen for and receive RPC events.
	/// </summary>
	[PublicAPI]
	public interface IRpcAttach
	{
		void OnRaw(Delegate callback);

		void On(Action<IRpcEvent> callback);

		void On<T>(Action<IRpcEvent, T> callback);

		void On<T1, T2>(Action<IRpcEvent, T1, T2> callback);

		void On<T1, T2, T3>(Action<IRpcEvent, T1, T2, T3> callback);

		void On<T1, T2, T3, T4>(Action<IRpcEvent, T1, T2, T3, T4> callback);

		void On<T1, T2, T3, T4, T5>(Action<IRpcEvent, T1, T2, T3, T4, T5> callback);
	}
}
