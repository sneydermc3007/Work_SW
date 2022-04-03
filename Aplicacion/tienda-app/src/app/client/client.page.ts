import { Component, OnInit } from '@angular/core';
import { Data } from '../interfaces/data.interface';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-client',
  templateUrl: 'client.page.html',
  styleUrls: ['client.page.scss'],
})
export class ClientPage implements OnInit{
  
  clientes: Data[] = [];

  constructor(private dataService: DataService) {}

  ngOnInit() {
    this.dataService.loadUsers().then(
      (res: any) => {
        //this.clientes = res.results;
        console.log("OK");
        console.log(res.data.clients);
        this.clientes = res.data.clients
      },
    );
  }
}
