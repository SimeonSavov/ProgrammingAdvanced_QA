using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            ["Simeon"] = 6,
            ["Ivan"] = 5,
            ["Boyan"] = 4,
            ["Mitko"] = 3,
            ["Yoni"] = 2,
        };

        // Act
        string result = Grades.GetBestStudents(gradesDict);
        string expected = $"Simeon with average grade 6.00{Environment.NewLine}" +
            $"Ivan with average grade 5.00{Environment.NewLine}" +
            $"Boyan with average grade 4.00";

        // Assert
        Assert.That(result, Is.EqualTo(expected)); 
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
        };

        // Act
        string result = Grades.GetBestStudents(grades);
        string expected = "";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            ["Simeon"] = 6,
            ["Yoni"] = 2,
        };

        // Act
        string result = Grades.GetBestStudents(gradesDict);
        string expected = $"Simeon with average grade 6.00{Environment.NewLine}" +
            $"Yoni with average grade 2.00";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> gradesDict = new()
        {
            ["Simeon"] = 5,
            ["Ivan"] = 5,
            ["Boyan"] = 5,
            ["Mitko"] = 5,
            ["Yoni"] = 5,
        };

        // Act
        string result = Grades.GetBestStudents(gradesDict);
        string expected = $"Boyan with average grade 5.00{Environment.NewLine}" +
            $"Ivan with average grade 5.00{Environment.NewLine}" +
            $"Mitko with average grade 5.00";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
