import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomePage } from './home.page';
import { ReactiveFormsModule } from '@angular/forms';
import { DemoMaterialModule } from 'src/app/material-module';

@NgModule({
  declarations: [HomePage],
  imports: [CommonModule, DemoMaterialModule, ReactiveFormsModule],
})
export class HomeModule {}
