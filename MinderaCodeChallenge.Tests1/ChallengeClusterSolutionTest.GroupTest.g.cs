using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinderaCodeChallenge;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace MinderaCodeChallenge.Tests
{
    public partial class ChallengeClusterSolutionTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest63()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    intss = this.GroupTest(challengeClusterSolution, (int[])null, 0);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(0, intss.Length);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest681()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[0];
    intss = this.GroupTest(challengeClusterSolution, ints, 0);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(0, intss.Length);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest203()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[1];
    intss = this.GroupTest(challengeClusterSolution, ints, 0);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(0, intss.Length);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest828()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[1];
    intss = this.GroupTest(challengeClusterSolution, ints, 128);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(1, intss.Length);
    Assert.IsNotNull((object)(intss[0]));
    Assert.AreEqual<int>(1, intss[0].Length);
    Assert.AreEqual<int>(0, intss[0][0]);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest482()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[3];
    ints[0] = 16;
    ints[2] = 64;
    intss = this.GroupTest(challengeClusterSolution, ints, 2);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(2, intss.Length);
    Assert.IsNotNull((object)(intss[0]));
    Assert.AreEqual<int>(2, intss[0].Length);
    Assert.AreEqual<int>(0, intss[0][0]);
    Assert.AreEqual<int>(16, intss[0][1]);
    Assert.IsNotNull((object)(intss[1]));
    Assert.AreEqual<int>(1, intss[1].Length);
    Assert.AreEqual<int>(64, intss[1][0]);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest662()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[3];
    intss = this.GroupTest(challengeClusterSolution, ints, 1);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(1, intss.Length);
    Assert.IsNotNull((object)(intss[0]));
    Assert.AreEqual<int>(3, intss[0].Length);
    Assert.AreEqual<int>(0, intss[0][0]);
    Assert.AreEqual<int>(0, intss[0][1]);
    Assert.AreEqual<int>(0, intss[0][2]);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest786()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[3];
    ints[0] = 1592524933;
    ints[1] = 1969057606;
    ints[2] = -925165067;
    intss = this.GroupTest(challengeClusterSolution, ints, 6);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(3, intss.Length);
    Assert.IsNotNull((object)(intss[0]));
    Assert.AreEqual<int>(1, intss[0].Length);
    Assert.AreEqual<int>(-925165067, intss[0][0]);
    Assert.IsNotNull((object)(intss[1]));
    Assert.AreEqual<int>(1, intss[1].Length);
    Assert.AreEqual<int>(1969057606, intss[1][0]);
    Assert.IsNotNull((object)(intss[2]));
    Assert.AreEqual<int>(1, intss[2].Length);
    Assert.AreEqual<int>(1592524933, intss[2][0]);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest729()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[4];
    ints[1] = 1;
    ints[3] = 8;
    intss = this.GroupTest(challengeClusterSolution, ints, 5);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(4, intss.Length);
    Assert.IsNotNull((object)(intss[0]));
    Assert.AreEqual<int>(2, intss[0].Length);
    Assert.AreEqual<int>(0, intss[0][0]);
    Assert.AreEqual<int>(0, intss[0][1]);
    Assert.IsNotNull((object)(intss[1]));
    Assert.AreEqual<int>(1, intss[1].Length);
    Assert.AreEqual<int>(8, intss[1][0]);
    Assert.IsNotNull((object)(intss[2]));
    Assert.AreEqual<int>(1, intss[2].Length);
    Assert.AreEqual<int>(1, intss[2][0]);
    Assert.IsNotNull((object)(intss[3]));
    Assert.AreEqual<int>(0, intss[3].Length);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest238()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[4];
    ints[0] = 513;
    ints[1] = 1;
    ints[2] = 64;
    intss = this.GroupTest(challengeClusterSolution, ints, 2);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(2, intss.Length);
    Assert.IsNotNull((object)(intss[0]));
    Assert.AreEqual<int>(3, intss[0].Length);
    Assert.AreEqual<int>(0, intss[0][0]);
    Assert.AreEqual<int>(1, intss[0][1]);
    Assert.AreEqual<int>(64, intss[0][2]);
    Assert.IsNotNull((object)(intss[1]));
    Assert.AreEqual<int>(1, intss[1].Length);
    Assert.AreEqual<int>(513, intss[1][0]);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest521()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[8];
    ints[1] = 1;
    ints[2] = 4;
    ints[3] = 320;
    ints[5] = 16;
    ints[6] = 2;
    ints[7] = 256;
    intss = this.GroupTest(challengeClusterSolution, ints, 2);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(2, intss.Length);
    Assert.IsNotNull((object)(intss[0]));
    Assert.AreEqual<int>(6, intss[0].Length);
    Assert.AreEqual<int>(0, intss[0][0]);
    Assert.AreEqual<int>(0, intss[0][1]);
    Assert.AreEqual<int>(1, intss[0][2]);
    Assert.AreEqual<int>(2, intss[0][3]);
    Assert.AreEqual<int>(4, intss[0][4]);
    Assert.AreEqual<int>(16, intss[0][5]);
    Assert.IsNotNull((object)(intss[1]));
    Assert.AreEqual<int>(2, intss[1].Length);
    Assert.AreEqual<int>(320, intss[1][0]);
    Assert.AreEqual<int>(256, intss[1][1]);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void GroupTest645()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[16];
    intss = this.GroupTest(challengeClusterSolution, ints, 17);
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void GroupTest349()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[20];
    ints[0] = -1734134831;
    ints[1] = 799078761;
    ints[2] = 1;
    ints[3] = 4;
    ints[4] = 1;
    ints[5] = -1472908865;
    ints[6] = -2007514814;
    ints[7] = -1;
    ints[8] = 489131374;
    ints[9] = 845481679;
    intss = this.GroupTest(challengeClusterSolution, ints, 21);
}

