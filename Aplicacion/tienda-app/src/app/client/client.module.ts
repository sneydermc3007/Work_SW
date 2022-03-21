import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IonicModule } from '@ionic/angular';

import { ClientPage } from './client.page';
import { ClientePageRoutingModule } from './client-routing.module';
import { CardDataComponentModule } from '../components/card-data/card-data.module';

@NgModule({
  imports: [
    CommonModule,
    IonicModule,
    CardDataComponentModule,
    ClientePageRoutingModule
  ],
  declarations: [ClientPage]
})
export class ClientPageModule {}
