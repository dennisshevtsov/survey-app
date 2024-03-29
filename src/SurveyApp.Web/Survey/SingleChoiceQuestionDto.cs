﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.Survey.Web;

public sealed class SingleChoiceQuestionDto : QuestionDtoBase
{
  public SingleChoiceQuestionDto() : base()
  {
    Choices = Array.Empty<string>();
    Answer  = string.Empty;
  }

  public SingleChoiceQuestionDto(SingleChoiceQuestionEntity question)
  {
    Text         = question.Text;
    Choices      = question.Choices;
    Answer       = question.Answer;
    QuestionType = question.QuestionType;
  }

  public string[] Choices { get; set; }

  public string? Answer { get; set; }

  public override QuestionEntityBase ToQuestionEntity() => new SingleChoiceQuestionEntity
  (
    text   : Text,
    choices: Choices,
    answer : null
  );
}
