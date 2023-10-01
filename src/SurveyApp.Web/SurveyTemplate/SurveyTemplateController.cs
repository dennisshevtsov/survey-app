﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace SurveyApp.SurveyTemplate.Web;

[ApiController]
[Route("api/survey-template")]
public sealed class SurveyTemplateController : ControllerBase
{
  private readonly ISurveyTemplateRepository _surveyTemplateRepository;

  public SurveyTemplateController(ISurveyTemplateRepository surveyTemplateRepository)
  {
    _surveyTemplateRepository = surveyTemplateRepository ?? throw new ArgumentNullException(nameof(surveyTemplateRepository));
  }

  [HttpGet("{surveyTemplateId}", Name = nameof(SurveyTemplateController.GetSurveyTemplate))]
  public async Task<IActionResult> GetSurveyTemplate([FromRoute] Guid surveyTemplateId, CancellationToken cancellationToken)
  {
    SurveyTemplateEntity? surveyTemplateEntity = await _surveyTemplateRepository.GetSurveyTemplateAsync(surveyTemplateId, cancellationToken);

    if (surveyTemplateEntity == null)
    {
      return NotFound();
    }

    return Ok(new GetSurveyTemplateResponseDto(surveyTemplateEntity));
  }

  [HttpPost(Name = nameof(SurveyTemplateController.AddSurveyTemplate))]
  public async Task<IActionResult> AddSurveyTemplate(
    AddSurveyTemplateRequestDto addSurveyTemplateRequestDto,
    CancellationToken cancellationToken)
  {
    ExecutedContext<SurveyTemplateEntity> newSurveyTemplateEntityContext =
      addSurveyTemplateRequestDto.ToSurveyTemplateEntity();

    if (newSurveyTemplateEntityContext.HasErrors)
    {
      return BadRequest(newSurveyTemplateEntityContext.Errors);
    }

    SurveyTemplateEntity surveyTemplateEntity =
      await _surveyTemplateRepository.AddSurveyTemplateAsync(
        newSurveyTemplateEntityContext.Rusult,
        cancellationToken);

    return CreatedAtAction(
      nameof(SurveyTemplateController.GetSurveyTemplate),
      new { surveyTemplateEntity.SurveyTemplateId },
      new GetSurveyTemplateResponseDto(surveyTemplateEntity));
  }

  [HttpPut("{surveyTemplateId}", Name = nameof(SurveyTemplateController.UpdateSurveyTemplate))]
  public async Task<IActionResult> UpdateSurveyTemplate(
    UpdateSurveyTemplateRequestDto updateSurveyTemplateRequestDto,
    CancellationToken cancellationToken)
  {
    SurveyTemplateEntity? surveyTemplateEntity =
      await _surveyTemplateRepository.GetSurveyTemplateAsync(
        updateSurveyTemplateRequestDto.SurveyTemplateId, cancellationToken);

    if (surveyTemplateEntity == null)
    {
      return NotFound();
    }

    ExecutedContext<SurveyTemplateEntity> updatedSurveyTemplateEntityContext =
      updateSurveyTemplateRequestDto.UpdateSurveyTemplate(surveyTemplateEntity);

    if (updatedSurveyTemplateEntityContext.HasErrors)
    {
      return BadRequest(updatedSurveyTemplateEntityContext.Errors);
    }

    await _surveyTemplateRepository.UpdateSurveyTemplateAsync(
      updatedSurveyTemplateEntityContext.Rusult,
      cancellationToken);

    return NoContent();
  }

  [HttpDelete("{surveyTemplateId}", Name = nameof(SurveyTemplateController.DeleteSurveyTemplate))]
  public async Task<IActionResult> DeleteSurveyTemplate(Guid surveyTemplateId, CancellationToken cancellationToken)
  {
    SurveyTemplateEntity? surveyTemplateEntity = await _surveyTemplateRepository.GetSurveyTemplateAsync(surveyTemplateId, cancellationToken);

    if (surveyTemplateEntity == null)
    {
      return NotFound();
    }

    await _surveyTemplateRepository.DeleteSurveyTemplateAsync(surveyTemplateId, cancellationToken);

    return NoContent();
  }
}
