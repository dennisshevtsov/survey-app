﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.SurveyTemplate.Test;

[TestClass]
public sealed class SurveyTemplateEntityTest
{
  [TestMethod]
  public void Constructor_FullListOfParameters_SurveyTemplateIdFilled()
  {
    // Arrange
    Guid surveyTemplateId = Guid.NewGuid();

    // Act
    SurveyTemplateEntity surveyTemplateEntity = new
    (
      surveyTemplateId: surveyTemplateId,
      title           : string.Empty,
      description     : string.Empty,
      questions       : Array.Empty<QuestionTemplateEntityBase>()
    );

    // Assert
    Assert.AreEqual(surveyTemplateId, surveyTemplateEntity.SurveyTemplateId);
  }

  [TestMethod]
  public void Constructor_FullListOfParameters_TitleFilled()
  {
    // Arrange
    string title = Guid.NewGuid().ToString();

    // Act
    SurveyTemplateEntity surveyTemplateEntity = new
    (
      surveyTemplateId: default,
      title           : title,
      description     : string.Empty,
      questions       : Array.Empty<QuestionTemplateEntityBase>()
    );

    // title
    Assert.AreEqual(title, surveyTemplateEntity.Title);
  }

  [TestMethod]
  public void Constructor_FullListOfParameters_DescriptionFilled()
  {
    // Arrange
    string description = Guid.NewGuid().ToString();

    // Act
    SurveyTemplateEntity surveyTemplateEntity = new
    (
      surveyTemplateId: default,
      title           : string.Empty,
      description     : description,
      questions       : Array.Empty<QuestionTemplateEntityBase>()
    );

    // title
    Assert.AreEqual(description, surveyTemplateEntity.Description);
  }

  [TestMethod]
  public void Constructor_FullListOfParameters_QuestionsFilled()
  {
    // Arrange
    QuestionTemplateEntityBase[] questions = new QuestionTemplateEntityBase[0];

    // Act
    SurveyTemplateEntity surveyTemplateEntity = new
    (
      surveyTemplateId: default,
      title           : string.Empty,
      description     : string.Empty,
      questions       : questions
    );

    // title
    Assert.AreEqual(questions, surveyTemplateEntity.Questions);
  }

  [TestMethod]
  public void Constructor_ShortListOfParameters_SurveyTemplateIdFilled()
  {
    // Act
    SurveyTemplateEntity surveyTemplateEntity = new
    (
      title           : string.Empty,
      description     : string.Empty,
      questions       : Array.Empty<QuestionTemplateEntityBase>()
    );

    // Assert
    Assert.AreNotEqual(default, surveyTemplateEntity.SurveyTemplateId);
  }

  [TestMethod]
  public void Constructor_ShortListOfParameters_TitleFilled()
  {
    // Arrange
    string title = Guid.NewGuid().ToString();

    // Act
    SurveyTemplateEntity surveyTemplateEntity = new
    (
      title           : title,
      description     : string.Empty,
      questions       : Array.Empty<QuestionTemplateEntityBase>()
    );

    // title
    Assert.AreEqual(title, surveyTemplateEntity.Title);
  }

  [TestMethod]
  public void Constructor_ShortListOfParameters_DescriptionFilled()
  {
    // Arrange
    string description = Guid.NewGuid().ToString();

    // Act
    SurveyTemplateEntity surveyTemplateEntity = new
    (
      title      : string.Empty,
      description: description,
      questions  : Array.Empty<QuestionTemplateEntityBase>()
    );

    // title
    Assert.AreEqual(description, surveyTemplateEntity.Description);
  }

  [TestMethod]
  public void Constructor_ShortListOfParameters_QuestionsFilled()
  {
    // Arrange
    QuestionTemplateEntityBase[] questions = new QuestionTemplateEntityBase[0];

    // Act
    SurveyTemplateEntity surveyTemplateEntity = new
    (
      title      : string.Empty,
      description: string.Empty,
      questions  : questions
    );

    // title
    Assert.AreEqual(questions, surveyTemplateEntity.Questions);
  }

  [TestMethod]
  public void Update_FullListOfParameters_TitleFilled()
  {
    // Arrange
    string title = Guid.NewGuid().ToString();

    SurveyTemplateEntity surveyTemplateEntity = new
    (
      title      : string.Empty,
      description: string.Empty,
      questions  : Array.Empty<QuestionTemplateEntityBase>()
    );

    // Act
    surveyTemplateEntity.Update(title, string.Empty, Array.Empty<QuestionTemplateEntityBase>());

    // title
    Assert.AreEqual(title, surveyTemplateEntity.Title);
  }

  [TestMethod]
  public void Update_FullListOfParameters_DescriptionFilled()
  {
    // Arrange
    string description = Guid.NewGuid().ToString();

    SurveyTemplateEntity surveyTemplateEntity = new
    (
      title      : string.Empty,
      description: string.Empty,
      questions  : Array.Empty<QuestionTemplateEntityBase>()
    );

    // Act
    surveyTemplateEntity.Update(string.Empty, description, Array.Empty<QuestionTemplateEntityBase>());

    // title
    Assert.AreEqual(description, surveyTemplateEntity.Description);
  }

  [TestMethod]
  public void Update_FullListOfParameters_QuestionsFilled()
  {
    // Arrange
    QuestionTemplateEntityBase[] questions = new QuestionTemplateEntityBase[0];

    SurveyTemplateEntity surveyTemplateEntity = new
    (
      title      : string.Empty,
      description: string.Empty,
      questions  : Array.Empty<QuestionTemplateEntityBase>()
    );

    // Act
    surveyTemplateEntity.Update(string.Empty, string.Empty, questions);

    // title
    Assert.AreEqual(questions, surveyTemplateEntity.Questions);
  }
}