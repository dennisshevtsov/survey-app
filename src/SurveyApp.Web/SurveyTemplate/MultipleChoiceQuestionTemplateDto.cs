﻿namespace SurveyApp.SurveyTemplate.Web;

public sealed class MultipleChoiceQuestionTemplateDto : SurveyTemplateQuestionDtoBase
{
  public string[] Choices { get; set; } = Array.Empty<string>();
}