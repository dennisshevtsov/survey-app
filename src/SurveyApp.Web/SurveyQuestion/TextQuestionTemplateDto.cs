﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.SurveyQuestion.Web;

public sealed class TextQuestionTemplateDto : SurveyQuestionDtoBase
{
    public TextQuestionTemplateDto() { }

    public TextQuestionTemplateDto(TextQuestionEntity textQuestionTemplateEntity)
    {
        Text = textQuestionTemplateEntity.Text;
    }

    public override SurveyQuestionEntityBase ToQuestionTemplateEntity() => new TextQuestionEntity
    {
        Text = Text,
    };
}