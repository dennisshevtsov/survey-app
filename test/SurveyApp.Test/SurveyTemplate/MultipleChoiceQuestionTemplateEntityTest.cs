﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.SurveyTemplate.Test;

[TestClass]
public sealed class MultipleChoiceQuestionTemplateEntityTest
{
  [TestMethod]
  public void New_FullListOfParameters_TextFilled()
  {
    // Arrange
    string text = Guid.NewGuid().ToString();

    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : text,
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: new ExecutingContext()
    );

    // Assert
    Assert.AreEqual(text, multipleChoiceQuestionTemplateEntity!.Text);
  }

  [TestMethod]
  public void New_FullListOfParameters_ChoicesFilled()
  {
    // Arrange
    string[] choices = new[]
    {
      Guid.NewGuid().ToString(),
      Guid.NewGuid().ToString(),
      Guid.NewGuid().ToString(),
    };

    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      choices: choices,
      context: new ExecutingContext()
    );

    // Assert
    Assert.AreEqual(choices, multipleChoiceQuestionTemplateEntity!.Choices);
  }

  [TestMethod]
  public void New_FullListOfParameters_QuestionTypeIsMultipleChoice()
  {
    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: new ExecutingContext()
    );

    // Assert
    Assert.AreEqual(QuestionType.MultipleChoice, multipleChoiceQuestionTemplateEntity!.QuestionType);
  }

  [TestMethod]
  public void New_NoText_NullReturned()
  {
    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : string.Empty,
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: new ExecutingContext()
    );

    // Assert
    Assert.IsNull(multipleChoiceQuestionTemplateEntity);
  }

  [TestMethod]
  public void New_NoText_ContextHasError()
  {
    // Arrange
    ExecutingContext context = new();

    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : string.Empty,
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: context
    );

    // Assert
    Assert.IsTrue(context.HasErrors);
  }

  [TestMethod]
  public void New_NoChoices_NullReturned()
  {
    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : string.Empty,
      choices: Array.Empty<string>(),
      context: new ExecutingContext()
    );

    // Assert
    Assert.IsNull(multipleChoiceQuestionTemplateEntity);
  }

  [TestMethod]
  public void New_NoChoices_ContextHasError()
  {
    // Arrange
    ExecutingContext context = new();

    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : string.Empty,
      choices: Array.Empty<string>(),
      context: context
    );

    // Assert
    Assert.IsTrue(context.HasErrors);
  }

  [TestMethod]
  public void New_EmptyChoice_NullReturned()
  {
    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : string.Empty,
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        string.Empty,
      },
      context: new ExecutingContext()
    );

    // Assert
    Assert.IsNull(multipleChoiceQuestionTemplateEntity);
  }

  [TestMethod]
  public void New_EmptyChoice_ContextHasError()
  {
    // Arrange
    ExecutingContext context = new();

    // Act
    MultipleChoiceQuestionTemplateEntity? multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : string.Empty,
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        string.Empty,
      },
      context: context
    );

    // Assert
    Assert.IsTrue(context.HasErrors);
  }

  [TestMethod]
  public void Constructor_MultipleChoiceQuestionTemplateEntity_TextFilled()
  {
    // Arrange
    MultipleChoiceQuestionTemplateEntity? originalMultipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: new ExecutingContext()
    );

    // Act
    MultipleChoiceQuestionTemplateEntity newMultipleChoiceQuestionTemplateEntity = new(originalMultipleChoiceQuestionTemplateEntity!);

    // Assert
    Assert.AreEqual(originalMultipleChoiceQuestionTemplateEntity!.Text, newMultipleChoiceQuestionTemplateEntity.Text);
  }

  [TestMethod]
  public void Constructor_MultipleChoiceQuestionTemplateEntity_ChoicesFilled()
  {
    // Arrange
    MultipleChoiceQuestionTemplateEntity? originalMultipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: new ExecutingContext()
    );

    // Act
    MultipleChoiceQuestionTemplateEntity newMultipleChoiceQuestionTemplateEntity = new(originalMultipleChoiceQuestionTemplateEntity!);

    // Assert
    Assert.AreEqual(originalMultipleChoiceQuestionTemplateEntity!.Choices, newMultipleChoiceQuestionTemplateEntity.Choices);
  }

  [TestMethod]
  public void Constructor_MultipleChoiceQuestionTemplateEntity_QuestionTypeIsMultipleChoice()
  {
    // Arrange
    MultipleChoiceQuestionTemplateEntity? originalMultipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: new ExecutingContext()
    );

    // Act
    MultipleChoiceQuestionTemplateEntity newMultipleChoiceQuestionTemplateEntity = new(originalMultipleChoiceQuestionTemplateEntity!);

    // Assert
    Assert.AreEqual(QuestionType.MultipleChoice, newMultipleChoiceQuestionTemplateEntity.QuestionType);
  }
}
