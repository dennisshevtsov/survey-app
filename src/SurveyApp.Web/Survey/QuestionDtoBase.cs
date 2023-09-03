﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using System.Text.Json.Serialization;

namespace SurveyApp.Survey.Web;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "questionType")]
[JsonDerivedType(typeof(TextQuestionDto), (int)QuestionType.Text)]
[JsonDerivedType(typeof(YesNoQuestionDto), (int)QuestionType.YesNo)]
[JsonDerivedType(typeof(MultipleChoiceQuestionDto), (int)QuestionType.MultipleChoice)]
[JsonDerivedType(typeof(SingleChoiceQuestionDto), (int)QuestionType.SingleChoice)]
public abstract class QuestionDtoBase
{
  public string Text { get; set; } = string.Empty;

  public QuestionType QuestionType { get; set; }

  public abstract QuestionEntityBase ToQuestionEntity();

  public static QuestionDtoBase FromQuestionTemplateEntity(QuestionEntityBase questionEntity) =>
    questionEntity.QuestionType switch
    {
      QuestionType.Text => new TextQuestionDto((TextQuestionEntity)questionEntity),
      QuestionType.YesNo => new YesNoQuestionDto((YesNoQuestionEntity)questionEntity),
      QuestionType.MultipleChoice => new MultipleChoiceQuestionDto((MultipleChoiceQuestionEntity)questionEntity),
      QuestionType.SingleChoice => new SingleChoiceQuestionDto((SingleChoiceQuestionEntity)questionEntity),
      _ => throw new NotSupportedException("Unknown question type."),
    };

  public static List<QuestionEntityBase> ToQuestionEntityCollection(QuestionDtoBase[] questionDtoCollection)
  {
    List<QuestionEntityBase> questionEntityCollection = new(questionDtoCollection.Length);

    for (int i = 0; i < questionDtoCollection.Length; i++)
    {
      questionEntityCollection.Add(questionDtoCollection[i].ToQuestionEntity());
    }

    return questionEntityCollection;
  }
}
