﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.Survey.Web;

public sealed class MultipleChoiceQuestionDto : QuestionDtoBase
{
  public MultipleChoiceQuestionDto() : base()
  {
    Choices = Array.Empty<string>();
    Answers = Array.Empty<string>();
  }

  public MultipleChoiceQuestionDto(MultipleChoiceQuestionEntity question)
  {
    Text         = question.Text;
    Choices      = question.Choices;
    Answers      = question.Answers;
    QuestionType = question.QuestionType;
  }

  public string[] Choices { get; set; }

  public string[] Answers { get; set; }

  public override QuestionEntityBase ToQuestionEntity() => new MultipleChoiceQuestionEntity
  (
    text   : Text,
    choices: Choices,
    answers: Array.Empty<string>()
  );
}
