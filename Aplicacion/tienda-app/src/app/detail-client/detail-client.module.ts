import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DetailClientPage } from './detail-client.page';

import { IonicModule } from '@ionic/angular';

import { DetailClientPageRoutingModule } from './detail-client-routing.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    DetailClientPageRoutingModule
  ],
  declarations: [DetailClientPage]
})
export class DetailClientPageModule {}
