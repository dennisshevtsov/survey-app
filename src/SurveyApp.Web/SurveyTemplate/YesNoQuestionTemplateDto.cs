﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.SurveyTemplate.Web;

public sealed class YesNoQuestionTemplateDto : QuestionTemplateDtoBase
{
  public YesNoQuestionTemplateDto() { }

  public YesNoQuestionTemplateDto(YesNoQuestionTemplateEntity yesNoQuestionTemplateEntity)
  {
    Text         = yesNoQuestionTemplateEntity.Text;
    QuestionType = QuestionType.YesNo;
  }

  public override QuestionTemplateEntityBase? ToTemplateQuestionEntity(ExecutingContext context) =>
    YesNoQuestionTemplateEntity.New(Text, context);
}
