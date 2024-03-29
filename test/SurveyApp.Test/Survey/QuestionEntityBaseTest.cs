﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using SurveyApp.SurveyTemplate;

namespace SurveyApp.Survey.Test;

[TestClass]
public sealed class QuestionEntityBaseTest
{
  [TestMethod]
  public void Copy_TextQuestionTemplateEntity_TextQuestionEntityReturned()
  {
    // Arrange
    TextQuestionTemplateEntity textQuestionTemplateEntity = TextQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      context: new ExecutingContext()
    )!;

    // Act
    QuestionEntityBase questionEntity = QuestionEntityBase.Copy(textQuestionTemplateEntity);

    // Assert
    Assert.IsInstanceOfType<TextQuestionEntity>(questionEntity);
  }

  [TestMethod]
  public void Copy_YesNoQuestionTemplateEntity_YesNoQuestionEntityReturned()
  {
    // Arrange
    YesNoQuestionTemplateEntity yesNoQuestionTemplateEntity = YesNoQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      context: new ExecutingContext()
    )!;

    // Act
    QuestionEntityBase questionEntity = QuestionEntityBase.Copy(yesNoQuestionTemplateEntity);

    // Assert
    Assert.IsInstanceOfType<YesNoQuestionEntity>(questionEntity);
  }

  [TestMethod]
  public void Copy_MultipleChoiceQuestionTemplateEntity_MultipleChoiceQuestionEntityReturned()
  {
    // Arrange
    MultipleChoiceQuestionTemplateEntity multipleChoiceQuestionTemplateEntity = MultipleChoiceQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: new ExecutingContext()
    )!;

    // Act
    QuestionEntityBase questionEntity = QuestionEntityBase.Copy(multipleChoiceQuestionTemplateEntity);

    // Assert
    Assert.IsInstanceOfType<MultipleChoiceQuestionEntity>(questionEntity);
  }

  [TestMethod]
  public void Copy_SingleChoiceQuestionTemplateEntity_SingleChoiceQuestionEntityReturned()
  {
    // Arrange
    SingleChoiceQuestionTemplateEntity singleChoiceQuestionTemplateEntity = SingleChoiceQuestionTemplateEntity.New
    (
      text   : Guid.NewGuid().ToString(),
      choices: new[]
      {
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
        Guid.NewGuid().ToString(),
      },
      context: new ExecutingContext()
    )!;

    // Act
    QuestionEntityBase questionEntity = QuestionEntityBase.Copy(singleChoiceQuestionTemplateEntity);

    // Assert
    Assert.IsInstanceOfType<SingleChoiceQuestionEntity>(questionEntity);
  }

  [TestMethod]
  public void Copy_UnknownQuestionTemplateEntity_NotSupportedExceptionThrown()
  {
    // Arrange
    UnknownQuestionTemplateEntity unknownQuestionTemplateEntity = new();

    // Act
    Action act = () => QuestionEntityBase.Copy(unknownQuestionTemplateEntity);

    // Assert
    Assert.ThrowsException<NotSupportedException>(act);
  }

  private sealed class UnknownQuestionTemplateEntity : QuestionTemplateEntityBase
  {
    public UnknownQuestionTemplateEntity() : base(string.Empty) { }

    public override QuestionType QuestionType => (QuestionType)100;

    public override bool Equals(QuestionTemplateEntityBase? other) => false;
  }
}
