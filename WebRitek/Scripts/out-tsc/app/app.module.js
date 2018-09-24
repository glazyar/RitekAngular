"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var accordion_1 = require("primeng/accordion");
var primeng_1 = require("primeng/primeng");
var table_1 = require("primeng/table");
var http_1 = require("@angular/common/http");
var forms_1 = require("@angular/forms");
var app_component_1 = require("./app.component");
var navbar_com_component_1 = require("./navbar-com/navbar-com.component");
var start_page_com_component_1 = require("./start-page-com/start-page-com.component");
var router_1 = require("@angular/router");
var survey_component_1 = require("./survey/survey.component");
exports.routes = [
    { path: '', redirectTo: 'start', pathMatch: 'full' },
    { path: 'start', component: start_page_com_component_1.StartPageComComponent },
    { path: 'survey', component: survey_component_1.SurveyComponent },
    { path: '**', redirectTo: 'start' }
];
function getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
}
exports.getBaseUrl = getBaseUrl;
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [
                platform_browser_1.BrowserModule, accordion_1.AccordionModule,
                primeng_1.DataTableModule, primeng_1.SharedModule, table_1.TableModule,
                http_1.HttpClientModule, forms_1.FormsModule, forms_1.ReactiveFormsModule,
                router_1.RouterModule.forRoot(exports.routes)
            ],
            declarations: [
                app_component_1.AppComponent,
                navbar_com_component_1.NavbarComComponent,
                start_page_com_component_1.StartPageComComponent,
                survey_component_1.SurveyComponent
            ],
            providers: [{ provide: 'BASE_URL', useFactory: getBaseUrl }],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map