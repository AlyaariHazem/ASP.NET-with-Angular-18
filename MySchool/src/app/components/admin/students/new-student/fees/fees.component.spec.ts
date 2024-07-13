import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeesComponent } from './fees.component';

describe('FeesComponent', () => {
  let component: FeesComponent;
  let fixture: ComponentFixture<FeesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FeesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
