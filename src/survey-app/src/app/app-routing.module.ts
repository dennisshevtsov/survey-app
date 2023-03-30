import { NgModule     } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Routes       } from '@angular/router';

import { AddSurveyComponent     } from './components';
import { SearchSurveysComponent } from './components';
import { UpdateSurveyComponent  } from './components';

const routes: Routes = [
  {
    path: 'survey',
    component: SearchSurveysComponent,
  },
  {
    path: 'survey/new',
    component: AddSurveyComponent,
  },
  {
    path: 'survey/:surveyId',
    component: UpdateSurveyComponent,
  },
  {
    path: '**',
    pathMatch: 'full',
    redirectTo: 'survey',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
