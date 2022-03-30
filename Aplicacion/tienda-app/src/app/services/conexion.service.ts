import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ConexionService {

  constructor( public http: HttpClient ) { }

  loadUsers(){
    return this.http.get('http://localhost:7071/api/v1/clientes')
  }
}
