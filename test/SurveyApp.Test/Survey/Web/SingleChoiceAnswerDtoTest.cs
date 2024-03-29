﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.Survey.Web.Test;

[TestClass]
public sealed class SingleChoiceAnswerDtoTest
{
  [TestMethod]
  public void Update_SingleChoiceQuestionEntity_AnswerUpdated()
  {
    // Arrange
    string answer = Guid.NewGuid().ToString();

    SingleChoiceAnswerDto singleChoiceAnswerDto = new()
    {
      Answer = answer,
    };

    SingleChoiceQuestionEntity singleChoiceQuestionEntity = new
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        answer,
      },
      answer : null
    );

    // Act
    singleChoiceAnswerDto.SetAnswer(singleChoiceQuestionEntity, new ExecutingContext());

    // Assert
    Assert.AreEqual(answer, singleChoiceQuestionEntity.Answer);
  }

  [TestMethod]
  public void Update_UnknownAnswer_AnswerNotUpdated()
  {
    // Arrange
    SingleChoiceAnswerDto singleChoiceAnswerDto = new()
    {
      Answer = Guid.NewGuid().ToString(),
    };

    string answer = Guid.NewGuid().ToString();
    SingleChoiceQuestionEntity singleChoiceQuestionEntity = new
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      answer : answer
    );

    // Act
    singleChoiceAnswerDto.SetAnswer(singleChoiceQuestionEntity, new ExecutingContext());

    // Assert
    Assert.AreEqual(answer, singleChoiceQuestionEntity.Answer);
  }
}
