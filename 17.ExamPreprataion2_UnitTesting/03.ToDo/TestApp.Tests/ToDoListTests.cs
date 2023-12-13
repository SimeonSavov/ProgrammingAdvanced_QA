using System;
using Microsoft.VisualBasic;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "My first task";
        DateTime time = DateTime.Today;

        this._toDoList.AddTask(title, time);

        // Act
        var result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain($"[ ] My first task - Due:"));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "To complete";
        DateTime time = DateTime.Today;

        this._toDoList.AddTask(title, time);
        this._toDoList.CompleteTask(title);

        // Act
        var result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain($"[✓] To complete - Due:"));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string title = "To complete this one";

        // Act + Assert
        Assert.That(() => this._toDoList.CompleteTask(title), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo("To-Do List:"));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string title = "My first task";
        DateTime time = DateTime.Today;
        this._toDoList.AddTask(title, time);

        string title2 = "To complete";
        DateTime time2 = DateTime.Today;
        this._toDoList.AddTask(title2, time2);
        this._toDoList.CompleteTask(title2);

        // Act
        var result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain($"[ ] My first task - Due:"));
        Assert.That(result, Does.Contain($"[✓] To complete - Due:"));
    }
}
