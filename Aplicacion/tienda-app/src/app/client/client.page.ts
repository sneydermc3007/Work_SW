import { Component } from '@angular/core';
import { DataService, Data } from '../services/data.service';

@Component({
  selector: 'app-client',
  templateUrl: 'client.page.html',
  styleUrls: ['client.page.scss'],
})
export class ClientPage {
  constructor(private dataService: DataService) {}

  getData(): Data[] {
    return this.dataService.getData();
  }

}
