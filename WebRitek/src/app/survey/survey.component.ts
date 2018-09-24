import { Component, OnInit } from '@angular/core';
import { SurveyService } from './survey.service';
@Component({
  selector: 'app-survey',
  templateUrl: './survey.component.html',
  styleUrls: ['./survey.component.css']
})
export class SurveyComponent implements OnInit {
    dataPlan: any;
    dataEdit: planOperNFT[];

    constructor(private surveyService:SurveyService) {
        
    }

    ngOnInit() {
        this.dataEdit = [];
        var data = this.surveyService.getPlanOperNFT(2, 1, 2018);
        data.subscribe(data => {
            this.dataPlan = data;
        });
        
  }

}
interface planOperNFT {
    kodTPP: number;
    RangeNumber: number;
    ObjectKod: number;
    ObjectType: string;
    Title: string;
    PlanMonth: number;
    GraphicMonth: number;
}