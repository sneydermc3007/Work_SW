import { Injectable } from '@angular/core';
import { Http, HttpResponse } from '@capacitor-community/http';
import { Data } from '../interfaces/data.interface';



@Injectable({
  providedIn: 'root'
})
export class DataService {
  public data: Data[] = [];

  constructor() { }

  async loadUsers(){
    const options = {
      url: 'https://solucioneswiga2810snakemc1986.azurewebsites.net/api/v1/clientes',
      headers: { 'content-type': 'application/json' },
    };

    const response = await Http.get(options);
    this.data = response.data.clientes
    return response
  }

  public getDataById(id: number): Data {
    return this.data[id-1];
  }
}
