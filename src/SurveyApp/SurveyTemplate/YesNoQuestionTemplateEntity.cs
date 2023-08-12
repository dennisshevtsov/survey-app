﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.SurveyTemplate;

public sealed class YesNoQuestionTemplateEntity : QuestionTemplateEntityBase
{
  public override SurveyQuestionType QuestionType => SurveyQuestionType.YesNo;
}