import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminComponent } from './admin/admin.component';
import { ThemeBasicModule } from '@abp/ng.theme.basic';

@NgModule({
  declarations: [AdminComponent],
  imports: [CommonModule, ThemeBasicModule],
  exports: [AdminComponent],
})
export class LayoutsModule {}
