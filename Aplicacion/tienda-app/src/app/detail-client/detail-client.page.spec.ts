import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';
import { RouterModule } from '@angular/router';
import { DetailClientPageRoutingModule } from './detail-client-routing.module';

import { DetailClientPage } from './detail-client.page';

describe('DetailClientPage', () => {
  let component: DetailClientPage;
  let fixture: ComponentFixture<DetailClientPage>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ DetailClientPage ],
      imports: [IonicModule.forRoot(), DetailClientPageRoutingModule, RouterModule.forRoot([])]
    }).compileComponents();

    fixture = TestBed.createComponent(DetailClientPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
