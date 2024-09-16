import { Component, EventEmitter, Output } from '@angular/core';
import { DisplayOrdersComponent } from '../display-orders/display-orders.component';
import { CreateOrderDto } from '../../models/create-order-dto';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add-order',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './add-order.component.html',
  styleUrl: './add-order.component.css'
})
export class AddOrderComponent {
  
  @Output() orderSave = new EventEmitter<CreateOrderDto>();

  description: string = "";
  restaurant: string = "";
  rating: number = 0;
  orderAgain: boolean = false;

  emitOrder() {
    let createdOrder: CreateOrderDto = {description: this.description, restaurant: this.restaurant, rating: this.rating, orderAgain: this.orderAgain}
    this.orderSave.emit(createdOrder);
    this.description = "";
    this.restaurant = "";
    this.rating = 0;
    this.orderAgain = false;
  }
}
