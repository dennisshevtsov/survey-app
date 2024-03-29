﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace SurveyApp;

public enum QuestionType : int
{
  Text           = 0,
  YesNo          = 1,
  MultipleChoice = 2,
  SingleChoice   = 3,
}
