﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.SurveyTemplate.Test;

[TestClass]
public sealed class MultipleChoiceQuestionTemplateEntityTest
{
  [TestMethod]
  public void Constructor_Text_TextFilled()
  {
    // Arrange
    string text = Guid.NewGuid().ToString();

    // Act
    MultipleChoiceQuestionTemplateEntity multipleChoiceQuestionTemplateEntity = new
    (
      text   : text,
      choices: Array.Empty<string>()
    );

    // Assert
    Assert.AreEqual(text, multipleChoiceQuestionTemplateEntity.Text);
  }
}
