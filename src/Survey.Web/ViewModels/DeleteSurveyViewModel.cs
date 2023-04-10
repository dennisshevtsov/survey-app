﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace Survey.Web.ViewModels
{
  using Survey.Domain.Entities;

  /// <summary>Represents data to delete a survey.</summary>
  public sealed class DeleteSurveyViewModel : ISurveyIdentity
  {
    /// <summary>Gets an object that represents an identity of a survey.</summary>
    public Guid SurveyId { get; set; }
  }
}
