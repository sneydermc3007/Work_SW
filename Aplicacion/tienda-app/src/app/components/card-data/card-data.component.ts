import { Component, OnInit, Input } from '@angular/core';
import { Data, Invoice } from '../../interfaces/data.interface';

@Component({
  selector: 'app-card-data',
  templateUrl: './card-data.component.html',
  styleUrls: ['./card-data.component.scss'],
})
export class CardDataComponent implements OnInit {
  @Input() data?: Data;
  @Input() invoice?: Invoice;
  
  constructor() { }

  ngOnInit() {}

  isIos() {
    const win = window as any;
    return win && win.Ionic && win.Ionic.mode === 'ios';
  }
}
