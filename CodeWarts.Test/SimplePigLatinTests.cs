﻿using CodeWarts.Infrastructure.Implementations.SimplePigLatin;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class SimplePigLatinTests
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual("igPay atinlay siay oolcay", SimplePigLatin.PigIt("Pig latin is cool"));
        Assert.AreEqual("hisTay siay ymay tringsay", SimplePigLatin.PigIt("This is my string"));
    }
}