﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.Survey.Web;

public sealed class YesNoAnswerDto : AnswerDtoBase
{
  public YesNo Answer { get; set; }

  public override void SetAnswer(QuestionEntityBase questionEntity)
  {
    if (questionEntity is YesNoQuestionEntity yesNoQuestionEntity)
    {
      yesNoQuestionEntity.SetAnswer(Answer);
    }
  }
}
