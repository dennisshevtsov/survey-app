﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using Composable;

namespace SurveyApp.Survey.Web;

public sealed class GetSurveyRequestDto : IComposable
{
  public GetSurveyRequestDto() { }

  public GetSurveyRequestDto(SurveyEntity surveyEntity)
  {
    SurveyId = surveyEntity.SurveyId;
  }

  public Guid SurveyId { get; set; }
}
