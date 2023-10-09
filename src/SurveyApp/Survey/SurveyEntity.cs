﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using SurveyApp.SurveyTemplate;

namespace SurveyApp.Survey;

public sealed class SurveyEntity
{
  public SurveyEntity(Guid surveyId, SurveyState state, string title, string description, string candidateName, QuestionEntityBase[] questions)
  {
    SurveyId      = surveyId;
    State         = state;
    Title         = title;
    Description   = description;
    CandidateName = candidateName;
    Questions     = questions;
  }

  public SurveyEntity(string title, string description, string candidateName, QuestionEntityBase[] questions)
  : this
  (
    surveyId     : Guid.NewGuid(),
    state        : SurveyState.Draft,
    title        : title,
    description  : description,
    candidateName: candidateName,
    questions    : questions
  )
  { }

  public SurveyEntity(SurveyTemplateEntity surveyTemplateEntity)
  : this
  (
    title        : surveyTemplateEntity.Title,
    description  : surveyTemplateEntity.Description,
    candidateName: string.Empty,
    questions    : QuestionEntityBase.Copy(surveyTemplateEntity.Questions)
  )
  { }

  public Guid SurveyId { get; private set; }

  public SurveyState State { get; private set; }

  public string Title { get; private set; }

  public string Description { get; private set; }

  public string CandidateName { get; private set; }

  public QuestionEntityBase[] Questions { get; private set; }

  public void MoveTo(SurveyState state, ExecutingContext context)
  {
    Validate(state, context);

    if (context.HasErrors)
    {
      return;
    }

    State = state;
  }

  public SurveyEntity Update(string title, string description, string candidateName, QuestionEntityBase[] questions)
  {
    Title         = title;
    Description   = description;
    CandidateName = candidateName;
    Questions     = questions;

    return this;
  }

  private void Validate(SurveyState state, ExecutingContext context)
  {
    if (state < SurveyState.Draft || state > SurveyState.Cancelled)
    {
      context.AddError("Unknown state.");
    }

    if (State != SurveyState.Ready && state == SurveyState.Done)
    {
      context.AddError("You can move a survey to the done state only if this survey is in the ready state.");
    }

    if (State == SurveyState.Done || State == SurveyState.Cancelled)
    {
      context.AddError("You cannot change a state of a done or cancelled survey.");
    }
  }

  private void Validate(string title, string description, string candidateName, ExecutingContext context)
  {
    if (State != SurveyState.Draft)
    {
      context.AddError("You can update only draft surveys.");

      return;
    }

    if (string.IsNullOrWhiteSpace(title))
    {
      context.AddError("Title is required.");
    }

    if (string.IsNullOrWhiteSpace(description))
    {
      context.AddError("Description is required.");
    }

    if (string.IsNullOrWhiteSpace(candidateName))
    {
      context.AddError("Candidate Name is required.");
    }
  }
}
