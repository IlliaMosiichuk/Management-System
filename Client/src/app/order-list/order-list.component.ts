import { Component, OnInit } from '@angular/core';
import { OrderService } from '../_services/order.service';
import { OrderList } from '../_models/order';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css']
})
export class OrderListComponent implements OnInit {
  orderList: OrderList;
  constructor(private orderService: OrderService) { }

  ngOnInit() {
    this.getOrders();
  }

  getOrders() {
    this.orderService.getList().subscribe(orderList => {
      this.orderList = orderList;
    });
  }

}
