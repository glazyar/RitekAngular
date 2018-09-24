import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class SurveyService {
    constructor(private http: HttpClient) { }
    getPlanOperNFT(kodTPP: number, month: number, year: number) {
        var URL = 'PlanOper/GetPlanOperNFT/' + kodTPP.toString() + '/' + month.toString() + '/' + year.toString();
        return this.http.get(URL);

    }
}

