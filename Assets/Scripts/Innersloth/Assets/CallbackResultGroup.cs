/// <copyright file="CallbackResultGroup.cs" company="Innersloth">
/// Copyright (c) 2024 All Rights Reserved
/// </copyright>
using System;

namespace Innersloth.Assets
{
	public class CallbackResultGroup
	{
		private CallbackGroup onError;

		private CallbackGroup onSuccess;

		private CallbackGroup onFinished;

		public void AddOnSuccess(Action callback)
		{
		}

		public void AddOnError(Action callback)
		{
		}

		public void AddOnFinished(Action callback)
		{
		}

		public void CallSuccessAndClear()
		{
		}

		public void CallErrorAndClear()
		{
		}

		public void CallFinishedAndClear()
		{
		}

		public void Clear()
		{
		}

		public void Destroy()
		{
		}
	}
}
