import { HttpClient, HttpEvent } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../models/order';
import { CreateOrderDto } from '../models/create-order-dto';
import { UpdateOrderDto } from '../models/update-order-dto';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  host: string = "https://localhost:7069/api/Orders";

  constructor(private http:HttpClient) { }

  getAllOrders() : Observable<Order[]> {
    return this.http.get<Order[]>(`${this.host}`)
  }

  getOrderById(id: number) : Observable<Order> {
    return this.http.get<Order>(`${this.host}/${id}`)
  }

  createNewOrder(createDto: CreateOrderDto) : Observable<Order> {
    return this.http.post<Order>(`${this.host}`, createDto)
  }

  updateOrder(id: number, updateDto: UpdateOrderDto) : Observable<Order> {
    return this.http.put<Order>(`${this.host}/${id}`, updateDto)
  }

  deleteOrder(id: number) : Observable<HttpEvent<any>> {
    return this.http.delete<HttpEvent<any>>(`${this.host}/${id}`)
  }
}
