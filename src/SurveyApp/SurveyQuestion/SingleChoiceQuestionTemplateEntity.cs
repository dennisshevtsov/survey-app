﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.SurveyQuestion;

public sealed class SingleChoiceQuestionTemplateEntity : SurveyQuestionTemplateEntityBase
{
  public SingleChoiceQuestionTemplateEntity() { }

  public SingleChoiceQuestionTemplateEntity(SingleChoiceQuestionTemplateEntity singleChoiceQuestionTemplateEntity)
  {
    Text = singleChoiceQuestionTemplateEntity.Text;
    Choices = singleChoiceQuestionTemplateEntity.Choices.Select(choice => choice).ToArray();
  }

  public override SurveyQuestionType QuestionType => SurveyQuestionType.SingleChoice;

  public string[] Choices { get; set; } = Array.Empty<string>();
}
