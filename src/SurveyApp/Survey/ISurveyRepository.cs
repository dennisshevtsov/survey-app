﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp.Survey;

public interface ISurveyRepository
{
  public Task<SurveyEntity?> GetSurveyAsync(Guid surveyId, CancellationToken cancellationToken);

  public Task<SurveyEntity> AddSurveyAsync(SurveyEntity surveyEntity, CancellationToken cancellationToken);

  public Task UpdateSurveyAsync(SurveyEntity surveyEntity, CancellationToken cancellationToken);

  public Task DeleteSurveyAsync(Guid surveyId, CancellationToken cancellationToken);
}
