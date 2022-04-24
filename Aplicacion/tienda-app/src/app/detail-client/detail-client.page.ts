import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../services/data.service';
import { IonAccordionGroup } from '@ionic/angular';
import { Data } from '../interfaces/data.interface';

@Component({
  selector: 'app-detail-client',
  templateUrl: './detail-client.page.html',
  styleUrls: ['./detail-client.page.scss'],
})
export class DetailClientPage implements OnInit {
  public data: Data;
  @ViewChild(IonAccordionGroup, { static: true }) accordionGroup: IonAccordionGroup;

  constructor(
    private dataService: DataService,
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = this.activatedRoute.snapshot.paramMap.get('id');
    this.data = this.dataService.getDataById(parseInt(id, 10));
    console.log(this.data);
  }

  getBackButtonText() {
    const win = window as any;
    const mode = win && win.Ionic && win.Ionic.mode;
    return this.data.name;
  }
}
