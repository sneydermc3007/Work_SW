import { Component } from '@angular/core';
import { DataService, Data } from '../services/data.service';
import { ConexionService } from '../services/conexion.service';

@Component({
  selector: 'app-client',
  templateUrl: 'client.page.html',
  styleUrls: ['client.page.scss'],
})
export class ClientPage {
  
  clientes: any[];

  constructor(private dataService: DataService,
              private conexionService: ConexionService) {}

  getData(): Data[] {
    return this.dataService.getData();
  }

  cargarClientes(){
    this.conexionService.loadUsers().subscribe(
      (res: any) => {
        this.clientes = res.results;
      },
      (error) => {
        console.error("Esta fallando");
        console.error(error);
      }
    );
  }
}
