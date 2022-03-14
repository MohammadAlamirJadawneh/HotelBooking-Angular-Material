import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientRoutingModule } from './client-routing.module';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
@NgModule({
  imports: [
    CommonModule,
    ClientRoutingModule,
    MatToolbarModule,
    MatIconModule,
    MatCardModule
  ]
})
export class ClientModule {
}
