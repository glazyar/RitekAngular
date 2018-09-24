import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StartPageComComponent } from './start-page-com.component';

describe('StartPageComComponent', () => {
  let component: StartPageComComponent;
  let fixture: ComponentFixture<StartPageComComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StartPageComComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StartPageComComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
