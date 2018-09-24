"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var survey_service_1 = require("./survey.service");
describe('SurveyService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(survey_service_1.SurveyService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=survey.service.spec.js.map