﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using Composable;

namespace SurveyApp.SurveyTemplate.Web;

public sealed class AddSurveyTemplateRequestDto : IComposable
{
  public string Title { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public QuestionTemplateDtoBase[] Questions { get; set; } = Array.Empty<QuestionTemplateDtoBase>();

  public SurveyTemplateEntity? ToSurveyTemplateEntity(ExecutingContext context)
  {
    QuestionTemplateEntityBase[] questionTemplateEntityCollection =
      QuestionTemplateDtoBase.ToQuestionTemplateEntityCollection(Questions, context);

    SurveyTemplateEntity? surveyTemplateEntity = SurveyTemplateEntity.New
    (
      title      : Title,
      description: Description,
      questions  : questionTemplateEntityCollection,
      context    : context
    );

    return surveyTemplateEntity;
  }
}
