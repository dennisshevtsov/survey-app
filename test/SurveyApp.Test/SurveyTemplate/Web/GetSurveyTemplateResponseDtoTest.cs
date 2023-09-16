﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.SurveyTemplate.Web.Test;

[TestClass]
public sealed class GetSurveyTemplateResponseDtoTest
{
  [TestMethod]
  public void Constructor_SurveyTemplateEntity_PropertiesFilled()
  {
    // Arrange
    SurveyTemplateEntity surveyTemplateEntity = new(string.Empty, string.Empty, Array.Empty<QuestionTemplateEntityBase>());

    // Act
    GetSurveyTemplateResponseDto getSurveyTemplateResponseDto = new(surveyTemplateEntity);

    // Assert
    Assert.AreEqual(surveyTemplateEntity.SurveyTemplateId, getSurveyTemplateResponseDto.SurveyTemplateId);
    Assert.AreEqual(surveyTemplateEntity.Description, getSurveyTemplateResponseDto.Description);
    Assert.AreEqual(surveyTemplateEntity.Questions.Length, getSurveyTemplateResponseDto.Questions.Length);
  }
}