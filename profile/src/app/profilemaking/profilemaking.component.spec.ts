import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfilemakingComponent } from './profilemaking.component';

describe('ProfilemakingComponent', () => {
  let component: ProfilemakingComponent;
  let fixture: ComponentFixture<ProfilemakingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProfilemakingComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfilemakingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
