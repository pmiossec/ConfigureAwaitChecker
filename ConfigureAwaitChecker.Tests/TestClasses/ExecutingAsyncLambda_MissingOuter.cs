﻿using System;
using System.Threading.Tasks;
using ConfigureAwaitChecker.Tests;
using ConfigureAwaitChecker.Tests.TestClasses;

[CheckerTests.ExpectedResult(new[] { true, false })]
public class ExecutingAsyncLambda_MissingOuter : TestClassBase
{
	public async Task FooBar()
	{
		await ((Func<Task>)(async () => await Task.Delay(1).ConfigureAwait(false)))();
	}
}
