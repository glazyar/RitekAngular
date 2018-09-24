import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AccordionModule } from 'primeng/accordion';
import { MenuItem } from 'primeng/api';
import { DataTableModule, SharedModule } from 'primeng/primeng';
import { TableModule } from 'primeng/table';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { NavbarComComponent } from './navbar-com/navbar-com.component';
import { StartPageComComponent } from './start-page-com/start-page-com.component';
import { Routes, RouterModule } from '@angular/router';
import { SurveyComponent } from './survey/survey.component';

export const routes: Routes = [
    { path: '', redirectTo: 'start', pathMatch: 'full' },
    { path: 'start', component: StartPageComComponent },
    { path: 'survey', component: SurveyComponent },
    { path: '**', redirectTo: 'start' }
];
export function getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
}
@NgModule({
    imports: [
        BrowserModule, AccordionModule,
        DataTableModule, SharedModule, TableModule,
        HttpClientModule, FormsModule, ReactiveFormsModule,
        RouterModule.forRoot(routes)
    ],
    declarations: [
        AppComponent,
        NavbarComComponent,
        StartPageComComponent,
        SurveyComponent
    ],
    providers: [{ provide: 'BASE_URL', useFactory: getBaseUrl }],
    bootstrap: [AppComponent]
})
export class AppModule { }
