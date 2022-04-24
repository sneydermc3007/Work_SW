export interface Data {
    id: number;
    name: string;
    factura: Invoice[];
  }
  
  export interface Invoice {
    date: string;
    articulos: Item[];
  }
  
  export interface Item {
    producto: string;
    cantidad: number;
    total: number;
  }