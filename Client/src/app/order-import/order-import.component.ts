import { Component, OnInit } from '@angular/core';
import { OrderService } from '../_services/order.service';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpEventType } from '@angular/common/http';

@Component({
  selector: 'app-order-import',
  templateUrl: './order-import.component.html',
  styleUrls: ['./order-import.component.css']
})
export class OrderImportComponent implements OnInit {
  constructor(
    private orderService: OrderService, 
    private router: Router) { }

  ngOnInit() {
  }

  upload(files: any) {
    if (files.length === 0){
      return;
    }

    this.orderService.import(files[0]).subscribe(result => {
        this.router.navigate(['/orders']);
    });
  }


}
