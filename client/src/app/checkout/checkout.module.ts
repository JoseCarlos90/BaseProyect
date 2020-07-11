import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CheckoutComponent } from './checkout.component';
import { CheckoutRoutingModule } from './checkout-routing.module';
import { SharedModule } from '../shared/shared.module';
import { CheckoutSuccessComponent } from './checkout-success/checkout-success.component';
import { CheckoutPaymentComponent } from './checkout-payment/checkout-payment.component';
import { CheckoutReviewComponent } from './checkout-review/checkout-review.component';
import { CheckoutDeliveryComponent } from './checkout-delivery/checkout-delivery.component';
import { CheckoutAddressComponent } from './checkout-address/checkout-address.component';


@NgModule({
  // tslint:disable-next-line: max-line-length
  declarations: [CheckoutComponent, CheckoutSuccessComponent, CheckoutPaymentComponent, CheckoutReviewComponent, CheckoutDeliveryComponent, CheckoutAddressComponent],
  imports: [
    CommonModule,
    CheckoutRoutingModule,
    SharedModule
  ]
})
export class CheckoutModule { }
