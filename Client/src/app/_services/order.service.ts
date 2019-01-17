import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from '../_models/user';
import { environment } from 'src/environments/environment';
import { OrderList, Order } from '../_models/order';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(private httpClient: HttpClient) {

  }

  getList() {
    return this.httpClient.get<OrderList>(`${environment.apiUrl}/orders/get`)
  }

  get(id: string){
    return this.httpClient.get<Order>(`${environment.apiUrl}/orders/get/${id}`);
  }

  post(order: Order){
    return this.httpClient.post(`${environment.apiUrl}/orders/post/`, order);
  }

  import(file) {
    const formData = new FormData();
    formData.append(file.name, file);
    const request = new HttpRequest('Post', `${environment.apiUrl}/orders/import`, formData);
    return this.httpClient.request(request);
  }
}
