#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using Apple.Core.Tests;
using NUnit.Framework.Interfaces;
using UnityEngine.TestRunner;
using UnityEngine;

[assembly: TestRunCallback(typeof(PHASETestRunner))]
public class PHASETestRunner : AppleTestRunner
{
    public override void RunFinished(ITestResult testResults)
    {
        Debug.Log("Calling AppleTestRunner.RunFinished");
        base.RunFinished(testResults);
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
