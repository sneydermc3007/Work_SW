export interface Data {
    id: number;
    name: string;
    invoice: Invoice[];
  }
  
  export interface Invoice {
    date: string;
    items: Item[];
  }
  
  export interface Item {
    product: string;
    quantity: number;
    total: number;
  }