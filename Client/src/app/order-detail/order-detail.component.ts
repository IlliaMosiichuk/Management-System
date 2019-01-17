import { Component, OnInit } from '@angular/core';
import { Order } from '../_models/order';
import { OrderService } from '../_services/order.service';
import { ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-order-detail',
  templateUrl: './order-detail.component.html',
  styleUrls: ['./order-detail.component.css']
})
export class OrderDetailComponent implements OnInit {
  orderForm: FormGroup;
  order: Order;
  constructor(
    private formBuilder: FormBuilder,
    private orderService: OrderService,
    private route: ActivatedRoute) { }

  ngOnInit() {
    this.getOrder();
  }

  getOrder() {
    let id = this.route.snapshot.paramMap.get('id');
    this.orderService.get(id).subscribe(order => {
      this.order = order;
      this.orderForm = this.formBuilder.group({
        reference: [this.order.reference],
        processed: [this.order.processed],
        trackingNumber: [this.order.trackingNumber],
      });
    });
  }

  get f() { return this.orderForm.controls; }

  onSubmit() {
    if (this.orderForm.invalid) {
      return;
    }

    this.order.trackingNumber = this.f.trackingNumber.value;
    this.order.processed = this.f.processed.value;
    this.order.reference = this.f.reference.value;

    this.orderService.post(this.order).subscribe(
        order => {
        }
    );
  }
}
