﻿using System.Threading.Tasks;
using ConfigureAwaitChecker.Tests;
using ConfigureAwaitChecker.Tests.TestClasses;

[CheckerTests.ExpectedResult(new[] { true })]
public class AwaitInIf_Missing : TestClassBase
{
	public async Task FooBar()
	{
		if (await Bool()) { }
	}
}
