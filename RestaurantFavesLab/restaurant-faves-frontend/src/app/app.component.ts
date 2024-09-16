import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { DisplayOrdersComponent } from "./components/display-orders/display-orders.component";
import { AddOrderComponent } from "./components/add-order/add-order.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, DisplayOrdersComponent, AddOrderComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'restaurant-faves-frontend';
}
