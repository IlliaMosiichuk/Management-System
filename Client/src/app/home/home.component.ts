import { Component, OnInit } from '@angular/core';
import { first } from 'rxjs/operators';
import { OrderService } from '../_services/order.service';
import { OrderList } from '../_models/order';

@Component({ templateUrl: 'home.component.html' })
export class HomeComponent implements OnInit {
  orderList: OrderList;
  
  constructor() { }

  ngOnInit() {
  }
}