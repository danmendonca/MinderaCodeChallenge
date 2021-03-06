// <copyright file="ChallengeClusterSolutionTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinderaCodeChallenge;

namespace MinderaCodeChallenge.Tests
{
    /// <summary>This class contains parameterized unit tests for ChallengeClusterSolution</summary>
    [PexClass(typeof(ChallengeClusterSolution))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ChallengeClusterSolutionTest
    {
        /// <summary>Test stub for GetClosestClusterIndex(List`1&lt;Cluster&gt;, Int32)</summary>
        [PexMethod]
        public int GetClosestClusterIndexTest(
            [PexAssumeUnderTest]ChallengeClusterSolution target,
            List<Cluster> clusters,
            int value
        )
        {
            int result = target.GetClosestClusterIndex(clusters, value);
            return result;
            // TODO: add assertions to method ChallengeClusterSolutionTest.GetClosestClusterIndexTest(ChallengeClusterSolution, List`1<Cluster>, Int32)
        }

        /// <summary>Test stub for Group(Int32[], Int32)</summary>
        [PexMethod]
        public int[][] GroupTest(
            [PexAssumeUnderTest]ChallengeClusterSolution target,
            int[] values,
            int groups
        )
        {
            int[][] result = target.Group(values, groups);
            return result;
            // TODO: add assertions to method ChallengeClusterSolutionTest.GroupTest(ChallengeClusterSolution, Int32[], Int32)
        }
    }
}