[TestMethod]
[PexGeneratedBy(typeof(ChallengeClusterSolutionTest))]
public void GroupTest896()
{
    ChallengeClusterSolution challengeClusterSolution;
    int[][] intss;
    challengeClusterSolution = new ChallengeClusterSolution();
    int[] ints = new int[10];
    ints[1] = 1;
    ints[3] = 32;
    ints[4] = 64;
    ints[5] = 4;
    ints[6] = 20;
    ints[7] = 128;
    ints[8] = 512;
    ints[9] = 16;
    intss = this.GroupTest(challengeClusterSolution, ints, 7);
    Assert.IsNotNull((object)intss);
    Assert.AreEqual<int>(7, intss.Length);
    Assert.IsNotNull((object)(intss[0]));
    Assert.AreEqual<int>(3, intss[0].Length);
    Assert.AreEqual<int>(0, intss[0][0]);
    Assert.AreEqual<int>(0, intss[0][1]);
    Assert.AreEqual<int>(1, intss[0][2]);
    Assert.IsNotNull((object)(intss[1]));
    Assert.AreEqual<int>(1, intss[1].Length);
    Assert.AreEqual<int>(512, intss[1][0]);
    Assert.IsNotNull((object)(intss[2]));
    Assert.AreEqual<int>(1, intss[2].Length);
    Assert.AreEqual<int>(128, intss[2][0]);
    Assert.IsNotNull((object)(intss[3]));
    Assert.AreEqual<int>(1, intss[3].Length);
    Assert.AreEqual<int>(64, intss[3][0]);
    Assert.IsNotNull((object)(intss[4]));
    Assert.AreEqual<int>(1, intss[4].Length);
    Assert.AreEqual<int>(32, intss[4][0]);
    Assert.IsNotNull((object)(intss[5]));
    Assert.AreEqual<int>(2, intss[5].Length);
    Assert.AreEqual<int>(16, intss[5][0]);
    Assert.AreEqual<int>(20, intss[5][1]);
    Assert.IsNotNull((object)(intss[6]));
    Assert.AreEqual<int>(1, intss[6].Length);
    Assert.AreEqual<int>(4, intss[6][0]);
    Assert.IsNotNull((object)challengeClusterSolution);
    Assert.IsNotNull(challengeClusterSolution.Groups);
    Assert.IsTrue
        (object.ReferenceEquals(challengeClusterSolution.Groups, (object)intss));
}
    }
}
