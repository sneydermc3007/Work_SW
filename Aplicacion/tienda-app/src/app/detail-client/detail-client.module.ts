import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DetailClientPage } from './detail-client.page';

import { IonicModule } from '@ionic/angular';

import { DetailClientPageRoutingModule } from './detail-client-routing.module';
import { CardDataComponentModule } from '../components/card-data/card-data.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    DetailClientPageRoutingModule,
    CardDataComponentModule
  ],
  declarations: [DetailClientPage]
})
export class DetailClientPageModule {}
