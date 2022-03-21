import { Component } from '@angular/core';
import { DataService, Data } from '../services/data.service';

@Component({
  selector: 'app-client',
  templateUrl: 'client.page.html',
  styleUrls: ['client.page.scss'],
})
export class ClientPage {
  constructor(private dataService: DataService,
    ) {}

  refresh(ev) {
    setTimeout(() => {
      ev.detail.complete();
    }, 3000);
  }

  getData(): Data[] {
    return this.dataService.getData();
  }

}
