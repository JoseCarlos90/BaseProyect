import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { ShopComponent } from './shop.component';
import { ProductDetailComponent } from './product-detail.component';

const routes: Routes = [
  { path: '', component: ShopComponent},
  { path: ':id', component: ProductDetailComponent, data: {breadcrumb: {alias: 'productDetails'}}}
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})
export class ShopRoutingModule { }
