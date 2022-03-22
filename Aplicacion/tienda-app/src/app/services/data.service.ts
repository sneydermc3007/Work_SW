import { Injectable } from '@angular/core';

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
  total:number;
}

@Injectable({
  providedIn: 'root'
})
export class DataService {
  public data: Data[] = [
    {
      id: 0,
      name: 'Camila Martínez',
      invoice: [
        {
          date: 'Factura 1 de mayo 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        },
        {
          date: 'Factura 3 de julio 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        }
      ],
    },
    {
      id: 1,
      name: 'Claudia Guarin',
      invoice: [
        {
          date: 'Factura 1 de enero 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        },
        {
          date: 'Factura 5 de febrero 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        }
      ],
    },
    {
      id: 2,
      name: 'Isabela Ospina',
      invoice: [
        {
          date: 'Factura 2 de2 marzo 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        },
        {
          date: 'Factura 3 de0 abril 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        }
      ],
    },
    {
      id: 3,
      name: 'Laura Ramirez',
      invoice: [
        {
          date: 'Factura 7 de diciembre 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        },
        {
          date: 'Factura 2 de8 octubre 2001',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        }
      ],
    },
    {
      id: 4,
      name: 'Luisa Gil',
      invoice: [
        {
          date: 'Factura 1 de0 marzo 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        },
        {
          date: 'Factura 1 de5 marzo 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        }
      ],
    },
    {
      id: 5,
      name: 'Matias Salazar',
      invoice: [
        {
          date: 'Factura 2 de2 mayo 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        },
        {
          date: 'Factura 3 de1 diciembre 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        }
      ],
    },
    {
      id: 6,
      name: 'Sebastian Lopez',
      invoice: [
        {
          date: 'Factura 6 de junio 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        },
        {
          date: 'Factura 8 de agosto 2019',
          items: [
            {
              product: 'Producto 1',
              quantity: 1,
              total:1000
            }
          ],
        }
      ],
    }
    
  ];

  constructor() { }

  public getData(): Data[] {
    return this.data;
  }

  public getDataById(id: number): Data {
    return this.data[id];
  }
}
