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
  total: number;
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
              product: 'Cuaderno',
              quantity: 2,
              total: 10000
            },
            {
              product: 'Block',
              quantity: 1,
              total: 15000
            }
          ],
        },
        {
          date: 'Factura 3 de julio 2019',
          items: [
            {
              product: 'Borrador',
              quantity: 3,
              total: 3000
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
          date: 'Factura 1 de enero 2018',
          items: [
            {
              product: 'Bafles',
              quantity: 2,
              total: 100000
            }
          ],
        },
        {
          date: 'Factura 5 de febrero 2019',
          items: [
            {
              product: 'Audifonos',
              quantity: 4,
              total: 25000
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
          date: 'Factura 2 de marzo 2022',
          items: [
            {
              product: 'Camiseta',
              quantity: 10,
              total: 200000
            }
          ],
        },
        {
          date: 'Factura 3 de marzo 2022',
          items: [
            {
              product: 'Pantalon',
              quantity: 3,
              total: 235900
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
          date: 'Factura 7 de diciembre 2015',
          items: [
            {
              product: 'Foco',
              quantity: 5,
              total: 15000
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
          date: 'Factura 1 de junio 2021',
          items: [
            {
              product: 'Video Beam',
              quantity: 2,
              total: 305000
            }
          ],
        },
        {
          date: 'Factura 1 de junio 2021',
          items: [
            {
              product: 'Celular',
              quantity: 4,
              total: 900000
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
          date: 'Factura 22 de abril 2016',
          items: [
            {
              product: 'Termo',
              quantity: 10,
              total: 58350
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
          date: 'Factura 7 de agosto 2020',
          items: [
            {
              product: 'Locion',
              quantity: 2,
              total: 70000
            }
          ],
        },
        {
          date: 'Factura 22 de noviembre 2020',
          items: [
            {
              product: 'Desodorante',
              quantity: 1,
              total: 90000
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
