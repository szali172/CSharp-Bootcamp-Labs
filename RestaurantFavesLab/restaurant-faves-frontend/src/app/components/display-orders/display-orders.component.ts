import { Component, inject, Input } from '@angular/core';
import { Order } from '../../models/order';
import { CreateOrderDto } from '../../models/create-order-dto';
import { OrderService } from '../../services/order.service';
import { CommonModule } from '@angular/common';
import { AddOrderComponent } from '../add-order/add-order.component';

@Component({
  selector: 'app-display-orders',
  standalone: true,
  imports: [CommonModule, AddOrderComponent],
  templateUrl: './display-orders.component.html',
  styleUrl: './display-orders.component.css'
})
export class DisplayOrdersComponent {
  orderService = inject(OrderService);
  orders: Order[] = [];

  
  ngOnInit() {
    this.loadOrders();
  }


  loadOrders() : void {
    this.orderService.getAllOrders().subscribe(
      (orders) =>{
        this.orders = orders;
    })
  }


  createOrder(event: CreateOrderDto) : void {
    this.orderService.createNewOrder(event).subscribe(
      (order) => {
        this.loadOrders()
        console.log("Order received!")
        console.log(this.orders);
      }
    )
  }

  deleteOrder(orderId: number) : void{
    this.orderService.deleteOrder(orderId).subscribe(
      (response) => {
        console.log(response);
      }
    );
    // remove the order from the displayed list as well
    this.orders = this.orders.filter(({ id }) => id != orderId)
  }


}
