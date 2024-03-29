﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.Survey.Web.Test;

[TestClass]
public sealed class MultipleChoiceQuestionDtoTest
{
  [TestMethod]
  public void Constructor_MultipleChoiceQuestionEntity_TextFilled()
  {
    // Arrange
    MultipleChoiceQuestionEntity multipleChoiceQuestionEntity = new
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      answers: Array.Empty<string>()
    );

    // Act
    MultipleChoiceQuestionDto multipleChoiceQuestionDto = new(multipleChoiceQuestionEntity);

    // Assert
    Assert.AreEqual(multipleChoiceQuestionEntity.Text, multipleChoiceQuestionDto.Text);
  }

  [TestMethod]
  public void Constructor_MultipleChoiceQuestionEntity_ChoicesFilled()
  {
    // Arrange
    MultipleChoiceQuestionEntity multipleChoiceQuestionEntity = new
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      answers: Array.Empty<string>()
    );

    // Act
    MultipleChoiceQuestionDto multipleChoiceQuestionDto = new(multipleChoiceQuestionEntity);

    // Assert
    Assert.AreEqual(multipleChoiceQuestionEntity.Choices, multipleChoiceQuestionDto.Choices);
  }

  [TestMethod]
  public void ToQuestionEntity_MultipleChoiceQuestionDto_MultipleChoiceQuestionEntityReturned()
  {
    // Arrange
    MultipleChoiceQuestionDto multipleChoiceQuestionDto = new();

    // Act
    QuestionEntityBase questionEntity = multipleChoiceQuestionDto.ToQuestionEntity();

    // Assert
    Assert.IsInstanceOfType<MultipleChoiceQuestionEntity>(questionEntity);
  }

  [TestMethod]
  public void ToQuestionEntity_MultipleChoiceQuestionDto_TextFilled()
  {
    // Arrange
    MultipleChoiceQuestionDto multipleChoiceQuestionDto = new()
    {
      Text = Guid.NewGuid().ToString(),
    };

    // Act
    QuestionEntityBase questionEntity = multipleChoiceQuestionDto.ToQuestionEntity();

    // Assert
    Assert.AreEqual(multipleChoiceQuestionDto.Text, questionEntity.Text);
  }

  [TestMethod]
  public void ToQuestionEntity_MultipleChoiceQuestionDto_ChoicesFilled()
  {
    // Arrange
    MultipleChoiceQuestionDto multipleChoiceQuestionDto = new()
    {
      Choices = new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
    };

    // Act
    QuestionEntityBase questionEntity = multipleChoiceQuestionDto.ToQuestionEntity();

    // Assert
    Assert.AreEqual(multipleChoiceQuestionDto.Choices, ((MultipleChoiceQuestionEntity)questionEntity).Choices);
  }
}
